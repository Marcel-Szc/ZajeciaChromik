using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;

namespace app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SeriesCollection SeriesCollection { get; set; }
        public List<double> Values = new List<double>();
        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title="Nowy wykres",
                    Values=new ChartValues<double>(),
                }
            };
            MyChart.AxisX.Add(new Axis
            {
                Title = "Oœ X"
            });
            MyChart.AxisY.Add(new Axis
            {
                Title = "Oœ Y"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double value = random.Next(0, 20);
            SeriesCollection[0].Values.Add(value);
            MyChart.Series = SeriesCollection;
        }
    }
}
