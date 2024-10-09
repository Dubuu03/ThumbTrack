using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public partial class formLogin : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint; 
        private Point dragFormPoint; 

        public formLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

            this.pnHead.MouseDown += new MouseEventHandler(this.pnHead_MouseDown);
            this.pnHead.MouseMove += new MouseEventHandler(this.pnHead_MouseMove);
            this.pnHead.MouseUp += new MouseEventHandler(this.pnHead_MouseUp);
        }

        public static class UserSession
        {
            public static string StudentID { get; set; }
            public static string AccessLevel { get; set; }
            public static string Name { get; set; } 
        }


        private void pnHead_MouseDown(object sender, MouseEventArgs e)
        {
    
            dragging = true;
            dragCursorPoint = Cursor.Position; 
            dragFormPoint = this.Location; 
        }

        private void pnHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
               
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnHead_MouseUp(object sender, MouseEventArgs e)
        {
            
            dragging = false;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentID.Text, out int studentID))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            string password = txtPassword.Text;

            Database db = new Database();
            var (isVerified, accessLevel) = db.VerifyStudentID(studentID, password);

            if (isVerified)
            {
                // Start a session by storing user information
                UserSession.StudentID = studentID.ToString();
                UserSession.AccessLevel = accessLevel;

                this.Hide();
                
                if (accessLevel == "Admin")
                {
                    Main mainForm = new Main();
                    mainForm.Show();
                }
/*                else if (accessLevel == "Checker")
                {
                    formChecker checkerForm = new formChecker();
                    checkerForm.Show();
                }
                else if (accessLevel == "Student")
                {
                    formStudent studentForm = new formStudent();
                    studentForm.Show();
                }*/
            }
            else
            {
                MessageBox.Show("Invalid Student ID or password.");
            }
        }
    }
}
