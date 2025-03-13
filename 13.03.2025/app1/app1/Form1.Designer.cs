namespace app1
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
            MyChart = new LiveCharts.WinForms.CartesianChart();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // MyChart
            // 
            MyChart.Location = new Point(12, 12);
            MyChart.Name = "MyChart";
            MyChart.Size = new Size(545, 426);
            MyChart.TabIndex = 0;
            MyChart.ChildChanged += cartesianChart1_ChildChanged;
            // 
            // button1
            // 
            button1.Location = new Point(624, 39);
            button1.Name = "button1";
            button1.Size = new Size(123, 22);
            button1.TabIndex = 1;
            button1.Text = "Dodaj punkt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(680, 114);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Dodaj kolekcję";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MyChart);
            Name = "Form1";
            Text = "Live Charts";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart MyChart;
        private Button button1;
        private Button button2;
    }
}
