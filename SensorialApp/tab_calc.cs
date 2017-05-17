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
	public partial class tab_calc : UserControl
	{
		private static tab_calc _instance;
		public static tab_calc Instance
		{
			get
			{
				if (_instance == null)
					_instance = new tab_calc();
				return _instance;
			}
		}
		public tab_calc()
		{
			InitializeComponent();
		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void tab_calc_Load(object sender, EventArgs e)
		{

		}
	}
}
