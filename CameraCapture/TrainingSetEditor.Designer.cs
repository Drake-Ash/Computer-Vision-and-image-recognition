namespace LiveFaceDetection
{
    partial class TrainingSetEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingSetEditor));
            this.cbCamIndex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxScIncRte = new System.Windows.Forms.ComboBox();
            this.comboBoxMinNeigh = new System.Windows.Forms.ComboBox();
            this.textBoxWinSiz = new System.Windows.Forms.TextBox();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFaceName = new System.Windows.Forms.TextBox();
            this.pbCollectedFaces = new System.Windows.Forms.PictureBox();
            this.btnAddtoTS = new System.Windows.Forms.Button();
            this.gBFaceAdder = new System.Windows.Forms.GroupBox();
            this.btnTSFirst = new System.Windows.Forms.Button();
            this.gbTSUpdate = new System.Windows.Forms.GroupBox();
            this.lblFaceNo = new System.Windows.Forms.Label();
            this.btnLoadTSLast = new System.Windows.Forms.Button();
            this.btnDelFace = new System.Windows.Forms.Button();
            this.pbTSFace = new System.Windows.Forms.PictureBox();
            this.btnUpdateFace = new System.Windows.Forms.Button();
            this.btnTSNxt = new System.Windows.Forms.Button();
            this.txtBoxNewLabel = new System.Windows.Forms.TextBox();
            this.btnTSPrev = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DetectedFaceList = new System.Windows.Forms.GroupBox();
            this.RecogFaces = new System.Windows.Forms.Button();
            this.TrainFaces = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollectedFaces)).BeginInit();
            this.gBFaceAdder.SuspendLayout();
            this.gbTSUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTSFace)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCamIndex.Location = new System.Drawing.Point(236, 361);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(57, 21);
            this.cbCamIndex.TabIndex = 4;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Camera:";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(296, 360);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Live Video!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Scale Increase Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min Neighbors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min.detection Scale\r\n(Window Size)";
            // 
            // comboBoxScIncRte
            // 
            this.comboBoxScIncRte.FormattingEnabled = true;
            this.comboBoxScIncRte.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4"});
            this.comboBoxScIncRte.Location = new System.Drawing.Point(130, 28);
            this.comboBoxScIncRte.Name = "comboBoxScIncRte";
            this.comboBoxScIncRte.Size = new System.Drawing.Size(64, 21);
            this.comboBoxScIncRte.TabIndex = 13;
            this.comboBoxScIncRte.Text = "1.1";
            // 
            // comboBoxMinNeigh
            // 
            this.comboBoxMinNeigh.FormattingEnabled = true;
            this.comboBoxMinNeigh.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxMinNeigh.Location = new System.Drawing.Point(130, 54);
            this.comboBoxMinNeigh.Name = "comboBoxMinNeigh";
            this.comboBoxMinNeigh.Size = new System.Drawing.Size(64, 21);
            this.comboBoxMinNeigh.TabIndex = 14;
            this.comboBoxMinNeigh.Text = "2";
            // 
            // textBoxWinSiz
            // 
            this.textBoxWinSiz.Location = new System.Drawing.Point(130, 81);
            this.textBoxWinSiz.Name = "textBoxWinSiz";
            this.textBoxWinSiz.Size = new System.Drawing.Size(64, 20);
            this.textBoxWinSiz.TabIndex = 15;
            this.textBoxWinSiz.Text = "25";
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(9, 13);
            this.CamImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(404, 291);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 359);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 24);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxWinSiz);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxMinNeigh);
            this.groupBox1.Controls.Add(this.comboBoxScIncRte);
            this.groupBox1.Location = new System.Drawing.Point(435, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(209, 119);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tune Detection Parameters:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(75, 139);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(17, 139);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(56, 23);
            this.btnPrev.TabIndex = 23;
            this.btnPrev.Text = "Prev.";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Set Face Label/Name:";
            // 
            // txtBoxFaceName
            // 
            this.txtBoxFaceName.Enabled = false;
            this.txtBoxFaceName.Location = new System.Drawing.Point(17, 184);
            this.txtBoxFaceName.Name = "txtBoxFaceName";
            this.txtBoxFaceName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFaceName.TabIndex = 21;
            // 
            // pbCollectedFaces
            // 
            this.pbCollectedFaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCollectedFaces.Location = new System.Drawing.Point(17, 19);
            this.pbCollectedFaces.Name = "pbCollectedFaces";
            this.pbCollectedFaces.Size = new System.Drawing.Size(104, 114);
            this.pbCollectedFaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCollectedFaces.TabIndex = 20;
            this.pbCollectedFaces.TabStop = false;
            // 
            // btnAddtoTS
            // 
            this.btnAddtoTS.BackColor = System.Drawing.Color.Plum;
            this.btnAddtoTS.Enabled = false;
            this.btnAddtoTS.Location = new System.Drawing.Point(17, 210);
            this.btnAddtoTS.Name = "btnAddtoTS";
            this.btnAddtoTS.Size = new System.Drawing.Size(115, 23);
            this.btnAddtoTS.TabIndex = 19;
            this.btnAddtoTS.Text = "Add to Training Set";
            this.btnAddtoTS.UseVisualStyleBackColor = false;
            this.btnAddtoTS.Click += new System.EventHandler(this.btnAddtoTS_Click);
            // 
            // gBFaceAdder
            // 
            this.gBFaceAdder.Controls.Add(this.pbCollectedFaces);
            this.gBFaceAdder.Controls.Add(this.btnAddtoTS);
            this.gBFaceAdder.Controls.Add(this.btnNext);
            this.gBFaceAdder.Controls.Add(this.txtBoxFaceName);
            this.gBFaceAdder.Controls.Add(this.btnPrev);
            this.gBFaceAdder.Controls.Add(this.label5);
            this.gBFaceAdder.Location = new System.Drawing.Point(418, 142);
            this.gBFaceAdder.Name = "gBFaceAdder";
            this.gBFaceAdder.Size = new System.Drawing.Size(145, 241);
            this.gBFaceAdder.TabIndex = 26;
            this.gBFaceAdder.TabStop = false;
            this.gBFaceAdder.Text = "Face Adder";
            // 
            // btnTSFirst
            // 
            this.btnTSFirst.Location = new System.Drawing.Point(5, 138);
            this.btnTSFirst.Name = "btnTSFirst";
            this.btnTSFirst.Size = new System.Drawing.Size(31, 23);
            this.btnTSFirst.TabIndex = 27;
            this.btnTSFirst.Text = "|<";
            this.btnTSFirst.UseVisualStyleBackColor = true;
            this.btnTSFirst.Click += new System.EventHandler(this.btnTSFirst_Click);
            // 
            // gbTSUpdate
            // 
            this.gbTSUpdate.Controls.Add(this.lblFaceNo);
            this.gbTSUpdate.Controls.Add(this.btnLoadTSLast);
            this.gbTSUpdate.Controls.Add(this.btnTSFirst);
            this.gbTSUpdate.Controls.Add(this.btnDelFace);
            this.gbTSUpdate.Controls.Add(this.pbTSFace);
            this.gbTSUpdate.Controls.Add(this.btnUpdateFace);
            this.gbTSUpdate.Controls.Add(this.btnTSNxt);
            this.gbTSUpdate.Controls.Add(this.txtBoxNewLabel);
            this.gbTSUpdate.Controls.Add(this.btnTSPrev);
            this.gbTSUpdate.Controls.Add(this.label7);
            this.gbTSUpdate.Location = new System.Drawing.Point(569, 142);
            this.gbTSUpdate.Name = "gbTSUpdate";
            this.gbTSUpdate.Size = new System.Drawing.Size(169, 241);
            this.gbTSUpdate.TabIndex = 28;
            this.gbTSUpdate.TabStop = false;
            this.gbTSUpdate.Text = "Training Set Viewer/Updater";
            // 
            // lblFaceNo
            // 
            this.lblFaceNo.AutoSize = true;
            this.lblFaceNo.Location = new System.Drawing.Point(126, 120);
            this.lblFaceNo.Name = "lblFaceNo";
            this.lblFaceNo.Size = new System.Drawing.Size(35, 13);
            this.lblFaceNo.TabIndex = 30;
            this.lblFaceNo.Text = "face#";
            // 
            // btnLoadTSLast
            // 
            this.btnLoadTSLast.Location = new System.Drawing.Point(109, 137);
            this.btnLoadTSLast.Name = "btnLoadTSLast";
            this.btnLoadTSLast.Size = new System.Drawing.Size(31, 24);
            this.btnLoadTSLast.TabIndex = 31;
            this.btnLoadTSLast.Text = ">|";
            this.btnLoadTSLast.UseVisualStyleBackColor = true;
            this.btnLoadTSLast.Click += new System.EventHandler(this.btnLoadTSLast_Click);
            // 
            // btnDelFace
            // 
            this.btnDelFace.Location = new System.Drawing.Point(114, 175);
            this.btnDelFace.Name = "btnDelFace";
            this.btnDelFace.Size = new System.Drawing.Size(47, 42);
            this.btnDelFace.TabIndex = 30;
            this.btnDelFace.Text = "Delete Face";
            this.btnDelFace.UseVisualStyleBackColor = true;
            this.btnDelFace.Click += new System.EventHandler(this.btnDelFace_Click);
            // 
            // pbTSFace
            // 
            this.pbTSFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTSFace.Location = new System.Drawing.Point(19, 19);
            this.pbTSFace.Name = "pbTSFace";
            this.pbTSFace.Size = new System.Drawing.Size(104, 114);
            this.pbTSFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTSFace.TabIndex = 20;
            this.pbTSFace.TabStop = false;
            // 
            // btnUpdateFace
            // 
            this.btnUpdateFace.Location = new System.Drawing.Point(7, 213);
            this.btnUpdateFace.Name = "btnUpdateFace";
            this.btnUpdateFace.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateFace.TabIndex = 19;
            this.btnUpdateFace.Text = "Update Face";
            this.btnUpdateFace.UseVisualStyleBackColor = true;
            this.btnUpdateFace.Click += new System.EventHandler(this.btnUpdateFace_Click);
            // 
            // btnTSNxt
            // 
            this.btnTSNxt.Location = new System.Drawing.Point(74, 138);
            this.btnTSNxt.Name = "btnTSNxt";
            this.btnTSNxt.Size = new System.Drawing.Size(29, 23);
            this.btnTSNxt.TabIndex = 24;
            this.btnTSNxt.Text = ">";
            this.btnTSNxt.UseVisualStyleBackColor = true;
            this.btnTSNxt.Click += new System.EventHandler(this.btnTSNxt_Click);
            // 
            // txtBoxNewLabel
            // 
            this.txtBoxNewLabel.Location = new System.Drawing.Point(7, 187);
            this.txtBoxNewLabel.Name = "txtBoxNewLabel";
            this.txtBoxNewLabel.Size = new System.Drawing.Size(96, 20);
            this.txtBoxNewLabel.TabIndex = 21;
            // 
            // btnTSPrev
            // 
            this.btnTSPrev.Location = new System.Drawing.Point(42, 138);
            this.btnTSPrev.Name = "btnTSPrev";
            this.btnTSPrev.Size = new System.Drawing.Size(26, 23);
            this.btnTSPrev.TabIndex = 23;
            this.btnTSPrev.Text = "<";
            this.btnTSPrev.UseVisualStyleBackColor = true;
            this.btnTSPrev.Click += new System.EventHandler(this.btnTSPrev_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Modify Face Name?";
            // 
            // DetectedFaceList
            // 
            this.DetectedFaceList.Location = new System.Drawing.Point(750, 13);
            this.DetectedFaceList.Name = "DetectedFaceList";
            this.DetectedFaceList.Size = new System.Drawing.Size(150, 369);
            this.DetectedFaceList.TabIndex = 29;
            this.DetectedFaceList.TabStop = false;
            this.DetectedFaceList.Text = "Detected Faces";
            // 
            // RecogFaces
            // 
            this.RecogFaces.Location = new System.Drawing.Point(649, 17);
            this.RecogFaces.Name = "RecogFaces";
            this.RecogFaces.Size = new System.Drawing.Size(95, 43);
            this.RecogFaces.TabIndex = 30;
            this.RecogFaces.Text = "Recognize Faces";
            this.RecogFaces.UseVisualStyleBackColor = true;
            this.RecogFaces.Click += new System.EventHandler(this.RecogFaces_Click);
            // 
            // TrainFaces
            // 
            this.TrainFaces.Location = new System.Drawing.Point(650, 83);
            this.TrainFaces.Name = "TrainFaces";
            this.TrainFaces.Size = new System.Drawing.Size(93, 46);
            this.TrainFaces.TabIndex = 31;
            this.TrainFaces.Text = "Train Faces";
            this.TrainFaces.UseVisualStyleBackColor = true;
            this.TrainFaces.Click += new System.EventHandler(this.TrainFaces_Click);
            // 
            // TrainingSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 388);
            this.Controls.Add(this.TrainFaces);
            this.Controls.Add(this.RecogFaces);
            this.Controls.Add(this.DetectedFaceList);
            this.Controls.Add(this.gbTSUpdate);
            this.Controls.Add(this.gBFaceAdder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.CamImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrainingSetEditor";
            this.Text = "Training Set Editor";
            this.Load += new System.EventHandler(this.TrainingSetEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollectedFaces)).EndInit();
            this.gBFaceAdder.ResumeLayout(false);
            this.gBFaceAdder.PerformLayout();
            this.gbTSUpdate.ResumeLayout(false);
            this.gbTSUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTSFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCamIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxScIncRte;
        private System.Windows.Forms.ComboBox comboBoxMinNeigh;
        private System.Windows.Forms.TextBox textBoxWinSiz;
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFaceName;
        private System.Windows.Forms.PictureBox pbCollectedFaces;
        private System.Windows.Forms.Button btnAddtoTS;
        private System.Windows.Forms.GroupBox gBFaceAdder;
        private System.Windows.Forms.Button btnTSFirst;
        private System.Windows.Forms.GroupBox gbTSUpdate;
        private System.Windows.Forms.PictureBox pbTSFace;
        private System.Windows.Forms.Button btnUpdateFace;
        private System.Windows.Forms.Button btnTSNxt;
        private System.Windows.Forms.TextBox txtBoxNewLabel;
        private System.Windows.Forms.Button btnTSPrev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelFace;
        private System.Windows.Forms.Button btnLoadTSLast;
        private System.Windows.Forms.Label lblFaceNo;
        private System.Windows.Forms.GroupBox DetectedFaceList;
        private System.Windows.Forms.Button RecogFaces;
        private System.Windows.Forms.Button TrainFaces;
    }
}

