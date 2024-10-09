using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Main
{
    public partial class formLogged : Form
    {
        private string _studentName;

        public formLogged(string studentName)
        {
            InitializeComponent();
            _studentName = studentName;

            LoadAttendanceLog();
        }

        public void RefreshAttendanceRecord()
        {
            LoadAttendanceLog();
        }

        private int currentStudentID;
        private string defaultImagePath = @"..\..\..\Student Photo\Default.png";

        public void LoadAttendanceLog()
        {
            string query = "SELECT Name, Course, `Year`, Section, StudentID, Date, TimeInAM, TimeOutAM, TimeInPM, TimeOutPM, Remarks " +
                           "FROM tblattendance " +
                           "WHERE Name = @name";

            Database db = new Database();
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@name", _studentName);

            DataTable dt = db.ExecuteQuery(cmd);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No attendance records found for the specified student.");
                return;
            }
            else
            {
                lbName.Text = dt.Rows[0]["Name"].ToString();
                lbCourse.Text = $"{dt.Rows[0]["Course"]} {dt.Rows[0]["Year"]}{dt.Rows[0]["Section"]}";

                currentStudentID = Convert.ToInt32(dt.Rows[0]["StudentID"]);

                LoadStudentPhoto(lbName.Text);
            }

            dgvAttendance.DataSource = dt;

            HideUnnecessaryColumns();

            dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAttendance.ColumnHeadersDefaultCellStyle.Font = new Font(dgvAttendance.Font, FontStyle.Bold);

            dgvAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAttendance.RowsDefaultCellStyle.BackColor = Color.White;

            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HideUnnecessaryColumns()
        {
            string[] columnsToHide = { "AttendanceID", "StudentID", "Year", "Course", "Section", "Name" };

            foreach (var column in columnsToHide)
            {
                if (dgvAttendance.Columns.Contains(column))
                {
                    dgvAttendance.Columns[column].Visible = false;
                }
            }
        }

        private void LoadStudentPhoto(string studentName)
        {
            string sanitizedStudentName = studentName.Replace(" ", "_").Replace(":", "").Replace("/", "_") + ".jpg";
            string photoPath = Path.Combine(@"..\..\..\Student Photo", sanitizedStudentName);

            if (File.Exists(photoPath))
            {
                try
                {
                    pictureBoxPhoto.Image = Image.FromFile(photoPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading photo: " + ex.Message);
                    pictureBoxPhoto.Image = Image.FromFile(defaultImagePath);
                }
            }
            else
            {
                pictureBoxPhoto.Image = Image.FromFile(defaultImagePath);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}
