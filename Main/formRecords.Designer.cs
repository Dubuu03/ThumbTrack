namespace Main
{
    partial class formRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRecords));
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportAttendace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchAttendance = new System.Windows.Forms.TextBox();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStartDate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExportAbsent = new System.Windows.Forms.Button();
            this.txtSearchAbsentees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAbsent = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsent)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(0, 71);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.Size = new System.Drawing.Size(1329, 240);
            this.dgvAttendance.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvAttendance);
            this.panel1.Location = new System.Drawing.Point(24, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 311);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExportAttendace);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSearchAttendance);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 71);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnExportAttendace
            // 
            this.btnExportAttendace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportAttendace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(166)))), ((int)(((byte)(55)))));
            this.btnExportAttendace.FlatAppearance.BorderSize = 0;
            this.btnExportAttendace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAttendace.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAttendace.ForeColor = System.Drawing.Color.White;
            this.btnExportAttendace.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportAttendace.Location = new System.Drawing.Point(1119, 16);
            this.btnExportAttendace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportAttendace.Name = "btnExportAttendace";
            this.btnExportAttendace.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnExportAttendace.Size = new System.Drawing.Size(155, 36);
            this.btnExportAttendace.TabIndex = 9;
            this.btnExportAttendace.Text = "Search";
            this.btnExportAttendace.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Qualy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Attendance Data";
            // 
            // txtSearchAttendance
            // 
            this.txtSearchAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtSearchAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchAttendance.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAttendance.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchAttendance.Location = new System.Drawing.Point(704, 21);
            this.txtSearchAttendance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchAttendance.MaxLength = 255;
            this.txtSearchAttendance.Multiline = true;
            this.txtSearchAttendance.Name = "txtSearchAttendance";
            this.txtSearchAttendance.Size = new System.Drawing.Size(393, 28);
            this.txtSearchAttendance.TabIndex = 18;
            this.txtSearchAttendance.Text = "Search Student id";
            this.txtSearchAttendance.TextChanged += new System.EventHandler(this.txtSearchAttendance_TextChanged_1);
            // 
            // btnCourse
            // 
            this.btnCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCourse.Location = new System.Drawing.Point(897, 38);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnCourse.Size = new System.Drawing.Size(244, 47);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.Location = new System.Drawing.Point(1161, 38);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnShow.Size = new System.Drawing.Size(192, 47);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(636, 38);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnStart.Size = new System.Drawing.Size(244, 47);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "mm/dd/yyyy";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStartDate
            // 
            this.btnStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.btnStartDate.FlatAppearance.BorderSize = 0;
            this.btnStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDate.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDate.ForeColor = System.Drawing.Color.White;
            this.btnStartDate.Image = ((System.Drawing.Image)(resources.GetObject("btnStartDate.Image")));
            this.btnStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartDate.Location = new System.Drawing.Point(375, 38);
            this.btnStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartDate.Name = "btnStartDate";
            this.btnStartDate.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnStartDate.Size = new System.Drawing.Size(244, 47);
            this.btnStartDate.TabIndex = 8;
            this.btnStartDate.Text = "mm/dd/yyyy";
            this.btnStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartDate.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvAbsent);
            this.panel3.Location = new System.Drawing.Point(24, 448);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1329, 311);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnExportAbsent);
            this.panel4.Controls.Add(this.txtSearchAbsentees);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1329, 71);
            this.panel4.TabIndex = 3;
            // 
            // btnExportAbsent
            // 
            this.btnExportAbsent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(166)))), ((int)(((byte)(55)))));
            this.btnExportAbsent.FlatAppearance.BorderSize = 0;
            this.btnExportAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAbsent.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAbsent.ForeColor = System.Drawing.Color.White;
            this.btnExportAbsent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportAbsent.Location = new System.Drawing.Point(1119, 15);
            this.btnExportAbsent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportAbsent.Name = "btnExportAbsent";
            this.btnExportAbsent.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnExportAbsent.Size = new System.Drawing.Size(155, 36);
            this.btnExportAbsent.TabIndex = 19;
            this.btnExportAbsent.Text = "Search";
            this.btnExportAbsent.UseVisualStyleBackColor = false;
            this.btnExportAbsent.Click += new System.EventHandler(this.btnExportAbsent_Click);
            // 
            // txtSearchAbsentees
            // 
            this.txtSearchAbsentees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchAbsentees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtSearchAbsentees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchAbsentees.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAbsentees.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchAbsentees.Location = new System.Drawing.Point(704, 18);
            this.txtSearchAbsentees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchAbsentees.MaxLength = 255;
            this.txtSearchAbsentees.Multiline = true;
            this.txtSearchAbsentees.Name = "txtSearchAbsentees";
            this.txtSearchAbsentees.Size = new System.Drawing.Size(393, 28);
            this.txtSearchAbsentees.TabIndex = 19;
            this.txtSearchAbsentees.Text = "Search Student id";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Qualy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(31, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "Absent Data";
            // 
            // dgvAbsent
            // 
            this.dgvAbsent.AllowUserToAddRows = false;
            this.dgvAbsent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvAbsent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.dgvAbsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsent.Location = new System.Drawing.Point(0, 71);
            this.dgvAbsent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAbsent.Name = "dgvAbsent";
            this.dgvAbsent.ReadOnly = true;
            this.dgvAbsent.RowHeadersWidth = 51;
            this.dgvAbsent.Size = new System.Drawing.Size(1329, 240);
            this.dgvAbsent.TabIndex = 2;
            this.dgvAbsent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbsent_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.panel5.Controls.Add(this.btnStartDate);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.btnStart);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.btnShow);
            this.panel5.Controls.Add(this.btnCourse);
            this.panel5.Location = new System.Drawing.Point(-1, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1549, 870);
            this.panel5.TabIndex = 25;
            // 
            // formRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formRecords";
            this.Text = "formRecords";
            this.Load += new System.EventHandler(this.formRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsent)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStartDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAbsent;
        private System.Windows.Forms.TextBox txtSearchAttendance;
        private System.Windows.Forms.TextBox txtSearchAbsentees;
        private System.Windows.Forms.Button btnExportAttendace;
        private System.Windows.Forms.Button btnExportAbsent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}