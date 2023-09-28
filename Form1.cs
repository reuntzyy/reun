using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {

        }
        String n1, n2, op;

        private void Button15_Click(object sender, EventArgs e)
        {
            if (!lblResult.Text.Contains("."))
            {
                lblResult.Text += ".";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x = lblResult.Text.Length - 1;
            lblResult.Text = lblResult.Text.Substring(0, x);
            if (lblResult.Text.Length ==0)
            {
                lblResult.Text = "0";
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            n2 = lblResult.Text;
            if (op == "+")
            {
                lblResult.Text = ((Convert.ToDouble(n1)) + (Convert.ToDouble(n2))).ToString();
            }
            else if (op == "-")
            {
                lblResult.Text = ((Convert.ToDouble(n1)) - (Convert.ToDouble(n2))).ToString();
            }
            else if (op == "*")
            {
                lblResult.Text = ((Convert.ToDouble(n1)) * (Convert.ToDouble(n2))).ToString();
            }
            else if ( op == "/")
            {
                lblResult.Text = ((Convert.ToDouble(n1)) / (Convert.ToDouble(n2))).ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            n1 = lblResult.Text;
            lblResult.Text = "0";
            Button b = (Button)sender;
            op = b.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (lblResult.Text == "0")
            {
                lblResult.Text = "";
                lblResult.Text += b.Text;
            }
            else
            {
                lblResult.Text += b.Text;
            }
        }
    }
}
