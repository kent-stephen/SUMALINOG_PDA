using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUMALINOG_PDA
{
    public partial class FormPDA : Form
    {
        Context context;
        string text;

        public FormPDA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "PDA checking for Balanced Symbols";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "PDA checking for Palindromes";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string output;
            if (radioButton1.Checked)
            {
                context = new Context(new Balanced());
                text = tb_text.Text;
                output = context.CheckInput(text);
                lbl_output.Text = output;

            } else if (radioButton2.Checked)
            {
                context = new Context(new Palindrome());
                text = tb_text.Text;
                output = context.CheckInput(text);
                lbl_output.Text = output;
            }
        }

        private void lbl_output_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            tb_text.Text = "";
            lbl_output.Text = "";
        }
    }
}
