using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDisplay.Enabled = false;
            lblTime.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");
        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            if(txtUname.Text == string.Empty)
            {
                btnDisplay.Enabled = false;
            }
            else
            {
                btnDisplay.Enabled = true;
            }
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string name;
            name = txtUname.Text;
            MessageBox.Show(name);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUname.Text = "";
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            Child childobj = new Child();
            childobj.Show();
        }
    }
}
