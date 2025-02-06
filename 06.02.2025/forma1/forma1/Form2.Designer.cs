namespace forma1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(3, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 47);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(13, 94);
            button2.Name = "button2";
            button2.Size = new Size(74, 46);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(109, 94);
            button3.Name = "button3";
            button3.Size = new Size(74, 46);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(206, 94);
            button4.Name = "button4";
            button4.Size = new Size(74, 46);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(206, 155);
            button5.Name = "button5";
            button5.Size = new Size(74, 46);
            button5.TabIndex = 7;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(109, 155);
            button6.Name = "button6";
            button6.Size = new Size(74, 46);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(13, 153);
            button7.Name = "button7";
            button7.Size = new Size(74, 46);
            button7.TabIndex = 5;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(206, 216);
            button8.Name = "button8";
            button8.Size = new Size(74, 46);
            button8.TabIndex = 10;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(109, 216);
            button9.Name = "button9";
            button9.Size = new Size(74, 46);
            button9.TabIndex = 9;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(13, 214);
            button10.Name = "button10";
            button10.Size = new Size(74, 46);
            button10.TabIndex = 8;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(109, 275);
            button11.Name = "button11";
            button11.Size = new Size(74, 46);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(12, 275);
            button12.Name = "button12";
            button12.Size = new Size(74, 46);
            button12.TabIndex = 12;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.DialogResult = DialogResult.OK;
            button13.Location = new Point(205, 275);
            button13.Name = "button13";
            button13.Size = new Size(74, 46);
            button13.TabIndex = 13;
            button13.Text = "#";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 333);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        public TextBox textBox1;
    }
}