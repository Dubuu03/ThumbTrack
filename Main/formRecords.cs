using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public partial class formRecords : Form
    {
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();

        public formRecords()
        {
            InitializeComponent();
            this.txtSearchAttendance.TextChanged += new EventHandler(this.txtSearchAttendance_TextChanged);
            this.txtSearchAbsentees.TextChanged += new EventHandler(this.txtSearchAbsentees_TextChanged);

            placeholders.Add(txtSearchAttendance, "Enter Student ID");
            placeholders.Add(txtSearchAbsentees, "Enter Student ID");

            foreach (var textBox in placeholders.Keys)
            {
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray;

                textBox.Enter += RemovePlaceholder;
                textBox.Leave += SetPlaceholder;
            }
        }

        private void formRecords_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadAttendanceRecord();
            LoadAbsentees();
        }

        public void RefreshAttendanceRecord()
        {
            LoadAttendanceRecord();
            LoadAbsentees();
        }

        private void LoadAttendanceRecord(string searchTerm = "")
        {
            string query;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                query = "SELECT StudentID, Name, Course, `Year`, Section, Date, TimeInAM, TimeOutAM, TimeInPM, TimeOutPM, Remarks FROM tblattendance";
            }
            else
            {
                query = "SELECT StudentID, Name, Course, `Year`, Section, Date, TimeInAM, TimeOutAM, TimeInPM, TimeOutPM, Remarks FROM tblattendance" +
                    " WHERE Name LIKE '%" + searchTerm + "%' OR StudentID LIKE '%" + searchTerm + "%'";
            }

            Database db = new Database();
            DataTable dt = db.ExecuteQuery(query);
            dgvAttendance.DataSource = dt;

            if (dgvAttendance.Columns.Contains("AttendanceID"))
            {
                dgvAttendance.Columns["AttendanceID"].Visible = false;
            }

            // Set header 
            dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAttendance.ColumnHeadersDefaultCellStyle.Font = new Font(dgvAttendance.Font, FontStyle.Bold);

            // alternating row colors
            dgvAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAttendance.RowsDefaultCellStyle.BackColor = Color.White;

            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAbsentees(string searchTerm = "")
        {
            string query = "SELECT s.StudentID, s.Name, s.Course, s.`Year`, s.Section FROM tblstudents s LEFT JOIN tblattendance a ON s.StudentID = a.StudentID AND a.Date = CURDATE()" +
                " WHERE a.StudentID IS NULL";

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query += " AND (s.Name LIKE '%" + searchTerm + "%' OR s.StudentID LIKE '%" + searchTerm + "%')";
            }

            Database db = new Database();
            DataTable dt = db.ExecuteQuery(query);
            dgvAbsent.DataSource = dt;

            // Set header 
            dgvAbsent.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvAbsent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAbsent.ColumnHeadersDefaultCellStyle.Font = new Font(dgvAttendance.Font, FontStyle.Bold);

            // alternating row colors
            dgvAbsent.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAbsent.RowsDefaultCellStyle.BackColor = Color.White;

            dgvAbsent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtSearchAttendance_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchAttendance.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm) || searchTerm == placeholders[txtSearchAttendance])
            {
                LoadAttendanceRecord(); 
            }
            else
            {
                LoadAttendanceRecord(searchTerm); 
            }
        }

        private void txtSearchAbsentees_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchAbsentees.Text.Trim();


            if (string.IsNullOrWhiteSpace(searchTerm) || searchTerm == placeholders[txtSearchAbsentees])
            {
                LoadAbsentees(); 
            }
            else
            {
                LoadAbsentees(searchTerm); 
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray; // Keep placeholder text gray
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == placeholders[textBox])
            {
                textBox.Text = "";
                textBox.ForeColor = Color.White; // Regular text color
            }
        }

        private void btnExportAttendace_Click(object sender, EventArgs e)
        {

        }
        private void btnCourse_Click(object sender, EventArgs e)
        {
        }

        private void btnExportAbsent_Click(object sender, EventArgs e)
        {

        }
    }

}

