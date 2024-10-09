using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Linq;

namespace Main
{
    public partial class formManage : Form
    {
        public formManage()
        {
            InitializeComponent();
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.Width = 287;
            pictureBoxPhoto.Height = 287;

            SetTextBoxesReadOnly(true);
            DisableActionButtons();

            txtPassword.Enabled = false;
        }

        private int currentStudentID;
        private string defaultImagePath = @"..\..\..\Student Photo\Default.png";
        private Bitmap lastCapturedImage;
        private VideoCaptureDevice videoSource;
        private bool isCameraRunning = false;

        private void formManage_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SetTextBoxesReadOnly(false);
            if (int.TryParse(tbStudentID.Text, out int studentID))
            {
                ShowStudentDetails(studentID);
                lbFingerprint.Text = "Ready ...";
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
                ResetForm();
            }
        }

        private void ShowStudentDetails(int studentID)
        {
            Database db = new Database();
            string query = $"SELECT Name, Course, Year, Section, Password FROM tblstudents WHERE StudentID = {studentID}";

            DataTable studentData = db.ExecuteQuery(query);

            if (studentData.Rows.Count > 0)
            {
                currentStudentID = studentID;
                txtName.Text = studentData.Rows[0]["Name"].ToString();
                txtCourse.Text = studentData.Rows[0]["Course"].ToString();
                txtYear.Text = studentData.Rows[0]["Year"].ToString();
                txtSection.Text = studentData.Rows[0]["Section"].ToString();

                LoadStudentPhoto(studentID);
                EnableActionButtons();
            }
            else
            {
                MessageBox.Show("Student not found.");
                ResetForm();
            }
        }

        private void LoadStudentPhoto(int studentID)
        {
            string photoPath = $@"..\..\..\Student Photo\{studentID}.jpg";
            if (File.Exists(photoPath))
            {
                try
                {
                    pictureBoxPhoto.Image = Image.FromFile(photoPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading photo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Photo not found.");
                pictureBoxPhoto.Image = Image.FromFile(defaultImagePath);
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
                    try
                    {
                        pictureBoxPhoto.Image = new Bitmap(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
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

        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = !txtPassword.Enabled;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Database db = new Database();
            bool isUpdated = db.UpdateStudent(currentStudentID, txtName.Text, txtCourse.Text, int.Parse(txtYear.Text),
                txtSection.Text, txtPassword.Enabled ? txtPassword.Text : null, null);

            if (isUpdated)
            {
                SaveStudentPhoto();
                MessageBox.Show("Student updated successfully!");
                ResetForm();
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.");
            }
        }



        private void SaveStudentPhoto()
        {
            string filePath = GetPhotoFilePath();
            string backupPath = filePath.Replace(".jpg", "_backup.jpg");

            BackupOldPhoto(filePath);

            try
            {
                if (pictureBoxPhoto.Image != null)
                {
                    pictureBoxPhoto.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    if (File.Exists(backupPath))
                    {
                        File.Delete(backupPath);
                    }
                }
                else
                {
                    MessageBox.Show("No photo to save.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving photo: " + ex.Message);
                throw;
            }
        }


        private void BackupOldPhoto(string filePath)
        {
            if (File.Exists(filePath))
            {
                string backupPath = filePath.Replace(".jpg", "_backup.jpg");
                File.Copy(filePath, backupPath, true); 
            }
        }


        private string GetPhotoFilePath()
        {
            return Path.Combine(@"..\..\..\Student Photo", $"{currentStudentID}.jpg");
        }

        private bool ValidateInput()
        {
            if (!int.TryParse(txtYear.Text, out _))
            {
                MessageBox.Show("Please enter a valid year.");
                return false;
            }

            if (txtPassword.Enabled && (txtPassword.Text.Length != 6 || !txtPassword.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Password must be exactly 6 digits.");
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            tbStudentID.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtYear.Clear();
            txtSection.Clear();
            txtPassword.Clear();
            pictureBoxPhoto.Image = null;
            SetTextBoxesReadOnly(true);
            DisableActionButtons();
        }

        private void SetTextBoxesReadOnly(bool isReadOnly)
        {
            txtName.ReadOnly = isReadOnly;
            txtCourse.ReadOnly = isReadOnly;
            txtYear.ReadOnly = isReadOnly;
            txtSection.ReadOnly = isReadOnly;
        }


        private void EnableActionButtons()
        {
            btnCapturePhoto.Enabled = true;
            btnBrowse.Enabled = true;
            btnStartCamera.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnPassword.Enabled = true;
            btnClear.Enabled = true;
        }

        private void DisableActionButtons()
        {
            btnCapturePhoto.Enabled = false;
            btnBrowse.Enabled = false;
            btnStartCamera.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnPassword.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //tbStudentID.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtYear.Clear();
            txtSection.Clear();
            txtPassword.Clear();
            pictureBoxPhoto.Image = null;

            if (txtPassword.Enabled == true)
            {
                btnBrowse.Enabled = false;
            }
        }
    }
}
