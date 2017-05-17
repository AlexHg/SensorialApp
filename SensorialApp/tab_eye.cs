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
			InitializeComponent();
		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void tab_eye_Load(object sender, EventArgs e)
		{

		}

		private void BtnSensorMovimiento_Click(object sender, EventArgs e)
		{
			BtnSensorMovimiento.BackColor = System.Drawing.Color.DarkBlue;
		}

		private void BtnSensorGas_Click(object sender, EventArgs e)
		{

		}


		private void BtnSensorLuz_Click(object sender, EventArgs e)
		{

		}

		private void BtnSensorCalor_Click(object sender, EventArgs e)
		{

		}
	}
}
