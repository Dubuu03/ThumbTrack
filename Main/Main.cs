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
    public partial class Main : Form
    {
        formHome home;
        formRegister register;
        formManage manage;
        formRecords records;
        formToday today;
        formAttendance log;
        formSettings settings;

        public Main()
        {
            InitializeComponent();
            home = new formHome();
            home.MdiParent = this;
            home.Dock = DockStyle.Fill;
            home.Show();
            mdiProp();

            btnHome.BackColor = ColorTranslator.FromHtml("#555A55");
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void ResetButtonColors()
        {
            btnHome.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            btnRegister.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            btnManage.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            btnRecord.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            btnToday.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            btnLog.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            btnSettings.BackColor = ColorTranslator.FromHtml("#2A2A2A");
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 75)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 300)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnHome.BackColor = ColorTranslator.FromHtml("#555A55");

            if (home == null)
            {
                home = new formHome();
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Show();

                home.UpdateAttendanceCounts();
                home.UpdateStudentCount();
            }
            else
            {
                home.Activate();
                home.UpdateAttendanceCounts();
                home.UpdateStudentCount();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnRegister.BackColor = ColorTranslator.FromHtml("#555A55");

            if (register == null)
            {
                register = new formRegister();
                register.FormClosed += Register_FormClosed;
                register.MdiParent = this;
                register.Dock = DockStyle.Fill;
                register.Show();
            }
            else
            {
                register.Activate();
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            register = null;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnManage.BackColor = ColorTranslator.FromHtml("#555A55");

            if (manage == null)
            {
                manage = new formManage();
                manage.FormClosed += Manage_FormClosed;
                manage.MdiParent = this;
                manage.Dock = DockStyle.Fill;
                manage.Show();
            }
            else
            {
                manage.Activate();
            }
        }

        private void Manage_FormClosed(object sender, FormClosedEventArgs e)
        {
            manage = null;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnRecord.BackColor = ColorTranslator.FromHtml("#555A55");

            if (records == null)
            {
                records = new formRecords();
                records.FormClosed += Record_FormClosed;
                records.MdiParent = this;
                records.Dock = DockStyle.Fill;
                records.Show();

                records.RefreshAttendanceRecord();
            }
            else
            {
                records.RefreshAttendanceRecord();
                records.Activate();
            }
        }

        private void Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            records = null;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnToday.BackColor = ColorTranslator.FromHtml("#555A55");

            if (today == null)
            {
                today = new formToday();
                today.FormClosed += Today_FormClosed;
                today.MdiParent = this;
                today.Dock = DockStyle.Fill;
                today.Show();

                today.RefreshAttendance();
            }
            else
            {
                today.RefreshAttendance();
                today.Activate();
            }
        }

        private void Today_FormClosed(object sender, FormClosedEventArgs e)
        {
            today = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                formLogin loginForm = new formLogin();
                loginForm.Show();

                this.Close();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnLog.BackColor = ColorTranslator.FromHtml("#555A55");

            if (log == null)
            {
                log = new formAttendance();
                log.FormClosed += Log_FormClosed;
                log.MdiParent = this;
                log.Dock = DockStyle.Fill;
                log.Show();
            }
            else
            {
                log.Activate();
            }
        }

        private void Log_FormClosed(object sender, FormClosedEventArgs e)
        {
            log = null;
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSettings.BackColor = ColorTranslator.FromHtml("#555A55");

            if (settings == null)
            {
                settings = new formSettings();
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }
    }
}
