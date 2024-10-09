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
        public formToday()
        {
            InitializeComponent();
            LoadAttendanceToday();
            this.txtSearchAttendance.TextChanged += new EventHandler(this.txtSearchAttendance_TextChanged);
            timerTime.Start();

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            string amInStart = txtAmInStart.Text.Trim();
            string amOutStart = txtAmOutStart.Text.Trim();
            string amInEnd = txtAmInEnd.Text.Trim();
            string amOutEnd = txtAmOutEnd.Text.Trim();

            string pmInStart = txtPmInStart.Text.Trim();
            string pmOutStart = txtPmOutStart.Text.Trim();
            string pmInEnd = txtPmInEnd.Text.Trim();
            string pmOutEnd = txtPmOutEnd.Text.Trim();


            try
            {
                if (!string.IsNullOrEmpty(amInStart) && !string.IsNullOrEmpty(amInEnd))
                {
                    amInStart = ConvertTextToTime(amInStart);
                    amOutStart = ConvertTextToTime(amOutStart);
                    db.UpdateTime("AMin", amInStart, amInEnd);
                }

                if (!string.IsNullOrEmpty(amOutStart) && !string.IsNullOrEmpty(amOutEnd))
                {
                    amInEnd = ConvertTextToTime(amInEnd);
                    amOutEnd = ConvertTextToTime(amOutEnd);
                    db.UpdateTime("AMout", amOutStart, amOutEnd);
                }

                if (!string.IsNullOrEmpty(pmInStart) && !string.IsNullOrEmpty(pmInEnd))
                {
                    pmInStart = ConvertTextToTime(pmInStart);
                    pmOutStart = ConvertTextToTime(pmOutStart);
                    db.UpdateTime("PMin", pmInStart, pmInEnd);
                }

                if (!string.IsNullOrEmpty(pmOutStart) && !string.IsNullOrEmpty(pmOutEnd))
                {
                    pmInEnd = ConvertTextToTime(pmInEnd);
                    pmOutEnd = ConvertTextToTime(pmOutEnd);
                    db.UpdateTime("PMout", pmOutStart, pmOutEnd);
                }

                MessageBox.Show("Time updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            ClearTextboxes();
        }

        public void ClearTextboxes()
        {
            txtAmInStart.Clear();
            txtAmOutStart.Clear(); 
            txtAmInEnd.Clear();    
            txtAmOutEnd.Clear();   
            txtPmInStart.Clear();  
            txtPmOutStart.Clear(); 
            txtPmInEnd.Clear(); 
            txtPmOutEnd.Clear();    
        }


        private string ConvertTextToTime(string input)
        {
            var parts = input.Split(':');

            if (parts.Length > 0 && int.TryParse(parts[0], out int hour) && hour >= 0 && hour < 24)
            {
                int minute = 0, second = 0;

                if (parts.Length > 1 && int.TryParse(parts[1], out minute) && minute >= 0 && minute < 60)
                {
                    if (parts.Length > 2 && int.TryParse(parts[2], out second) && second >= 0 && second < 60)
                    {
                        return $"{hour:D2}:{minute:D2}:{second:D2}";
                    }
                    return $"{hour:D2}:{minute:D2}:00";
                }

                return $"{hour:D2}:00:00";
            }

            return "00:00:00";
        }



    }
}
