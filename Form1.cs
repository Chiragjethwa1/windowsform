using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Fillout username"); }

            else if (textBox2.Text == "") { MessageBox.Show("Fillout the password"); }

            else if (textBox2.TextLength != 10) { MessageBox.Show("Fillout the password with 10 chr ONLY"); }

            else if (radioButton1.Checked == false &&
            radioButton2.Checked == false)

            { MessageBox.Show("Fillout the gender"); }

            else if
            (radioButton3.Checked == false &&
            radioButton4.Checked == false &&
            radioButton5.Checked == false)
            { MessageBox.Show("Fillout the payment option"); }


            else
            {
                MessageBox.Show("Congratulations!!! your Account has been Created");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do" +
            "you want to clode this window", "Confirm", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else if (checkBox2.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            checkBox1.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
