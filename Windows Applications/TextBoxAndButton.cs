using System;
using System.Windows.Forms;

namespace TextBox_And_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(ageTextBox.Text);
            if(age <=18)
                MessageBox.Show($"Your age is {age} and you are not eligible for voting");
            else
                MessageBox.Show($"Your age is {age} and you are eligible for voting");
        }
    }
}
