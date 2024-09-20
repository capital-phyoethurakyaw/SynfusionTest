using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynfusionTest
{
    public partial class Form1 : Form
    {
        public Form1()//pyk
        {
            InitializeComponent();
            //Develop Branch
            //PTK Feature 
            //Sawkay updates
            //Sawlay 2nd updates
        }

        private void lblFile_Click(object sender, EventArgs e)
        {
            if (lblFile.Text == "▶ File")
            {
                lblFile.Text = "▼ File";
                fpFile.Visible = true;
            }
            else
            {
                lblFile.Text = "▶ File";
                fpFile.Visible = false;
            }
        }

        private void lblGeneral_Click(object sender, EventArgs e)
        {
            if (lblGeneral.Text == "▶ General")
            {
                lblGeneral.Text = "▼ General";
                fpGeneral.Visible = true;
            }
            else
            {
                lblGeneral.Text = "▶ General";
                fpGeneral.Visible = false;
            }

        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            if (lblEdit.Text == "▶ Edit")
            {
                lblEdit.Text = "▼ Edit";
                fpEdit.Visible = true;
            }
            else
            {
                lblEdit.Text = "▶ Edit";
                fpEdit.Visible = false;
            }
        }

        private void lblView_Click(object sender, EventArgs e)
        {
            if (lblView.Text == "▶ View")
            {
                lblView.Text = "▼ View";
                fpView.Visible = true;
            }
            else
            {
                lblView.Text = "▶ View";
                fpView.Visible = false;
            }
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {
            if (lblLabel.Text == "▶ Label")
            {
                lblLabel.Text = "▼ Label";
                fpLabel.Visible = true;
            }
            else
            {
                lblLabel.Text = "▶ Label";
                fpLabel.Visible = false;
            }
        }

        private void btnDirectedLabel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor= SystemColors.GrayText;
            }
            if (sender is IconButton ib)
            {
                ib.BackColor= SystemColors.GrayText;
            }
        }

        private void btnDirectedLabel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor =  Color.Black;
            }
            if (sender is IconButton ib)
            {
                ib.BackColor = Color.Black;
            }
        }
    }
}
