using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPanel
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select your gender.");
                return;
            }

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please enter a valid age greater than 0.");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your province.");
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your district.");
                return;
            }

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Please select at least one skill.");
                return;
            }

            // Gather details
            string name = textBox1.Text;
            string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            int age = (int)numericUpDown1.Value;
            string province = comboBox1.SelectedItem.ToString();
            string district = comboBox2.SelectedItem.ToString();

            string skills = "";
            if (checkBox1.Checked) skills += checkBox1.Text + " ";
            if (checkBox2.Checked) skills += checkBox2.Text;

            string message = $"Name: {textBox1.Text}\n" +
                             $"Gender: {gender}\n" +
                             $"Age: {age}\n" +
                             $"Province: {province}\n" +
                             $"District: {district}\n" +
                             $"Skills: {skills.Trim()}";

            MessageBox.Show(message, "Registration Details");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var province = comboBox1.SelectedItem.ToString();
            List<string> bagmatiDistricts = new List<string> { "Kathmandu", "Bhaktapur", "Lalitpur" };
            List<string> gandakiDistricts = new List<string> { "Kaski", "Lamjung", "Manang" };

            comboBox2.Items.Clear();
            switch (province)
            {
                case "Bagmati":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(bagmatiDistricts.ToArray());
                    break;
                case "Gandaki":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(gandakiDistricts.ToArray());
                    break;
                default:
                    comboBox2.Items.Clear();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            numericUpDown1.Value = 0;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
