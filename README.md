# Computer-Vision-and-image-recognition
Using OpenCV and C# as the base language.


Uses a simple algorithms for facial detection and recognition

Facial Detection
uses Voila jones method and Haar cascade for facial detection

Facial Recognition
uses PCA with Eigen faces for Facial Recognition

Pros
-Uses a simple algorithm, thus easy to understand
-Uses less processing power, because the above reason
-Parameters for facial detection could be set, for efficient facial detection
-Uses the popular OpenCV library for image processing

Constraints
-Facial Detection only works for cases where the face is straight, if tilted, face cannot be detected
-For unknown faces given as an input, the recognizer gives a name with the nearest face from the faces DB
