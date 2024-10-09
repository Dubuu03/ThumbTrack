using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Main
{
    public partial class formRegister : Form
    {
        private VideoCaptureDevice videoSource;
        private bool isCameraRunning = false;
        private string defaultImagePath = @"..\..\..\Student Photo\Default.png";
        private Bitmap lastCapturedImage;

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
            pictureBoxPhoto.Height = 287;
        }

        private void formRegister_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentID;
            string name = txtName.Text;
            string course = txtCourse.Text;
            string section = txtSection.Text;
            string password = txtPassword.Text;
            int year;

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

            string filePath = null;
            if (pictureBoxPhoto.Image != null)
            {
                string fileName = $"{studentID}.jpg";
                string folderPath = @"..\..\..\Student Photo";
                filePath = Path.Combine(folderPath, fileName);
                pictureBoxPhoto.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            if (db.RegisterStudent(studentID, name, course, year, section, password, filePath))
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

        private void btnStartCamera_Click(object sender, EventArgs e)
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
    }
}
