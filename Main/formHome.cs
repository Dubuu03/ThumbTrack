using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Main
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
            InitializePanelCorners();
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            UpdateStudentCount();
            UpdateAttendanceCounts();
        }

        private void InitializePanelCorners()
        {
            RoundedPanel[] panels = { roundedPanel9, roundedPanel11, roundedPanel13, roundedPanel15, roundedPanel17 };
            foreach (var panel in panels)
            {
                if (panel is RoundedPanel roundedPanel)
                {
                    roundedPanel.BorderRadius = 10; // Set radius for each panel
                }
            }
        }

        public void UpdateStudentCount()
        {
            int studentCount = GetStudentCount();
            lbStudent.Text = studentCount.ToString();
        }

        private int GetStudentCount()
        {
            Database db = new Database();
            return db.GetStudentCount();
        }

        public void UpdateAttendanceCounts()
        {
            UpdateTimeInOutCounts();
            UpdateCourseAttendanceCounts();
        }

        private void UpdateTimeInOutCounts()
        {
            Database db = new Database();
            lbTiAM.Text = db.GetTimeInAMCount().ToString();
            lbToAM.Text = db.GetTimeOutAMCount().ToString();
            lbTiPM.Text = db.GetTimeInPMCount().ToString();
            lbToPM.Text = db.GetTimeOutPMCount().ToString();
        }

        private void UpdateCourseAttendanceCounts()
        {
            int csCount = GetAttendanceCountByCourse("CS", "BSCS");
            int isCount = GetAttendanceCountByCourse("IS", "BSIS");
            int itCount = GetAttendanceCountByCourse("IT", "BSIT");
            int mmaCount = GetAttendanceCountByCourse("MMA", "BMMA");
            int lisCount = GetAttendanceCountByCourse("LIS", "BLIS");

            lbCS.Text = csCount.ToString();
            lbIS.Text = isCount.ToString();
            lbIT.Text = itCount.ToString();
            lbMMA.Text = mmaCount.ToString();
            lbLIS.Text = lisCount.ToString();
        }

        public int GetAttendanceCountByCourse(params string[] courseCodes)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");
            string query = BuildAttendanceQuery(courseCodes, today);

            Database db = new Database();
            return ExecuteAttendanceQuery(db, query);
        }

        private string BuildAttendanceQuery(string[] courseCodes, string date)
        {
            string courseCondition = string.Join(" OR ", courseCodes.Select(code => $"Course = '{code}'"));

            return $"SELECT COUNT(*) FROM tblAttendance WHERE ({courseCondition}) AND Date = '{date}'";
        }

        private int ExecuteAttendanceQuery(Database db, string query)
        {
            int count = 0;

            using (var connection = db.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return count;
        }
    }
}
