namespace WinFormsApp1
{
    partial class Form1
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
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 25);
            textBox1.MaximumSize = new Size(500, 500);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "opc.tcp://192.168.15.99:4840";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F);
            button1.Location = new Point(12, 204);
            button1.Name = "button1";
            button1.Size = new Size(219, 63);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(58, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 15);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F);
            button2.Location = new Point(256, 204);
            button2.Name = "button2";
            button2.Size = new Size(219, 63);
            button2.TabIndex = 3;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "ns=4;i=2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(256, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 23);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(324, 72);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 6;
            label1.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(104, 72);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 7;
            label2.Text = "NodeID";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F);
            button3.Location = new Point(256, 295);
            button3.Name = "button3";
            button3.Size = new Size(219, 63);
            button3.TabIndex = 8;
            button3.Text = "Read Data";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F);
            button4.Location = new Point(12, 295);
            button4.Name = "button4";
            button4.Size = new Size(219, 63);
            button4.TabIndex = 9;
            button4.Text = "Subscription";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(486, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 23);
            textBox4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(552, 72);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 11;
            label3.Text = "Write";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F);
            button5.Location = new Point(486, 204);
            button5.Name = "button5";
            button5.Size = new Size(219, 63);
            button5.TabIndex = 12;
            button5.Text = "Write";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 383);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private Label label3;
        private Button button5;
    }
}
