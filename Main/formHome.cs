using System;
using System.Windows.Forms;

namespace Main
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            UpdateStudentCount();  
            UpdateAttendanceCounts(); 
        }


        public void UpdateStudentCount()
        {
            Database db = new Database();
            int count = db.GetStudentCount();
            lbStudent.Text = count.ToString();  
        }

        public void UpdateAttendanceCounts()
        {
            Database db = new Database();
            int timeInAMCount = db.GetTimeInAMCount();
            int timeOutAMCount = db.GetTimeOutAMCount();
            int timeInPMCount = db.GetTimeInPMCount();
            int timeOutPMCount = db.GetTimeOutPMCount();

            lbTiAM.Text = timeInAMCount.ToString();
            lbToAM.Text = timeOutAMCount.ToString();
            lbTiPM.Text = timeInPMCount.ToString();
            lbToPM.Text = timeOutPMCount.ToString();
        }
    }
}
