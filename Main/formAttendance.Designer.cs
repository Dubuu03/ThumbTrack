namespace Main
{
    partial class formAttendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.btnTimeIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(912, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "ATTENDANCE MONITORING SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimeOut.Location = new System.Drawing.Point(726, 313);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(213, 69);
            this.btnTimeOut.TabIndex = 2;
            this.btnTimeOut.Text = "TIME OUT";
            this.btnTimeOut.UseVisualStyleBackColor = true;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimeIn.Location = new System.Drawing.Point(486, 313);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Size = new System.Drawing.Size(213, 69);
            this.btnTimeIn.TabIndex = 1;
            this.btnTimeIn.Text = "TIME IN";
            this.btnTimeIn.UseVisualStyleBackColor = true;
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // formAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1406, 819);
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimeIn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAttendance";
            this.Text = "formAttendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Button btnTimeIn;
    }
}