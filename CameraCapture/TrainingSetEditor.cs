using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util; 
using Emgu.CV.CvEnum;
using System.Data.OleDb;
using System.IO;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace LiveFaceDetection
{
    public partial class TrainingSetEditor : Form
    {
        private Capture capture;
        Image<Bgr, Byte> TestImage;    
        private HaarCascade haar;           
        private int WindowsSize = 25;
        private Double ScaleIncreaseRate = 1.1;
        private int MinNeighbors = 3;

        int faceNo = 0;             
        Bitmap[] EXfaces;

        OleDbConnection Conn = new OleDbConnection();

        DataTable TSTable = new DataTable();
        DataTable AttdTable = new DataTable();

        int TotalRows = 0;
        int rowNum = 0;
        private OleDbDataAdapter dbDataAdapter;
        private OleDbDataAdapter attdDataAdapter;

        Image<Gray, Byte>[] TrainingSetImages;
        String[] Labels;

        EigenObjectRecognizer _FaceRecognition;

        public TrainingSetEditor()
        {
            InitializeComponent();
        }

        private void TrainingSetEditor_Load(object sender, EventArgs e)
        {
            haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");

            ConnToDB();

            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog.FileName);
                TestImage = new Image<Bgr, byte>(new Bitmap(InputImg));
                CamImageBox.Image = TestImage;
                
                DetectFaces();
            }
        }     
        
        private void btnStart_Click(object sender, EventArgs e)
        {         

            if (capture != null)
            {
                if (btnStart.Text == "Extract Face")
                {
                    btnStart.Text = "Resume Live Video"; //

                    Application.Idle -= ProcessFrame;

                    DetectFaces(); 
                }
                else
                {
                    btnStart.Text = "Extract Face";
                    Application.Idle += ProcessFrame;
                }
            }
        }
      
        private void ProcessFrame(object sender, EventArgs arg)
        {

            TestImage = capture.QueryFrame();

            CamImageBox.Image = TestImage;   
        }

        private void cbCamIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CamNumber = -1;
            CamNumber = int.Parse(cbCamIndex.Text);

            if (capture == null)
            {
                try
                {
                    capture = new Capture(CamNumber);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }

            btnStart_Click(sender, e);
            btnStart.Enabled = true;
        }
        
        private void ReleaseCamera()
        {
            if (capture != null)
            {
                Application.Idle -= ProcessFrame;
                capture.Dispose();
                
            }
        }
        
        private void DetectFaces()
        {
            Image<Gray, byte> grayframe = TestImage.Convert<Gray, byte>();
            
            MinNeighbors = int.Parse(comboBoxMinNeigh.Text);  // the 3rd parameter
            WindowsSize = int.Parse(textBoxWinSiz.Text);   // the 5th parameter
            ScaleIncreaseRate = Double.Parse(comboBoxScIncRte.Text); //the 2nd parameter

            var faces = grayframe.DetectHaarCascade(haar, ScaleIncreaseRate, MinNeighbors,
                                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                    new Size(WindowsSize, WindowsSize))[0];
            if (faces.Length > 0)
            {
                MessageBox.Show("Total Faces Detected: " + faces.Length.ToString());

                Bitmap BmpInput = grayframe.ToBitmap();
                Bitmap ExtractedFace;  // an empty "box"/"image" to hold the extracted face.

                Graphics FaceCanvas;

                EXfaces = new Bitmap[faces.Length];
                int i = 0;
                
                foreach (var face in faces)
                {
                    TestImage.Draw(face.rect, new Bgr(Color.Green), 3);

                    ExtractedFace = new Bitmap(face.rect.Width, face.rect.Height);

                    FaceCanvas = Graphics.FromImage(ExtractedFace);
                    
                    FaceCanvas.DrawImage(BmpInput, 0, 0, face.rect, GraphicsUnit.Pixel);

                    EXfaces[i] = ExtractedFace;
                    i++;

                }
                CamImageBox.Image = TestImage;

                MessageBox.Show(faces.Length.ToString() + " Face(s) Extracted sucessfully!");
                pbCollectedFaces.Image = EXfaces[0];
                btnAddtoTS.Enabled = true;
                txtBoxFaceName.Enabled = true;
                if (faces.Length > 1)
                {
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                }
                else
                {
                    btnNext.Enabled = false;
                    btnPrev.Enabled = false;
                }
            }
            else
                MessageBox.Show("NO faces Detected!");
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (faceNo < EXfaces.Length - 1)
            {

                faceNo++;
                pbCollectedFaces.Image = EXfaces[faceNo];

            }
            else
                MessageBox.Show("this is the LAST image!");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (faceNo > 0)
            {
                faceNo--;
                pbCollectedFaces.Image = EXfaces[faceNo];
            }
            else
                MessageBox.Show("this is the 1st image!");
        }          

        private void btnAddtoTS_Click(object sender, EventArgs e)
        {
            AddFaceToDB(pbCollectedFaces.Image, txtBoxFaceName.Text);
        }
        
        private byte[] ConvertToDBFormat(Image InputImage)
        {
            Bitmap BMPImage = new Bitmap(InputImage);

            MemoryStream stream = new MemoryStream();

            BMPImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] ImageAsBytes = stream.ToArray();

            return ImageAsBytes;
        }
        private void AddFaceToDB(Image InputFace, string FaceName)
        {
            if(Conn.State.Equals(ConnectionState.Closed))
            {
                Conn.Open();
            }

            try
            {
                byte[] FaceAsBytes = ConvertToDBFormat(InputFace);
                TotalRows++;
                OleDbCommand insert = new OleDbCommand("insert into TrainingSet1 values('" + TotalRows.ToString() + "','" + FaceName + "',@FaceImg)", Conn);

                OleDbParameter imageParameter = insert.Parameters.AddWithValue("@FaceImg", SqlDbType.Binary);
                imageParameter.Value = FaceAsBytes;
                imageParameter.Size = FaceAsBytes.Length;

                OleDbCommand attdinsert = new OleDbCommand("insert into AttendanceDataBase values('" + FaceName + "','A','A','A','A','A','A')", Conn);

                int rowsAffected = insert.ExecuteNonQuery();
                attdinsert.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                //MessageBox.Show(e.StackTrace.ToString());
            }
            finally
            {
                RefreshDBConn();

                rowNum = TotalRows - 1;

                pbTSFace.Image = GetFaceFromDB();

                txtBoxNewLabel.Text = TSTable.Rows[rowNum]["FaceName"].ToString();

                lblFaceNo.Text = (rowNum + 1).ToString();
            }
        }
        
        
        private Image GetFaceFromDB()
        {
            Image FetchedIMG;

            if(rowNum>0)
            {
                byte[] FetchedIMGBytes = (byte[])TSTable.Rows[rowNum]["FaceImage"];

                MemoryStream stream = new MemoryStream(FetchedIMGBytes);

                FetchedIMG = Image.FromStream(stream);

                return FetchedIMG;
            }

            MessageBox.Show("There are no images in the databases yet, add them.");
                
            return null;
           
        }

        private void btnTSFirst_Click(object sender, EventArgs e)
        {
            RefreshDBConn();
            try
            {
                rowNum = 0;

                pbTSFace.Image = GetFaceFromDB();

                txtBoxNewLabel.Text = TSTable.Rows[rowNum]["FaceName"].ToString();

                lblFaceNo.Text = (rowNum + 1).ToString();
            }
            catch(Exception w)
            {

            }
        }

        private void btnTSPrev_Click(object sender, EventArgs e)
        {
            if(rowNum>0)
            {
                rowNum--;
                pbTSFace.Image = GetFaceFromDB();
                txtBoxNewLabel.Text = TSTable.Rows[rowNum]["FaceName"].ToString();
                lblFaceNo.Text = (rowNum + 1).ToString();
            }
        }

        private void btnTSNxt_Click(object sender, EventArgs e)
        {
            if (rowNum < TSTable.Rows.Count - 1)
            {
                rowNum++;
                pbTSFace.Image = GetFaceFromDB();
                txtBoxNewLabel.Text = TSTable.Rows[rowNum]["FaceName"].ToString();
                lblFaceNo.Text = (rowNum + 1).ToString();
            }
        }

        private void btnLoadTSLast_Click(object sender, EventArgs e)
        {
            RefreshDBConn();

            try
            {
                rowNum = TotalRows - 1;

                pbTSFace.Image = GetFaceFromDB();

                txtBoxNewLabel.Text = TSTable.Rows[rowNum]["FaceName"].ToString();

                lblFaceNo.Text = (rowNum + 1).ToString();
            }
            catch(Exception ex)
            {

            }
        }


        private void btnUpdateFace_Click(object sender, EventArgs e)
        {
            if (Conn.State.Equals(ConnectionState.Closed))
            {
                Conn.Open();
            }
            try
            {

                lblFaceNo.Text = (rowNum + 1).ToString();

                String prevName = (String)TSTable.Rows[rowNum]["FaceName"];

                TSTable.Rows[rowNum]["FaceName"] = txtBoxNewLabel.Text;

                dbDataAdapter.Update(TSTable);

                OleDbCommand attdupdate = new OleDbCommand("update AttendanceDataBase set FaceName='" + txtBoxNewLabel.Text + "' where FaceName = '" + prevName + "'", Conn);
                attdupdate.ExecuteNonQuery();
            }
            catch(Exception q)
            {

            }
        }
 
        private void btnDelFace_Click(object sender, EventArgs e)
        {
            if (Conn.State.Equals(ConnectionState.Closed))
            {
                Conn.Open();
            }
            try
            {
                if (rowNum >= 0)
                {
                    String Name = TSTable.Rows[rowNum]["FaceName"].ToString();
                    OleDbCommand attddelete = new OleDbCommand("delete from AttendanceDataBase where FaceName = '" + Name.ToString() + "'", Conn);
                    attddelete.ExecuteNonQuery();

                    TSTable.Rows[rowNum].Delete();
                    dbDataAdapter.Update(TSTable);
                    rowNum--;
                    if (rowNum > 0)
                    {
                        pbTSFace.Image = GetFaceFromDB();
                        txtBoxFaceName.Text = TSTable.Rows[rowNum]["FaceName"].ToString();
                        lblFaceNo.Text = (rowNum + 1).ToString();

                        
                    }
                    else
                    {
                        pbTSFace.Image = null;
                        txtBoxFaceName.Text = null;
                        lblFaceNo.Text = null;
                        txtBoxNewLabel.Text = null;
                    }
                    /*for(int i =rowNum; i<TotalRows; i++)
                    {
                        TSTable.Rows[i]["FaceID"] = i.ToString();
                    }
                    dbDataAdapter.Update(TSTable);*/
                }

                else
                {
                    MessageBox.Show("Cannot Delete!!");

                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Cannot Delete!!");
            }
        }


        private void ConnToDB()
        {
            Conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FacesDatabase.mdb";
            Conn.Open();

            dbDataAdapter = new OleDbDataAdapter("Select * from TrainingSet1", Conn);
            attdDataAdapter = new OleDbDataAdapter("Select * from AttendanceDataBase", Conn);

            OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(dbDataAdapter);
            OleDbCommandBuilder attdCommandBuilder = new OleDbCommandBuilder(attdDataAdapter);

            dbDataAdapter.Fill(TSTable);
            attdDataAdapter.Fill(AttdTable);
            
            if (TSTable.Rows.Count != 0)
            {
                TotalRows = TSTable.Rows.Count;
            }
        }

        private void RefreshDBConn()
        {
            if(Conn.State.Equals(ConnectionState.Open))
            {
                Conn.Close();
                TSTable.Clear();
                ConnToDB();
            }
        }

        private void RecogFaces_Click(object sender, EventArgs e)
        {
            if (Conn.State.Equals(ConnectionState.Closed))
            {
                Conn.Open();
            }
            DetectedFaceList.Text = "Detected Faces\n";
            int i = 0;
            String[] label = new String[TotalRows];
            Image<Gray, Byte>[] TestImages = new Image<Gray, byte>[EXfaces.Length];
            for (i = 0; i < EXfaces.Length; i++)
            {
                TestImages[i] =  new Image<Gray, Byte>(EXfaces[i]);
                TestImages[i] = TestImages[i].Resize(100, 100, INTER.CV_INTER_LINEAR);
                label[i] = _FaceRecognition.Recognize(TestImages[i]);
                DetectedFaceList.Text = DetectedFaceList.Text + "\n" + label[i];
            }
            try
            {
                OleDbCommand updateAttd;
                DateTime t = DateTime.Now;
                String Day = t.DayOfWeek.ToString();
                for (i = 0; i < label.Length; i++)
                {
                    if (label[i] != null)
                    {
                        updateAttd = new OleDbCommand("update AttendanceDataBase set " + Day.ToString() + " = 'P' where FaceName = '" + label[i] + "'", Conn);
                        updateAttd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception errr)
            {

            }
        }

        private void TrainFaces_Click(object sender, EventArgs e)
        {
            TrainingSetImages = new Image<Gray, byte>[TotalRows-1];
            //Image<Gray, Byte>[] resizedTrainingSetImages = new Image<Gray, Byte>[TotalRows - 1];
            TotalRows = TSTable.Rows.Count;
            rowNum = 0;
            Labels = new String[TotalRows-1];
            for (rowNum = 1; rowNum < TotalRows; rowNum++)
            {
                Bitmap temp = (Bitmap)GetFaceFromDB();
                TrainingSetImages[rowNum - 1] = new Image<Gray, byte>(temp);
                Labels[rowNum - 1] = TSTable.Rows[rowNum]["FaceName"].ToString();

                //pbCollectedFaces = (Image)((Bitmap) TrainingSetImages[rowNum-1]);
                TrainingSetImages[rowNum-1] = TrainingSetImages[rowNum-1].Resize(100, 100, INTER.CV_INTER_LINEAR);
            }
            MCvTermCriteria TermCrit = new MCvTermCriteria(16, 0.001);

            _FaceRecognition = new EigenObjectRecognizer(TrainingSetImages,Labels,5000,ref TermCrit);
        }
    }

}