namespace Main
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnToday = new System.Windows.Forms.Panel();
            this.pnRegister = new System.Windows.Forms.Panel();
            this.pnManage = new System.Windows.Forms.Panel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.pnRecords = new System.Windows.Forms.Panel();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnSettings = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnToday.SuspendLayout();
            this.pnRegister.SuspendLayout();
            this.pnManage.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.pnRecords.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1511, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ThumbTrack: Attendance Monitoring System";
            // 
            // pnToday
            // 
            this.pnToday.Controls.Add(this.btnToday);
            this.pnToday.Location = new System.Drawing.Point(3, 403);
            this.pnToday.Name = "pnToday";
            this.pnToday.Size = new System.Drawing.Size(300, 94);
            this.pnToday.TabIndex = 3;
            // 
            // pnRegister
            // 
            this.pnRegister.Controls.Add(this.btnRegister);
            this.pnRegister.Location = new System.Drawing.Point(3, 103);
            this.pnRegister.Name = "pnRegister";
            this.pnRegister.Size = new System.Drawing.Size(300, 94);
            this.pnRegister.TabIndex = 4;
            // 
            // pnManage
            // 
            this.pnManage.Controls.Add(this.btnManage);
            this.pnManage.Location = new System.Drawing.Point(3, 203);
            this.pnManage.Name = "pnManage";
            this.pnManage.Size = new System.Drawing.Size(300, 94);
            this.pnManage.TabIndex = 5;
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.btnHome);
            this.pnHome.Location = new System.Drawing.Point(3, 3);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(300, 94);
            this.pnHome.TabIndex = 6;
            // 
            // pnRecords
            // 
            this.pnRecords.Controls.Add(this.btnRecord);
            this.pnRecords.Location = new System.Drawing.Point(3, 303);
            this.pnRecords.Name = "pnRecords";
            this.pnRecords.Size = new System.Drawing.Size(300, 94);
            this.pnRecords.TabIndex = 6;
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(3, 703);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(300, 94);
            this.pnLogout.TabIndex = 4;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.sidebar.Controls.Add(this.pnHome);
            this.sidebar.Controls.Add(this.pnRegister);
            this.sidebar.Controls.Add(this.pnManage);
            this.sidebar.Controls.Add(this.pnRecords);
            this.sidebar.Controls.Add(this.pnToday);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 55);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(300, 824);
            this.sidebar.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Location = new System.Drawing.Point(3, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 94);
            this.panel2.TabIndex = 4;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.btnSettings);
            this.pnSettings.Location = new System.Drawing.Point(3, 603);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(300, 94);
            this.pnSettings.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(300, 94);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "           Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(0, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRegister.Size = new System.Drawing.Size(300, 94);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "           Register Student";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(0, 0);
            this.btnManage.Name = "btnManage";
            this.btnManage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnManage.Size = new System.Drawing.Size(300, 94);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "           Manage Students";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(0, 0);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRecord.Size = new System.Drawing.Size(300, 94);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "           Records";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnToday.Image = ((System.Drawing.Image)(resources.GetObject("btnToday.Image")));
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(0, 0);
            this.btnToday.Name = "btnToday";
            this.btnToday.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnToday.Size = new System.Drawing.Size(300, 94);
            this.btnToday.TabIndex = 2;
            this.btnToday.Text = "           Today\'s Attendance";
            this.btnToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(0, 0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLog.Size = new System.Drawing.Size(300, 94);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "           Log Attendance";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(300, 94);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "           Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(300, 94);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "           Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 10);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(42, 37);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 2;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1511, 879);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Attendance Monitoring System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnToday.ResumeLayout(false);
            this.pnRegister.ResumeLayout(false);
            this.pnManage.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.pnRecords.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnToday;
        private System.Windows.Forms.Panel pnRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnManage;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Panel pnRecords;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button btnSettings;
    }
}

