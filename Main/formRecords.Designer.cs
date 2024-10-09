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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStartDate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAbsent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchAttendance = new System.Windows.Forms.TextBox();
            this.txtSearchAbsentees = new System.Windows.Forms.TextBox();
            this.btnExportAttendace = new System.Windows.Forms.Button();
            this.btnExportAbsent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAttendance.Location = new System.Drawing.Point(0, 70);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.Size = new System.Drawing.Size(1129, 251);
            this.dgvAttendance.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvAttendance);
            this.panel1.Location = new System.Drawing.Point(139, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 321);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExportAttendace);
            this.panel2.Controls.Add(this.txtSearchAttendance);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 72);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(557, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Attendance Data";
            // 
            // btnCourse
            // 
            this.btnCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCourse.BackColor = System.Drawing.Color.White;
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCourse.Location = new System.Drawing.Point(918, 27);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnCourse.Size = new System.Drawing.Size(171, 61);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(172)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.Location = new System.Drawing.Point(1097, 27);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnShow.Size = new System.Drawing.Size(171, 61);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(741, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnStart.Size = new System.Drawing.Size(171, 61);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "mm/dd/yyyy";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStartDate
            // 
            this.btnStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartDate.BackColor = System.Drawing.Color.White;
            this.btnStartDate.FlatAppearance.BorderSize = 0;
            this.btnStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartDate.Image = ((System.Drawing.Image)(resources.GetObject("btnStartDate.Image")));
            this.btnStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartDate.Location = new System.Drawing.Point(564, 27);
            this.btnStartDate.Name = "btnStartDate";
            this.btnStartDate.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnStartDate.Size = new System.Drawing.Size(171, 61);
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
            this.panel3.Location = new System.Drawing.Point(139, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1129, 321);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnExportAbsent);
            this.panel4.Controls.Add(this.txtSearchAbsentees);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1129, 72);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Absent Data";
            // 
            // dgvAbsent
            // 
            this.dgvAbsent.AllowUserToAddRows = false;
            this.dgvAbsent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAbsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAbsent.Location = new System.Drawing.Point(0, 71);
            this.dgvAbsent.Name = "dgvAbsent";
            this.dgvAbsent.ReadOnly = true;
            this.dgvAbsent.Size = new System.Drawing.Size(1129, 250);
            this.dgvAbsent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(557, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search:";
            // 
            // txtSearchAttendance
            // 
            this.txtSearchAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAttendance.Location = new System.Drawing.Point(656, 12);
            this.txtSearchAttendance.MaxLength = 255;
            this.txtSearchAttendance.Multiline = true;
            this.txtSearchAttendance.Name = "txtSearchAttendance";
            this.txtSearchAttendance.Size = new System.Drawing.Size(295, 36);
            this.txtSearchAttendance.TabIndex = 18;
            // 
            // txtSearchAbsentees
            // 
            this.txtSearchAbsentees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchAbsentees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAbsentees.Location = new System.Drawing.Point(656, 15);
            this.txtSearchAbsentees.MaxLength = 255;
            this.txtSearchAbsentees.Multiline = true;
            this.txtSearchAbsentees.Name = "txtSearchAbsentees";
            this.txtSearchAbsentees.Size = new System.Drawing.Size(295, 36);
            this.txtSearchAbsentees.TabIndex = 19;
            // 
            // btnExportAttendace
            // 
            this.btnExportAttendace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportAttendace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.btnExportAttendace.FlatAppearance.BorderSize = 0;
            this.btnExportAttendace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAttendace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAttendace.ForeColor = System.Drawing.Color.White;
            this.btnExportAttendace.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportAttendace.Location = new System.Drawing.Point(967, 9);
            this.btnExportAttendace.Name = "btnExportAttendace";
            this.btnExportAttendace.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnExportAttendace.Size = new System.Drawing.Size(116, 39);
            this.btnExportAttendace.TabIndex = 9;
            this.btnExportAttendace.Text = "Export";
            this.btnExportAttendace.UseVisualStyleBackColor = false;
            // 
            // btnExportAbsent
            // 
            this.btnExportAbsent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.btnExportAbsent.FlatAppearance.BorderSize = 0;
            this.btnExportAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAbsent.ForeColor = System.Drawing.Color.White;
            this.btnExportAbsent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportAbsent.Location = new System.Drawing.Point(967, 13);
            this.btnExportAbsent.Name = "btnExportAbsent";
            this.btnExportAbsent.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnExportAbsent.Size = new System.Drawing.Size(116, 39);
            this.btnExportAbsent.TabIndex = 19;
            this.btnExportAbsent.Text = "Export";
            this.btnExportAbsent.UseVisualStyleBackColor = false;
            // 
            // formRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1406, 819);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnStartDate);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportAttendace;
        private System.Windows.Forms.Button btnExportAbsent;
    }
}