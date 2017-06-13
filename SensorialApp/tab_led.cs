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
	public partial class tab_led : UserControl
	{
		IntPtr iHandle;     // global device handle definition
		PicWinUSBAPI picwinusbapi = new PicWinUSBAPI();
		Bitmap Osciloscopio = new Bitmap(401, 256);
		Int16 x = 0;

		private static tab_led _instance;
		public static tab_led Instance
		{
			get
			{
				if (_instance == null)
					_instance = new tab_led();
				return _instance;
			}
		}
		public tab_led()
		{
			Guid InterfaceGuid = new Guid("31415926-5358-9793-2384-626433832795"); // .Inf defined Guid     
			InitializeComponent();
			iHandle = picwinusbapi.Init_PicWinUSB(InterfaceGuid);
			InitializeComponent();
		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void tab_led_Load(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{

		}

		//******************************************************************
		//LEDS ON
		//******************************************************************
		private void BtLeds_on_Click(object sender, EventArgs e)
		{
			bool bres;
			byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
			sdBuffer[0] = 0X09;                                     //Modo Led
			sdBuffer[1] = 0X03;                                     //Leds ON
			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar

		}

		//******************************************************************
		//LEDS TOGGLE
		//******************************************************************
		private void BtLedsToggle_Click(object sender, EventArgs e)
		{
			bool bres;
			byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
			sdBuffer[0] = 0X09;                                     //Modo Led
			sdBuffer[1] = 0X04;                                     //Led Toggle
			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
		}

		//******************************************************************
		//LED ROJO ON LED VERDE OFF
		//******************************************************************
		private void BtLeds_rojo_Click(object sender, EventArgs e)
		{
			bool bres;
			byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
			sdBuffer[0] = 0X09;                                     //Modo Led
			sdBuffer[1] = 0X02;                                     //Led ROJO ON Led Verde OFF
			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
		}

		//******************************************************************
		//LED ROJO OFF LED VERDE ON
		//******************************************************************
		private void BtLeds_verde_Click(object sender, EventArgs e)
		{
			bool bres;
			byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
			sdBuffer[0] = 0X09;                                     //Modo Led
			sdBuffer[1] = 0X01;                                     //Led ROJO OFF Led Verde ON
			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
		}

		//******************************************************************
		//LEDS OFF
		//******************************************************************
		private void BtLeds_off_Click(object sender, EventArgs e)
		{
			bool bres;
			byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
			sdBuffer[0] = 0X09;                                     //Modo Led
			sdBuffer[1] = 0X00;                                     //Leds OFF
			bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
		}
	}
}
