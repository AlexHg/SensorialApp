using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sensorial
{
	public partial class tab_eye : UserControl
	{
		IntPtr iHandle;     // global device handle definition
		PicWinUSBAPI picwinusbapi = new PicWinUSBAPI();
		Bitmap Osciloscopio = new Bitmap(401, 256);
		//Int16 x = 0;

		private static tab_eye _instance;
		public static tab_eye Instance
		{
			get
			{
				if (_instance == null)
					_instance = new tab_eye();
				return _instance;
			}
		}
		public tab_eye()
		{
			Guid InterfaceGuid = new Guid("31415926-5358-9793-2384-626433832795"); // .Inf defined Guid     
			InitializeComponent();
			iHandle = picwinusbapi.Init_PicWinUSB(InterfaceGuid);
		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{
			
		}

		private void tab_eye_Load(object sender, EventArgs e)
		{

		}

		private void BtnSensorMovimiento_Click(object sender, EventArgs e)
		{
			bool bres;
			byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
			byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

			sdBuffer[0] = 0x00;    //Modo PIR

			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
			bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);
			movimientoText.Text = rdBuffer[0].ToString();
			if (rdBuffer[0].ToString() == "0")
				movimientoSens.Hide();
			else
				movimientoSens.Show();
		}

		private void BtnSensorGas_Click(object sender, EventArgs e)
		{
			bool bres;//Gas
			byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
			byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

			sdBuffer[0] = 0x02;    //Modo MULTIPLICACION

			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
			bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);
			String aux = rdBuffer[0].ToString();
			double particulas = Math.Pow(1.1, int.Parse(aux));
			gasText.Text = particulas + "ppm";
			gasBar.Value = (int)particulas;
		}


		private void BtnSensorLuz_Click(object sender, EventArgs e)
		{
			bool bres;//Luz
			byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
			byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

			sdBuffer[0] = 0x03;    //Modo DIVISION

			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
			bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);
			String aux = rdBuffer[0].ToString();
			double lux = Math.Pow(int.Parse(aux), 2);
			luzText.Text = lux + " lx";
			luzBar.Value = (int)lux;
		}

		private void BtnSensorCalor_Click(object sender, EventArgs e)
		{
			bool bres;//temperatura
			byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
			byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

			sdBuffer[0] = 0x01;    //Modo RESTA

			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
			bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);
			String aux = rdBuffer[0].ToString();
			double grados = int.Parse(aux) * 1.96;
			temperaturaText.Text = grados + "°";
			temperaturaBar.Value = (int)grados;
		}

		private void temperaturaText_Click(object sender, EventArgs e)
		{

		}

		private void gasText_Click(object sender, EventArgs e)
		{

		}

		private void movimientoText_Click(object sender, EventArgs e)
		{

		}

		private void luzText_Click(object sender, EventArgs e)
		{

		}
	}
}
