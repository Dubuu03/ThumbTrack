using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using DPFP;
using DPFP.Capture;

namespace Main
{
    public partial class formRegister : Form, DPFP.Capture.EventHandler
    {
        private VideoCaptureDevice videoSource;
        private bool isCameraRunning = false;
        private bool isScannerRunning = false;
        private bool isFingerprintEnrolled = false;
        private string defaultImagePath = @"..\..\..\Student Photo\Default.png";
        private Bitmap lastCapturedImage;

        protected DPFP.Processing.Enrollment Enroller;

        private DPFP.Capture.Capture Capturer;
        private byte[] fingerprintData;
        public int StudentID { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public string Password { get; set; }
        public int Year { get; set; }
        public string name;

        public formRegister()
        {
            InitializeComponent();

            if (File.Exists(defaultImagePath))
            {
                pictureBoxPhoto.Image = Image.FromFile(defaultImagePath);
            }

            txtPassword.PasswordChar = '*';

            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.Width = 287;
            pictureBoxPhoto.Height = 280;

            InitializeFingerprintCapture();

            btnRegister.Enabled = false;

            txtStudentID.TextChanged += ValidateInputFields;
            txtName.TextChanged += ValidateInputFields;
            txtCourse.TextChanged += ValidateInputFields;
            txtYear.TextChanged += ValidateInputFields;
            txtSection.TextChanged += ValidateInputFields;
            txtPassword.TextChanged += ValidateInputFields;
        }

        private void formRegister_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        protected void SetPrompt(string prompt)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    Prompt.Text = prompt;
                }));
            }
            else
            {
                Prompt.Text = prompt;
            }
        }

        protected void SetStatus(string status)
        {
            if (statusLabel.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    statusLabel.Text = status;
                    statusLabel.Refresh();
                }));
            }
        }

        private void UpdateStatus()
        {
            SetStatus(String.Format("Fingerprint sample needed: {0}", Enroller.FeaturesNeeded));
        }

        protected void MakeReport(string message)
        {
            this.Invoke(new Action(() =>
            {
                statusText.AppendText(message + "\r\n");
            }));
        }
        protected virtual void InitializeFingerprintCapture()
        {
            try
            {
                Console.WriteLine("Initializing fingerprint capture...");
                Capturer = new DPFP.Capture.Capture();
                Enroller = new DPFP.Processing.Enrollment();
                if (Capturer != null)
                {
                    Capturer.EventHandler = this;
                    SetPrompt("Press start scan to start scanning.");
                    Console.WriteLine("Fingerprint capture initialized successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to initialize fingerprint capture: Capturer is null.");
                    SetPrompt("Cannot initiate capture operation. Capturer is null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during initialization: {ex}");
                SetPrompt($"Cannot initiate capture operation: {ex.Message}");
            }
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
            fingerprintData = ConvertSampleToByteArray(Sample);

            // Extract features and update the Enroller
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            if (features != null)
            {
                try
                {
                    MakeReport("The fingerprint feature set was created");
                    Enroller.AddFeatures(features); // Add features to Enroller
                }
                catch (DPFP.Error.SDKException)
                {
                    // Show message box on failure and reset enrollment
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Enrollment procedure failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enroller.Clear();
                        UpdateStatus();
                    });
                    return;
                }

                UpdateStatus(); // Show remaining samples needed

                // Check enrollment status
                this.Invoke((MethodInvoker)delegate
                {
                    if (Enroller.TemplateStatus == DPFP.Processing.Enrollment.Status.Ready)
                    {
                        // Enrollment is successful
                        MessageBox.Show("Fingerprint enrollment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetStatus("Success. Fingerprint Accepted");
                        btnStart.Text = "START SCAN";
                        isScannerRunning = false;
                        StopFingerprintCapture();

                        // Reset the Enroller for the next enrollment
                        Enroller = new DPFP.Processing.Enrollment();

                        isFingerprintEnrolled = true; // Mark as successfully enrolled
                        ValidateInputFields(null, null);

                    }
                    else if (Enroller.TemplateStatus == DPFP.Processing.Enrollment.Status.Failed)
                    {
                        // If enrollment failed, reset
                        MessageBox.Show("Enrollment procedure failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetEnrollment(); // Reset after failure
                    }
                });
            }
        }


        private void ResetEnrollment()
        {
            Enroller = new DPFP.Processing.Enrollment();
            fingerprintData = null;
            UpdateStatus();
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Action(delegate
            {
                fImage.Image = new Bitmap(bitmap, fImage.Size);
            }));
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Converter = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Converter.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        private byte[] ConvertSampleToByteArray(DPFP.Sample sample)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DPFP.Capture.SampleConversion converter = new DPFP.Capture.SampleConversion();
                Bitmap bmp = ConvertSampleToBitmap(sample);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }

        protected void StartFingerprintCapture()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StartCapture();
                    UpdateStatus();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Can't initiate capture.");
                }
            }
        }


        protected void StopFingerprintCapture()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StopCapture();
                    SetPrompt("Press start scan to start scanning.");
                }
                catch
                {
                    SetPrompt("Can't stop capture.");
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isScannerRunning)
            {
                StopFingerprintCapture();
                statusText.Clear();
                SetStatus("Press start scan to begin.");
                isScannerRunning = false;
                btnStart.Text = "START SCAN";
                timer1.Dispose();
            }
            else
            {
                StartFingerprintCapture();
                isScannerRunning = true;
                btnStart.Text = "STOP SCAN";
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();

            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        private void ValidateInputFields(object sender, EventArgs e)
        {
            btnRegister.Enabled = !string.IsNullOrWhiteSpace(txtStudentID.Text) &&
                                  !string.IsNullOrWhiteSpace(txtName.Text) &&
                                  !string.IsNullOrWhiteSpace(txtCourse.Text) &&
                                  !string.IsNullOrWhiteSpace(txtYear.Text) &&
                                  !string.IsNullOrWhiteSpace(txtSection.Text) &&
                                  !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                                  isFingerprintEnrolled;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentID;
            string name = txtName.Text;
            string course = txtCourse.Text;
            string section = txtSection.Text;
            string password = txtPassword.Text;
            int year;

            // Validate Student ID and Year as integers
            if (!int.TryParse(txtStudentID.Text, out studentID))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            // Validate password requirements
            if (password.Length != 6 || !password.All(char.IsDigit))
            {
                MessageBox.Show("Password must be exactly 6 digits.");
                return;
            }

            Database db = new Database();
            if (db.StudentIDExists(studentID))
            {
                MessageBox.Show("Student ID already exists. Please enter a different ID.");
                return;
            }

            // Save photo to file
            string filePath = null;
            if (pictureBoxPhoto.Image != null)
            {
                string fileName = $"{studentID}.jpg";
                string folderPath = @"..\..\..\Student Photo";
                filePath = Path.Combine(folderPath, fileName);
                pictureBoxPhoto.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            // Ensure fingerprint data is captured before registration
            if (fingerprintData == null || fingerprintData.Length == 0)
            {
                MessageBox.Show("Please capture a fingerprint before registering.");
                return;
            }

            // Register student with fingerprint data
            if (db.RegisterStudent(studentID, name, course, year, section, password, filePath, fingerprintData))
            {
                MessageBox.Show("Registration successful!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }


        private void ClearFields()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtYear.Clear();
            txtSection.Clear();
            txtPassword.Clear();
            pictureBoxPhoto.Image = Image.FromFile(defaultImagePath);

            if (isScannerRunning)
            {
                if (fImage.Image != null)
                {
                    fImage.Image = null;
                }

                ResetEnrollment();
                statusText.Text = string.Empty;
                Prompt.Text= "Using the fingerprint reader, scan your fingerprint.";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            StopCamera();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Student Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void btnStartCamera_Click_1(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                StopCamera();
            }
            else
            {
                StartCamera();
            }
        }

        private void StartCamera()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video sources found.");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();

            isCameraRunning = true;
            btnStartCamera.Text = "Stop Camera";
        }

        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }

            isCameraRunning = false;
            btnStartCamera.Text = "Start Camera";
            pictureBoxPhoto.Image = Image.FromFile(defaultImagePath);
        }


        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap videoFrame = (Bitmap)eventArgs.Frame.Clone();

            int cropSize = Math.Min(videoFrame.Width, videoFrame.Height);
            int cropX = (videoFrame.Width - cropSize) / 2;
            int cropY = (videoFrame.Height - cropSize) / 2; 


            Rectangle cropArea = new Rectangle(cropX, cropY, cropSize, cropSize);
            Bitmap croppedFrame = videoFrame.Clone(cropArea, videoFrame.PixelFormat);


            pictureBoxPhoto.Image = croppedFrame;
        }

        private void btnCapturePhoto_Click(object sender, EventArgs e)
        {
            CapturePhoto();
        }

        private void CapturePhoto()
        {
            if (videoSource == null || !videoSource.IsRunning)
            {
                MessageBox.Show("Camera is not running.");
                return;
            }

            if (pictureBoxPhoto.Image != null)
            {
                lastCapturedImage = (Bitmap)pictureBoxPhoto.Image.Clone();
                pictureBoxPhoto.Image = lastCapturedImage;
            }
            else
            {
                MessageBox.Show("No image to capture.");
            }

            StopCamera();
            pictureBoxPhoto.Image = lastCapturedImage;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again.");
            Process(Sample);
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
