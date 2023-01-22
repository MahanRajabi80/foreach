using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control t in this.Controls)
            {
                if (t.GetType().Name == "TextBox")
                {
                    t.BackColor = Color.White;
                    t.Text = "";
                }
            }
            txtInput1.Focus();
        }

        private void txtInput1_Enter(object sender, EventArgs e)
        {
            txtInput1.BackColor = Color.LightBlue;
        }

        private void txtInput1_Leave(object sender, EventArgs e)
        {
            txtInput1.BackColor = Color.White;
        }

        private void txtInput2_Enter(object sender, EventArgs e)
        {
            txtInput2.BackColor = Color.LightBlue;
        }

        private void txtInput2_Leave(object sender, EventArgs e)
        {
            txtInput2.BackColor = Color.White;
        }

        private void txtInput3_Enter(object sender, EventArgs e)
        {
            txtInput3.BackColor = Color.LightBlue;
        }

        private void txtInput3_Leave(object sender, EventArgs e)
        {
            txtInput3.BackColor = Color.White;
        }

        private void txtInput4_Enter(object sender, EventArgs e)
        {
            txtInput4.BackColor = Color.LightBlue;
        }

        private void txtInput4_Leave(object sender, EventArgs e)
        {
            txtInput4.BackColor = Color.White;
        }

        private void txtInput5_Enter(object sender, EventArgs e)
        {
            txtInput5.BackColor = Color.LightBlue;
        }

        private void txtInput5_Leave(object sender, EventArgs e)
        {
            txtInput5.BackColor = Color.White;
        }
    }
}
