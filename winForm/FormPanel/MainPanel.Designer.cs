namespace FormPanel
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            startTToolStripMenuItem = new ToolStripMenuItem();
            fToolStripMenuItem = new ToolStripMenuItem();
            enableToolStripMenuItem = new ToolStripMenuItem();
            disableToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(198, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.6F);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(37, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(238, 35);
            label1.Name = "label1";
            label1.Size = new Size(258, 46);
            label1.TabIndex = 0;
            label1.Text = "PANEL DESIGN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(4, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(193, 538);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button5.Location = new Point(28, 303);
            button5.Name = "button5";
            button5.Size = new Size(136, 55);
            button5.TabIndex = 2;
            button5.Text = "Calculator";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button4.Location = new Point(26, 204);
            button4.Name = "button4";
            button4.Size = new Size(136, 55);
            button4.TabIndex = 1;
            button4.Text = "LogIn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.Location = new Point(26, 105);
            button3.Name = "button3";
            button3.Size = new Size(136, 55);
            button3.TabIndex = 0;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { startTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(193, 29);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // startTToolStripMenuItem
            // 
            startTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fToolStripMenuItem });
            startTToolStripMenuItem.Name = "startTToolStripMenuItem";
            startTToolStripMenuItem.Size = new Size(48, 25);
            startTToolStripMenuItem.Text = "File";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enableToolStripMenuItem, disableToolStripMenuItem });
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(134, 26);
            fToolStripMenuItem.Text = "Timer";
            // 
            // enableToolStripMenuItem
            // 
            enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            enableToolStripMenuItem.Size = new Size(145, 26);
            enableToolStripMenuItem.Text = "Enable ";
            enableToolStripMenuItem.Click += enableToolStripMenuItem_Click;
            // 
            // disableToolStripMenuItem
            // 
            disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            disableToolStripMenuItem.Size = new Size(145, 26);
            disableToolStripMenuItem.Text = "Disable";
            disableToolStripMenuItem.Click += disableToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(199, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 415);
            panel3.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 540);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "MainPanel";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private Button button5;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startTToolStripMenuItem;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem enableToolStripMenuItem;
        private ToolStripMenuItem disableToolStripMenuItem;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
