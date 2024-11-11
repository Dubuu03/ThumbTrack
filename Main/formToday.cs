using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class formToday : Form
    {
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();
        public formToday()
        {
            InitializeComponent();
            LoadAttendanceToday();
            this.txtSearchAttendance.TextChanged += new EventHandler(this.txtSearchAttendance_TextChanged);
            timerTime.Start();


            placeholders.Add(txtSearchAttendance, "Enter Student ID");

            foreach (var textBox in placeholders.Keys)
            {
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray;

                textBox.Enter += RemovePlaceholder;
                textBox.Leave += SetPlaceholder;
                textBox.TextChanged += ChangeTextColor;
            }
        }

        private void formToday_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadAttendanceToday();
        }
        public void RefreshAttendance()
        {
            LoadAttendanceToday();
        }

        private void LoadAttendanceToday(string searchTerm = "")
        {
            string query;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                query = "SELECT StudentID, Name, Course, `Year`, Section, Date, TimeInAM, TimeOutAM, TimeInPM, TimeOutPM, Remarks FROM tblattendance WHERE Date = CURDATE()";
            }
            else
            {
                query = "SELECT StudentID, Name, Course, `Year`, Section, Date, TimeInAM, TimeOutAM, TimeInPM, TimeOutPM, Remarks " +
                  "FROM tblattendance " +
                  "WHERE (Name LIKE '%" + searchTerm + "%' OR StudentID LIKE '%" + searchTerm + "%') " +
                  "AND Date = CURDATE()";

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
        private void txtSearchAttendance_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchAttendance.Text.Trim();
            LoadAttendanceToday(searchTerm);
        }

        private void UpdateTime()
        {
            lbDate.Text = "Date: " + DateTime.Now.ToString("MMMM dd, yyyy"); 
            lbTime.Text = "Time: " + DateTime.Now.ToString("hh:mm:ss tt"); 

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void lbDate_Click(object sender, EventArgs e)
        {

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
                textBox.ForeColor = SystemColors.WindowText; // Regular text color
            }
        }

        private void ChangeTextColor(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (placeholders[textBox] == "Enter Student ID")
                {
                    textBox.ForeColor = Color.White;
                }
            }
        }

    }
}
