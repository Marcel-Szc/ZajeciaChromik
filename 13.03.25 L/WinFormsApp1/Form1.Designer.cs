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
            mychart1 = new LiveCharts.WinForms.CartesianChart();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // mychart1
            // 
            mychart1.Location = new Point(134, 12);
            mychart1.Name = "mychart1";
            mychart1.Size = new Size(519, 411);
            mychart1.TabIndex = 0;
            mychart1.Text = "cartesianChart1";
            // 
            // button1
            // 
            button1.Location = new Point(676, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 21);
            button1.TabIndex = 1;
            button1.Text = "Dodaj Punkt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(676, 55);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 2;
            button2.Text = "dodaj kolekcję";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(676, 97);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(mychart1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart mychart1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
