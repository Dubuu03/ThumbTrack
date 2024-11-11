namespace Main
{
    partial class formRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new RoundedPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCapturePhoto = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.TextBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.fImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(166)))), ((int)(((byte)(55)))));
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(166)))), ((int)(((byte)(55)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(572, 718);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(723, 55);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatAppearance.BorderSize = 5;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnClear.Location = new System.Drawing.Point(567, 661);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(349, 49);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.FlatAppearance.BorderSize = 5;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(168)))), ((int)(((byte)(33)))));
            this.btnStart.Location = new System.Drawing.Point(929, 661);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(365, 49);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "START SCAN";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.roundedPanel2);
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Location = new System.Drawing.Point(-13, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 870);
            this.panel1.TabIndex = 21;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.roundedPanel2.BorderRadius = 30;
            this.roundedPanel2.Controls.Add(this.label11);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Controls.Add(this.btnCapturePhoto);
            this.roundedPanel2.Controls.Add(this.pictureBoxPhoto);
            this.roundedPanel2.Controls.Add(this.btnBrowse);
            this.roundedPanel2.Controls.Add(this.btnStartCamera);
            this.roundedPanel2.Controls.Add(this.txtPassword);
            this.roundedPanel2.Controls.Add(this.txtSection);
            this.roundedPanel2.Controls.Add(this.txtStudentID);
            this.roundedPanel2.Controls.Add(this.txtYear);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Controls.Add(this.label6);
            this.roundedPanel2.Controls.Add(this.txtCourse);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Controls.Add(this.label3);
            this.roundedPanel2.Controls.Add(this.label5);
            this.roundedPanel2.Controls.Add(this.txtName);
            this.roundedPanel2.Controls.Add(this.label7);
            this.roundedPanel2.Location = new System.Drawing.Point(539, 25);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(800, 629);
            this.roundedPanel2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Qualy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(37, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(364, 43);
            this.label11.TabIndex = 34;
            this.label11.Text = "Basic Information";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(392, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Photo:";
            // 
            // btnCapturePhoto
            // 
            this.btnCapturePhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapturePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnCapturePhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnCapturePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturePhoto.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturePhoto.ForeColor = System.Drawing.Color.White;
            this.btnCapturePhoto.Location = new System.Drawing.Point(583, 508);
            this.btnCapturePhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapturePhoto.Name = "btnCapturePhoto";
            this.btnCapturePhoto.Size = new System.Drawing.Size(173, 49);
            this.btnCapturePhoto.TabIndex = 38;
            this.btnCapturePhoto.Text = "Capture";
            this.btnCapturePhoto.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(397, 148);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(358, 353);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 34;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(397, 565);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(359, 49);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "Browse Photo";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnStartCamera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnStartCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCamera.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCamera.ForeColor = System.Drawing.Color.White;
            this.btnStartCamera.Location = new System.Drawing.Point(397, 508);
            this.btnStartCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(173, 49);
            this.btnStartCamera.TabIndex = 37;
            this.btnStartCamera.Text = "Camera";
            this.btnStartCamera.UseVisualStyleBackColor = false;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(33, 322);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 6;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(302, 36);
            this.txtPassword.TabIndex = 35;
            // 
            // txtSection
            // 
            this.txtSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Location = new System.Drawing.Point(33, 576);
            this.txtSection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSection.MaxLength = 10;
            this.txtSection.Multiline = true;
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(302, 36);
            this.txtSection.TabIndex = 32;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(33, 155);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentID.MaxLength = 7;
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(302, 36);
            this.txtStudentID.TabIndex = 28;
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(33, 491);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYear.MaxLength = 10;
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(302, 36);
            this.txtYear.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Password:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 540);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Section:";
            // 
            // txtCourse
            // 
            this.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(33, 404);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourse.MaxLength = 4;
            this.txtCourse.Multiline = true;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(302, 36);
            this.txtCourse.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 453);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Year:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(33, 239);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 36);
            this.txtName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Course:";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.Controls.Add(this.label10);
            this.roundedPanel1.Controls.Add(this.label9);
            this.roundedPanel1.Controls.Add(this.label8);
            this.roundedPanel1.Controls.Add(this.statusText);
            this.roundedPanel1.Controls.Add(this.Prompt);
            this.roundedPanel1.Controls.Add(this.statusLabel);
            this.roundedPanel1.Controls.Add(this.fImage);
            this.roundedPanel1.Location = new System.Drawing.Point(49, 28);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(453, 724);
            this.roundedPanel1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Qualy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(40, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 43);
            this.label10.TabIndex = 33;
            this.label10.Text = "Total Login";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(40, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "place on scanner";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Prompt:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // statusText
            // 
            this.statusText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.statusText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.Location = new System.Drawing.Point(36, 496);
            this.statusText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusText.MaxLength = 4;
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(382, 155);
            this.statusText.TabIndex = 29;
            // 
            // Prompt
            // 
            this.Prompt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Prompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.Prompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.Location = new System.Drawing.Point(36, 463);
            this.Prompt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prompt.MaxLength = 4;
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(382, 24);
            this.Prompt.TabIndex = 28;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(31, 674);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(85, 23);
            this.statusLabel.TabIndex = 27;
            this.statusLabel.Text = "Ready...";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // fImage
            // 
            this.fImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.fImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fImage.Location = new System.Drawing.Point(36, 154);
            this.fImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fImage.Name = "fImage";
            this.fImage.Size = new System.Drawing.Size(370, 258);
            this.fImage.TabIndex = 26;
            this.fImage.TabStop = false;
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formRegister";
            this.Text = "formRegister";
            this.Load += new System.EventHandler(this.formRegister_Load);
            this.panel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox fImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCapturePhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
    }
}