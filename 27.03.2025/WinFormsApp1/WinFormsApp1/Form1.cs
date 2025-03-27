using System.Globalization;
using Opc.UaFx.Client;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private OpcClient opcClient;
        private OpcClientState opcClientState;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcUrl = textBox1.Text;

            opcClient = new OpcClient(opcUrl);
            opcClientState = new OpcClientState();

            opcClientState = opcClient.State;
            if (opcClientState == OpcClientState.Created)
            {
                opcClient.Connect();
            }

            opcClientState = opcClient.State;
            if (opcClientState == OpcClientState.Connected)
            {
                pictureBox1.BackColor = Color.LimeGreen;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opcClient != null)
            {
                opcClient.Disconnect();

                opcClientState = opcClient.State;
                if (opcClientState == OpcClientState.Connected)
                {
                    pictureBox1.BackColor = Color.LimeGreen;
                }
                else
                {
                    pictureBox1.BackColor = Color.Red;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tagName = textBox2.Text;

            opcClientState = opcClient.State;
            if (opcClientState == OpcClientState.Connected && opcClient != null)
            {
                var temperature = opcClient.ReadNode(tagName);
                textBox3.Text = temperature.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var tagName = textBox2.Text;

            OpcSubscription opcSubscription = opcClient.SubscribeNodes();

            var item = new OpcMonitoredItem(tagName, Opc.UaFx.OpcAttribute.Value);
            item.DataChangeReceived += Item_DataChangeReceived;
            item.SamplingInterval = 200;

            opcSubscription.AddMonitoredItem(item);
            opcSubscription.ApplyChanges();
        }

        private void Item_DataChangeReceived(object sender, OpcDataChangeReceivedEventArgs e)
        {
            OpcMonitoredItem item = (OpcMonitoredItem)sender;
            textBox3.Text = e.Item.Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opcClientState = opcClient.State;
            var tagName = textBox2.Text;
            if (opcClientState == OpcClientState.Connected)
            {
                
                float saveValue = (float)Convert.ToDecimal(textBox4.Text, CultureInfo.GetCultureInfo("en-US"));
                var status = opcClient.WriteNode(tagName, saveValue);
            }
        }
    }
}
