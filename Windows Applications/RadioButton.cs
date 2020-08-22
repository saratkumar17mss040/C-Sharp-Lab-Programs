using System;
using System.Drawing;

namespace OptionButtonControl
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (red.Checked == true)
                BackColor = Color.Red;
            else if (blue.Checked == true)
                BackColor = Color.Blue;
            else if (green.Checked == true)
                BackColor = Color.Green;
            else if (yellow.Checked == true)
                BackColor = Color.Yellow;
            else if (pink.Checked == true)
                BackColor = Color.Pink;
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
