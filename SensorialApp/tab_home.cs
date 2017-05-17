using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace sensorial
{
	public partial class tab_home : UserControl
	{
		private static tab_home _instance;
		public static tab_home Instance
		{
			get
			{
				if (_instance == null)
					_instance = new tab_home();
				return _instance;
			}
		}
		private int lenArr = 0;
		public tab_home()
		{
			InitializeComponent();
			CanalUno();
		}

		private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}


		private void bunifuCustomLabel7_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel6_Click(object sender, EventArgs e)
		{

		}

		private void bunifuSwitch4_Click(object sender, EventArgs e)
		{

		}

		private void bunifuSwitch3_Click(object sender, EventArgs e)
		{

		}

		private void bunifuSwitch2_Click(object sender, EventArgs e)
		{

		}

		public void CanalUno()
		{

			cartesianChart1.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Canal 1",
					Values = new ChartValues<double> {0}
				}
			};

			cartesianChart1.AxisX.Add(new Axis
			{
				Title = "Month",
				//Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
			});

			cartesianChart1.AxisY.Add(new Axis
			{
				Title = "Volts",
				//LabelFormatter = value => value.ToString("C")
			});

			cartesianChart1.LegendLocation = LegendLocation.Right;

			cartesianChart1.DataClick += CartesianChart1OnDataClick;
		}

		private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
		{
			//MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
			Random rnd = new Random();
			double randomval = rnd.Next(1, 13);
			cartesianChart1.Series[0].Values.Add(randomval);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			lenArr++;
			Random rnd = new Random();
			double randomval = rnd.Next(1, 13);
			cartesianChart1.Series[0].Values.Add(randomval);
			if (lenArr > 30)
			{
				cartesianChart1.Series[0].Values.RemoveAt(0);
			}
		}

		private void cartesianChart1_ChildChanged_1(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{
			CanalUno();
		}
	}
}
