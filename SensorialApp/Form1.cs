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

namespace WindowsFormsApp2
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//Inicializa el primer tab
			container.Controls.Add(sensorial.tab_led.Instance);
			sensorial.tab_conf.Instance.Dock = DockStyle.Fill;
			container.Controls.Add(sensorial.tab_conf.Instance);
			sensorial.tab_calc.Instance.Dock = DockStyle.Fill;
			container.Controls.Add(sensorial.tab_calc.Instance);
			sensorial.tab_led.Instance.Dock = DockStyle.Fill;
			container.Controls.Add(sensorial.tab_eye.Instance);
			sensorial.tab_eye.Instance.Dock = DockStyle.Fill;
			container.Controls.Add(sensorial.tab_home.Instance);
			sensorial.tab_home.Instance.Dock = DockStyle.Fill;
			sensorial.tab_home.Instance.BringToFront();

		}

		private void bunifuCustomLabel1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton6_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void bunifuImageButton8_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel4_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton7_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void bunifuImageButton5_Click(object sender, EventArgs e)
		{
			navIndicator.Top = ((ns1.BunifuImageButton)sender).Top;
			sensorial.tab_home.Instance.BringToFront();
		}

		private void bunifuImageButton4_Click(object sender, EventArgs e)
		{
			navIndicator.Top = ((ns1.BunifuImageButton)sender).Top;
			sensorial.tab_eye.Instance.BringToFront();
		}

		private void bunifuImageButton3_Click(object sender, EventArgs e)
		{
			navIndicator.Top = ((ns1.BunifuImageButton)sender).Top;
			sensorial.tab_led.Instance.BringToFront();
		}

		private void bunifuImageButton2_Click(object sender, EventArgs e)
		{
			navIndicator.Top = ((ns1.BunifuImageButton)sender).Top;
			sensorial.tab_calc.Instance.BringToFront();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			navIndicator.Top = ((ns1.BunifuImageButton)sender).Top;
			sensorial.tab_conf.Instance.BringToFront();
		}

		private void bunifuImageButton5_MouseHover(object sender, EventArgs e)
		{
			navHover.Top = ((ns1.BunifuImageButton)sender).Top;
		}

		private void bunifuImageButton5_MouseLeave(object sender, EventArgs e)
		{
			navHover.Top = -100;
		}

		private void bunifuCustomLabel2_Click_1(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel5_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel5_Click_1(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel2_Click_2(object sender, EventArgs e)
		{

		}

		private void bunifuSwitch2_Click(object sender, EventArgs e)
		{

		}

		private void bunifuSwitch3_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel6_Click(object sender, EventArgs e)
		{

		}

		private void bunifuSwitch4_Click(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton8_Click_1(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bunifuCustomLabel7_Click(object sender, EventArgs e)
		{

		}

		private void tab_home1_Load(object sender, EventArgs e)
		{

		}

		private void tab_home1_Load_1(object sender, EventArgs e)
		{

		}

		private void container_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tab_eye1_Load(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton9_Click(object sender, EventArgs e)
		{

		}
	}
}
