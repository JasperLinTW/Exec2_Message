using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			greetLabel.Text = string.Empty;
		}

		private void greetButton_Click(object sender, EventArgs e)
		{
			string getTime = GetTime();
			MessageBox.Show(getTime);
			greetLabel.Text = getTime;
		}

		private string GetTime()
		{
			DateTime time = DateTime.Now;
			if (time.Hour < 6 || time.Hour > 20)
			{
				return $"晚安\r\n現在時間是{time.ToString("yyyy/MM/dd HH:mm:ss")}";
			}
			else if (time.Hour < 10)
			{
				return $"早安\r\n現在時間是{time.ToString("yyyy/MM/dd HH:mm:ss")}";
			}
			else if (time.Hour < 14)
			{
				return $"午安\r\n現在時間是{time.ToString("yyyy/MM/dd HH:mm:ss")}";
			}
			else
			{
				return $"下午好\r\n現在時間是{time.ToString("yyyy/MM/dd HH:mm:ss")}";
			}
		}
	}
}
