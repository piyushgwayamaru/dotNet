namespace WinFormsApp1
{
    public partial class Calculator : Form
    { //2 label, 2 txtbox, password change by *
        public Calculator()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.KeyPress += textBox1_keyPress;
            textBox2.KeyPress += textBox1_keyPress;
        }

        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nOnly numbers are allowed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 - num2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 / num2;
                textBox3.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + " Unexpected error by dividing 0");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
