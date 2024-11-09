using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Main
{
    public partial class formStudentID : Form
    {
        public formStudentID()
        {
            InitializeComponent();
        }

        // Property to store the Student ID entered by the user
        public string StudentId { get; set; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if the Student ID field is not empty
            if (!string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                StudentId = txtStudentId.Text; // Set the Student ID property
                this.DialogResult = DialogResult.OK; // Close form with OK result
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
            }
        }
    }
}
