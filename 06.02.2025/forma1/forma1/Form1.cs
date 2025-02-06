using System.Diagnostics.Eventing.Reader;

namespace forma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Wprowadü Kod";
            button2.Enabled = false;

        }
        string haslo1;
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Kod = new Form2();
            DialogResult result = Kod.ShowDialog();
            if (result == DialogResult.OK)
            {
                haslo1 = Kod.textBox1.Text; 
            }
            else if (result == DialogResult.Cancel)
            {

            }

        }
        string kod1;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Kod2 = new Form2();
            DialogResult result2 = Kod2.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                kod1 = Kod2.textBox1.Text;
                sprawdzHaslo(haslo1, kod1);
            }
            else if (result2 == DialogResult.Cancel)
            {

            }
        }
        void sprawdzHaslo(string haslo, string kod)
        {
            if(haslo == null) {
                textBox1.Text = "Nie ustawiono kodu!";
            }
            else {
                if (haslo == kod)
                {
                    button2.Enabled = true;
                    textBox1.Text = "Kod Poprawny!";
                }
                else
                {
                    textBox1.Text = "Kod niepoprawny!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
