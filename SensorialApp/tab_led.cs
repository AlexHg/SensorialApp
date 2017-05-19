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
	}
}
