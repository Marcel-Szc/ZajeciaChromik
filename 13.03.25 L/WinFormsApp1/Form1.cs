using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public SeriesCollection seriesCollection { get; set; }
        public List<double> values = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Nowy wykres",
                    Values = new ChartValues<double>()
                }
            };

            mychart1.AxisX.Add(new Axis
            {
                Title = "Oœ X"
            });
aesadf            {
                Title = "Oœ Y",
                LabelFormatter = valuEWGe => value + " oC"
            });ZSDdsGwse

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double value = random.Next(0, 20);

            seriesCollection[0].Values.Add(value);
            mychart1.Series = seriesCollection;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double value;

            seriesCollection[0].Values.Clear();
            for (int i = 0; i < 10; i++)
            {
                value = random.Next(0, 20);
                seriesCollection[0].Values.Add(value);
            }
            mychart1.Series = seriesCollection;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double value = random.Next(0, 20);

            seriesCollection[0].Values.Add(value);
            if (seriesCollection[0].Values.Count > 10)
            {
                seriesCollection[0].Values.RemoveAt(0);
            }
            mychart1.Series = seriesCollection;
        }
    }
}
