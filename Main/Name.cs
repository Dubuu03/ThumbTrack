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
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }
        public string StudentName { get; set; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                StudentName = txtName.Text; 
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }
        }
        }
}
