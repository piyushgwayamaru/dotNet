using winformLogin;
using WinFormsApp1;

namespace FormPanel
{
    public partial class MainPanel : Form
    {
        private Register reg;
        private Calculator calc;
        private Form1 login;
        public MainPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Register registerpage = new Register();
            registerpage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            if (reg == null || reg.IsDisposed)
            {
                reg = new Register();
                reg.TopLevel = false;
                reg.FormBorderStyle = FormBorderStyle.None;
                reg.Dock = DockStyle.Fill;
            }
            panel3.Controls.Add(reg);
            reg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            if (calc == null || calc.IsDisposed)
            {
                calc = new Calculator();
                calc.TopLevel = false;
                calc.FormBorderStyle = FormBorderStyle.None;
                calc.Dock = DockStyle.Fill;
            }
            panel3.Controls.Add(calc);
            calc.Show();
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            if (login == null || login.IsDisposed)
            {
                login = new Form1();
                login.TopLevel = false;
                login.FormBorderStyle = FormBorderStyle.None;
                login.Dock = DockStyle.Fill;
            }
            panel3.Controls.Add(login);
            login.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
