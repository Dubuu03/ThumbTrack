namespace Main
{
    partial class formToday
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
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportAttendace = new System.Windows.Forms.Button();
            this.txtSearchAttendance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Qualy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.lbDate.Location = new System.Drawing.Point(684, 2);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(65, 25);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "Date:";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Qualy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.lbTime.Location = new System.Drawing.Point(684, 27);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(64, 25);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time:";
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvAttendance);
            this.panel1.Location = new System.Drawing.Point(39, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 527);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 58);
            this.panel2.TabIndex = 3;
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
            this.btnExportAttendace.Location = new System.Drawing.Point(469, 14);
            this.btnExportAttendace.Name = "btnExportAttendace";
            this.btnExportAttendace.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnExportAttendace.Size = new System.Drawing.Size(116, 36);
            this.btnExportAttendace.TabIndex = 9;
            this.btnExportAttendace.Text = "Export";
            this.btnExportAttendace.UseVisualStyleBackColor = false;
            // 
            // txtSearchAttendance
            // 
            this.txtSearchAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtSearchAttendance.Font = new System.Drawing.Font("Qualy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAttendance.ForeColor = System.Drawing.Color.White;
            this.txtSearchAttendance.Location = new System.Drawing.Point(39, 14);
            this.txtSearchAttendance.MaxLength = 255;
            this.txtSearchAttendance.Multiline = true;
            this.txtSearchAttendance.Name = "txtSearchAttendance";
            this.txtSearchAttendance.Size = new System.Drawing.Size(410, 36);
            this.txtSearchAttendance.TabIndex = 18;
            this.txtSearchAttendance.Text = "SEARCH STUDENT ID";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Qualy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(46, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 34);
            this.label10.TabIndex = 5;
            this.label10.Text = "Today\'s Log";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAttendance.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAttendance.Location = new System.Drawing.Point(0, -33);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.Size = new System.Drawing.Size(960, 560);
            this.dgvAttendance.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.btnExportAttendace);
            this.panel5.Controls.Add(this.txtSearchAttendance);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1550, 870);
            this.panel5.TabIndex = 25;
            // 
            // formToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formToday";
            this.Text = "formToday";
            this.Load += new System.EventHandler(this.formToday_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportAttendace;
        private System.Windows.Forms.TextBox txtSearchAttendance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel panel5;
    }
}