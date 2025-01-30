using System.Diagnostics.Eventing.Reader;

namespace Zadanie1
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Text";
            //this.WindowState = FormWindowState.Minimized;
            this.BackColor = Color.White;
            //this.Width = 100;
            //this.Height = 100;

            Button przycisk = new Button();
            przycisk.Width = 50;
            przycisk.Height = 50;
            przycisk.Location = new Point(10, 10);
            przycisk.Text = "Ok";
            this.Controls.Add(przycisk);
        }
        private void Form1_FormCLosing(object sender, FormClosingEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 loguj = new Form2();
            //loguj.ShowDialog();
            DialogResult result = loguj.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (loguj.textBox2.Text == "qwerty" && loguj.textBox1.Text != null && loguj.textBox2.Text != null)
                {
                    this.textBox1.BackColor = Color.Green;
                    this.textBox3.BackColor = Color.Green;
                    this.textBox1.Text = loguj.textBox1.Text;
                    this.textBox3.Text = loguj.textBox2.Text;
                } else
                {
                    this.textBox1.BackColor = Color.Red;
                    this.textBox3.BackColor = Color.Red;
                    this.textBox1.Text = "Z³e has³o!";
                    this.textBox3.Text = "Z³e has³o!";
                }
            }
            else if (result == DialogResult.Cancel)
            {
                
            }
            //loguj.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
