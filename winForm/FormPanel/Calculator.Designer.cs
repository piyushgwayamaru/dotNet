namespace WinFormsApp1
{
    partial class Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 95);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Number1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 150);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 1;
            label2.Text = "Number2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.6F, FontStyle.Bold);
            label3.Location = new Point(238, 31);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 2;
            label3.Text = "Simple Calculator";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 29);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 29);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(133, 209);
            button1.Name = "button1";
            button1.Size = new Size(77, 57);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(226, 209);
            button2.Name = "button2";
            button2.Size = new Size(71, 57);
            button2.TabIndex = 6;
            button2.Text = "Sub";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(313, 210);
            button3.Name = "button3";
            button3.Size = new Size(76, 54);
            button3.TabIndex = 7;
            button3.Text = "Mul";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(410, 209);
            button4.Name = "button4";
            button4.Size = new Size(74, 53);
            button4.TabIndex = 8;
            button4.Text = "Div";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.6F);
            button5.Location = new Point(406, 105);
            button5.Name = "button5";
            button5.Size = new Size(94, 55);
            button5.TabIndex = 9;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 292);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 10;
            label4.Text = "Answer";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 292);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 29);
            textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 450);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.6F);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private TextBox textBox3;
    }
}
