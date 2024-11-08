namespace Main
{
    partial class formSettings
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPmOutEnd = new System.Windows.Forms.TextBox();
            this.txtPmOutStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPmInEnd = new System.Windows.Forms.TextBox();
            this.txtPmInStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmOutEnd = new System.Windows.Forms.TextBox();
            this.txtAmOutStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmInEnd = new System.Windows.Forms.TextBox();
            this.txtAmInStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbParticipants = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbTOpm = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTIpm = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTOam = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTIam = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbeventName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSubmitEvent = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.clbYearLevel = new System.Windows.Forms.CheckedListBox();
            this.clbCourse = new System.Windows.Forms.CheckedListBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(325, 660);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(222, 63);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.txtPmOutEnd);
            this.groupBox4.Controls.Add(this.txtPmOutStart);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(469, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 184);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time Out PM";
            // 
            // txtPmOutEnd
            // 
            this.txtPmOutEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPmOutEnd.Location = new System.Drawing.Point(58, 138);
            this.txtPmOutEnd.Name = "txtPmOutEnd";
            this.txtPmOutEnd.Size = new System.Drawing.Size(164, 26);
            this.txtPmOutEnd.TabIndex = 6;
            // 
            // txtPmOutStart
            // 
            this.txtPmOutStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPmOutStart.Location = new System.Drawing.Point(58, 64);
            this.txtPmOutStart.Name = "txtPmOutStart";
            this.txtPmOutStart.Size = new System.Drawing.Size(164, 26);
            this.txtPmOutStart.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Time Start";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Time End";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txtPmInEnd);
            this.groupBox2.Controls.Add(this.txtPmInStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(178, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 184);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time In PM";
            // 
            // txtPmInEnd
            // 
            this.txtPmInEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPmInEnd.Location = new System.Drawing.Point(55, 138);
            this.txtPmInEnd.Name = "txtPmInEnd";
            this.txtPmInEnd.Size = new System.Drawing.Size(164, 26);
            this.txtPmInEnd.TabIndex = 6;
            // 
            // txtPmInStart
            // 
            this.txtPmInStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPmInStart.Location = new System.Drawing.Point(55, 60);
            this.txtPmInStart.Name = "txtPmInStart";
            this.txtPmInStart.Size = new System.Drawing.Size(164, 26);
            this.txtPmInStart.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Time Start";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Time End";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.txtAmOutEnd);
            this.groupBox3.Controls.Add(this.txtAmOutStart);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(469, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 184);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Out AM";
            // 
            // txtAmOutEnd
            // 
            this.txtAmOutEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmOutEnd.Location = new System.Drawing.Point(58, 138);
            this.txtAmOutEnd.Name = "txtAmOutEnd";
            this.txtAmOutEnd.Size = new System.Drawing.Size(164, 26);
            this.txtAmOutEnd.TabIndex = 6;
            // 
            // txtAmOutStart
            // 
            this.txtAmOutStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmOutStart.Location = new System.Drawing.Point(58, 64);
            this.txtAmOutStart.Name = "txtAmOutStart";
            this.txtAmOutStart.Size = new System.Drawing.Size(164, 26);
            this.txtAmOutStart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time Start";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time End";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtAmInEnd);
            this.groupBox1.Controls.Add(this.txtAmInStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(178, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 184);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time In AM";
            // 
            // txtAmInEnd
            // 
            this.txtAmInEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmInEnd.Location = new System.Drawing.Point(55, 137);
            this.txtAmInEnd.Name = "txtAmInEnd";
            this.txtAmInEnd.Size = new System.Drawing.Size(164, 26);
            this.txtAmInEnd.TabIndex = 2;
            // 
            // txtAmInStart
            // 
            this.txtAmInStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmInStart.Location = new System.Drawing.Point(55, 63);
            this.txtAmInStart.Name = "txtAmInStart";
            this.txtAmInStart.Size = new System.Drawing.Size(164, 26);
            this.txtAmInStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time Start";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time End";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.lbParticipants);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.lbTOpm);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lbTIpm);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lbTOam);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lbTIam);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lbeventName);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(836, 235);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(412, 488);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Event Details";
            // 
            // lbParticipants
            // 
            this.lbParticipants.AutoSize = true;
            this.lbParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParticipants.Location = new System.Drawing.Point(130, 451);
            this.lbParticipants.Name = "lbParticipants";
            this.lbParticipants.Size = new System.Drawing.Size(159, 20);
            this.lbParticipants.TabIndex = 11;
            this.lbParticipants.Text = "All CICS Students.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 451);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Participants:";
            // 
            // lbTOpm
            // 
            this.lbTOpm.AutoSize = true;
            this.lbTOpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOpm.Location = new System.Drawing.Point(130, 391);
            this.lbTOpm.Name = "lbTOpm";
            this.lbTOpm.Size = new System.Drawing.Size(116, 20);
            this.lbTOpm.TabIndex = 9;
            this.lbTOpm.Text = "Time Out PM:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Time Out PM:";
            // 
            // lbTIpm
            // 
            this.lbTIpm.AutoSize = true;
            this.lbTIpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTIpm.Location = new System.Drawing.Point(128, 317);
            this.lbTIpm.Name = "lbTIpm";
            this.lbTIpm.Size = new System.Drawing.Size(103, 20);
            this.lbTIpm.TabIndex = 7;
            this.lbTIpm.Text = "Time In PM:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Time In PM:";
            // 
            // lbTOam
            // 
            this.lbTOam.AutoSize = true;
            this.lbTOam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOam.Location = new System.Drawing.Point(128, 249);
            this.lbTOam.Name = "lbTOam";
            this.lbTOam.Size = new System.Drawing.Size(117, 20);
            this.lbTOam.TabIndex = 5;
            this.lbTOam.Text = "Time Out AM:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Time Out AM:";
            // 
            // lbTIam
            // 
            this.lbTIam.AutoSize = true;
            this.lbTIam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTIam.Location = new System.Drawing.Point(126, 175);
            this.lbTIam.Name = "lbTIam";
            this.lbTIam.Size = new System.Drawing.Size(104, 20);
            this.lbTIam.TabIndex = 3;
            this.lbTIam.Text = "Time In AM:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Time In AM:";
            // 
            // lbeventName
            // 
            this.lbeventName.AutoSize = true;
            this.lbeventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeventName.Location = new System.Drawing.Point(7, 105);
            this.lbeventName.Name = "lbeventName";
            this.lbeventName.Size = new System.Drawing.Size(116, 20);
            this.lbeventName.TabIndex = 1;
            this.lbeventName.Text = "Event Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Today\'s Event:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.btnSubmitEvent);
            this.groupBox6.Controls.Add(this.txtEventName);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(178, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(551, 164);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Event Name:";
            // 
            // btnSubmitEvent
            // 
            this.btnSubmitEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmitEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEvent.Location = new System.Drawing.Point(207, 107);
            this.btnSubmitEvent.Name = "btnSubmitEvent";
            this.btnSubmitEvent.Size = new System.Drawing.Size(116, 38);
            this.btnSubmitEvent.TabIndex = 25;
            this.btnSubmitEvent.Text = "SUBMIT";
            this.btnSubmitEvent.UseVisualStyleBackColor = true;
            this.btnSubmitEvent.Click += new System.EventHandler(this.btnSubmitEvent_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(55, 60);
            this.txtEventName.MaxLength = 255;
            this.txtEventName.Multiline = true;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(458, 31);
            this.txtEventName.TabIndex = 19;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.clbYearLevel);
            this.groupBox7.Controls.Add(this.clbCourse);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(836, 53);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(412, 164);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Participants";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(200, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 18);
            this.label19.TabIndex = 13;
            this.label19.Text = "Year Level:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 18);
            this.label18.TabIndex = 12;
            this.label18.Text = "Course:";
            // 
            // clbYearLevel
            // 
            this.clbYearLevel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clbYearLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbYearLevel.FormattingEnabled = true;
            this.clbYearLevel.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.clbYearLevel.Location = new System.Drawing.Point(239, 60);
            this.clbYearLevel.Name = "clbYearLevel";
            this.clbYearLevel.Size = new System.Drawing.Size(114, 68);
            this.clbYearLevel.TabIndex = 1;
            // 
            // clbCourse
            // 
            this.clbCourse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clbCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCourse.FormattingEnabled = true;
            this.clbCourse.Items.AddRange(new object[] {
            "BSCS",
            "BSIT",
            "BLIS",
            "BSIS",
            "BMMA"});
            this.clbCourse.Location = new System.Drawing.Point(50, 60);
            this.clbCourse.Name = "clbCourse";
            this.clbCourse.Size = new System.Drawing.Size(108, 85);
            this.clbCourse.TabIndex = 0;
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1406, 819);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSettings";
            this.Text = "formSettings";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPmOutEnd;
        private System.Windows.Forms.TextBox txtPmOutStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPmInEnd;
        private System.Windows.Forms.TextBox txtPmInStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAmOutEnd;
        private System.Windows.Forms.TextBox txtAmOutStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmInEnd;
        private System.Windows.Forms.TextBox txtAmInStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbeventName;
        private System.Windows.Forms.Label lbTOam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTIam;
        private System.Windows.Forms.Label lbTOpm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTIpm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbParticipants;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSubmitEvent;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckedListBox clbCourse;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckedListBox clbYearLevel;
    }
}