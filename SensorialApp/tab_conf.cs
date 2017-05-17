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
	public partial class tab_conf : UserControl
	{
		private static tab_conf _instance;
		public static tab_conf Instance
		{
			get
			{
				if (_instance == null)
					_instance = new tab_conf();
				return _instance;
			}
		}
		public tab_conf()
		{
			InitializeComponent();
		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void tab_conf_Load(object sender, EventArgs e)
		{

		}


	}
}
