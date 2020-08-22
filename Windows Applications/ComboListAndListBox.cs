using System;
using System.Windows.Forms;

namespace ComboBoxAndListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stateComboBox.Items.Insert(0, "Tamilnadu");
            stateComboBox.Items.Add("Andhrapradesh");
            stateComboBox.Items.Add("Karnataka");
            stateComboBox.Items.Add("Gujarat");
            stateComboBox.Items.Add("Madhyapradesh");
            districtListBox.Items.Add("Coimbatore");
            districtListBox.Items.Add("Erode");
            districtListBox.Items.Add("Dindigul");
            districtListBox.Items.Add("Karur");
            districtListBox.Items.Add("Kanchipuram");
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string state = stateComboBox.GetItemText(stateComboBox.SelectedItem);
            string district = districtListBox.GetItemText(districtListBox.SelectedItem);
            string name = nameTextBox.Text;
            MessageBox.Show($"Name is: {name}\n" +
                $"State is: {state}\n" +
                $"District is: {district}\n");
        }
    }
}


