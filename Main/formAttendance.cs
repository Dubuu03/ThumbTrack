using System;
using System.Data;
using System.Windows.Forms;

namespace Main
{
    public partial class formAttendance : Form
    {
        public formAttendance()
        {
            InitializeComponent();
        }

        private bool isNameFormOpen = false;

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            OpenNameFormForAttendance(true);
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            OpenNameFormForAttendance(false);
        }

        private void OpenNameFormForAttendance(bool isTimeIn)
        {
            using (Name nameForm = new Name())
            {
                if (nameForm.ShowDialog() == DialogResult.OK)
                {
                    string studentName = nameForm.StudentName;
                    string query = $"SELECT StudentID, Course, `Year`, Section FROM tblstudents WHERE Name = '{studentName}'";
                    Database db = new Database();
                    DataTable dt = db.ExecuteQuery(query);

                    if (dt.Rows.Count > 0)
                    {
                        string studentId = dt.Rows[0]["StudentID"].ToString();
                        string course = dt.Rows[0]["Course"].ToString();
                        int year = Convert.ToInt32(dt.Rows[0]["Year"]);
                        string section = dt.Rows[0]["Section"].ToString();
                        DateTime currentTime = DateTime.Now;
                        string dateToday = currentTime.ToString("yyyy-MM-dd");

                        DataTable timeInRecords = db.GetAttendanceRecords(studentId, dateToday);

                        if (isTimeIn)
                        {
                            HandleTimeIn(currentTime, studentId, studentName, dateToday, timeInRecords, course, year, section);
                        }
                        else
                        {
                            HandleTimeOut(currentTime, studentId, studentName, dateToday, timeInRecords, course, year, section);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student not found!");
                    }
                }
            }
        }

        private void HandleTimeIn(DateTime currentTime, string studentId, string studentName, string dateToday, DataTable timeInRecords, string course, int year, string section)
        {
            string timeField = "";
            string remarks = "";

            (TimeSpan amInStart, TimeSpan amInEnd) = GetAttendancePeriods("AMin", new Database());
            (TimeSpan pmInStart, TimeSpan pmInEnd) = GetAttendancePeriods("PMin", new Database());

            // Check AM Time In
            if (currentTime.TimeOfDay >= amInStart && currentTime.TimeOfDay <= amInEnd)
            {
                timeField = "TimeInAM";
                remarks = "On Time";
            }
            else if (currentTime.TimeOfDay > amInEnd && currentTime.TimeOfDay < pmInStart)
            {
                // Late for AM
                timeField = "TimeInAM";
                remarks = "Late Time In AM";
            }
            else if (currentTime.TimeOfDay >= pmInStart && currentTime.TimeOfDay <= pmInEnd)
            {
                // PM Time In
                timeField = "TimeInPM";
                remarks = "On Time";
            }
            else if (currentTime.TimeOfDay > pmInEnd)
            {
                // Late for PM
                timeField = "TimeInPM";
                remarks = "Late Time In PM";
            }
            else
            {
                MessageBox.Show("Unable to time in! Time not within allowed ranges.");
                return;
            }

            // Time-In Checks
            if (timeInRecords.Rows.Count > 0)
            {
                bool hasTimedInAM = !string.IsNullOrEmpty(timeInRecords.Rows[0]["TimeInAM"].ToString());
                bool hasTimedInPM = !string.IsNullOrEmpty(timeInRecords.Rows[0]["TimeInPM"].ToString());

                if (timeField == "TimeInAM" && hasTimedInAM)
                {
                    MessageBox.Show("You have already timed in for AM.");
                    return;
                }
                if (timeField == "TimeInPM" && hasTimedInPM)
                {
                    MessageBox.Show("You have already timed in for PM.");
                    return;
                }
            }

            SubmitAttendance(studentId, studentName, dateToday, timeField, currentTime, course, year, section, remarks);
        }

        private void HandleTimeOut(DateTime currentTime, string studentId, string studentName, string dateToday, DataTable timeInRecords, string course, int year, string section)
        {
            if (timeInRecords.Rows.Count == 0 ||
                (string.IsNullOrEmpty(timeInRecords.Rows[0]["TimeInAM"].ToString()) && string.IsNullOrEmpty(timeInRecords.Rows[0]["TimeInPM"].ToString())))
            {
                MessageBox.Show("You must time in before timing out!");
                return;
            }

            (TimeSpan amOutStart, TimeSpan amOutEnd) = GetAttendancePeriods("AMout", new Database());
            (TimeSpan pmOutStart, TimeSpan pmOutEnd) = GetAttendancePeriods("PMout", new Database());

            if (currentTime.TimeOfDay <= amOutEnd)
            {
                if (!string.IsNullOrEmpty(timeInRecords.Rows[0]["TimeOutAM"].ToString()))
                {
                    MessageBox.Show("You have already timed out for AM.");
                    return;
                }

                // Check for early AM Time Out
                if (currentTime.TimeOfDay < amOutStart)
                {
                    MessageBox.Show("You cannot time out early for AM!");
                    return;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(timeInRecords.Rows[0]["TimeOutPM"].ToString()))
                {
                    MessageBox.Show("You have already timed out for PM.");
                    return;
                }

                // Check for early PM Time Out
                if (currentTime.TimeOfDay < pmOutStart)
                {
                    MessageBox.Show("You cannot time out early for PM!");
                    return;
                }
            }

            string timeField;
            string remarks = "";

            // Time-Out Checks
            if (currentTime.TimeOfDay >= amOutStart && currentTime.TimeOfDay <= amOutEnd)
            {
                timeField = "TimeOutAM";
                remarks = "On Time";
            }
            else if (currentTime.TimeOfDay >= pmOutStart && currentTime.TimeOfDay <= new TimeSpan(24, 0, 0))
            {
                timeField = "TimeOutPM";
                remarks = "On Time";
            }
            else
            {
                MessageBox.Show("Unable to time out!");
                return;
            }

            SubmitAttendance(studentId, studentName, dateToday, timeField, currentTime, course, year, section, remarks);
        }

        private (TimeSpan StartTime, TimeSpan EndTime) GetAttendancePeriods(string period, Database db)
        {
            string query = $"SELECT StartTime, EndTime FROM tblTime WHERE Period = '{period}'";
            DataTable timeData = db.ExecuteQuery(query);
            TimeSpan startTime = TimeSpan.Zero;
            TimeSpan endTime = TimeSpan.Zero;

            if (timeData.Rows.Count > 0)
            {
                startTime = TimeSpan.Parse(timeData.Rows[0]["StartTime"].ToString());
                endTime = TimeSpan.Parse(timeData.Rows[0]["EndTime"].ToString());
            }

            return (startTime, endTime);
        }

        private void SubmitAttendance(string studentId, string studentName, string dateToday, string timeField, DateTime currentTime, string course, int year, string section, string remarks)
        {
            Database db = new Database();

            DataTable dt = db.GetAttendanceRecords(studentId, dateToday);

            if (dt.Rows.Count > 0)
            {
                db.UpdateAttendance(studentId, dateToday, timeField, currentTime);

                if (!string.IsNullOrEmpty(remarks))
                {
                    db.UpdateRemarks(studentId, dateToday, remarks);
                }
            }
            else
            {
                db.InsertAttendance(studentId, studentName, dateToday, timeField, currentTime, course, year, section, remarks);
            }

            MessageBox.Show("Attendance submitted successfully!");

            ShowLoggedForm(studentName);
        }

        private void ShowLoggedForm(string studentName)
        {
            if (!isNameFormOpen)
            {
                isNameFormOpen = true;

                formLogged loggedForm = new formLogged(studentName);
                loggedForm.RefreshAttendanceRecord();
                loggedForm.MdiParent = this.MdiParent;
                loggedForm.Dock = DockStyle.Fill;
                loggedForm.Show();

                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    loggedForm.Close();
                    this.Activate();
                    isNameFormOpen = false;
                };
                timer.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
