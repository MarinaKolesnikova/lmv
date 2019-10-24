using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace tablet_form
{
	public partial class Manager : Form
	{
		System.Timers.Timer t ;
		int h, m, s;
		public Manager()
		{
			InitializeComponent();
		}

		private void Manager_Load(object sender, EventArgs e)
		{
			t = new System.Timers.Timer();
			t.Interval = 1000;
			t.Start();
			t.Elapsed += OnTimeEvent;

		}

		private void OnTimeEvent(object sender, ElapsedEventArgs e)
		{
			Invoke(new Action(() =>
		   {
			   s++;
			   if (s == 60)
			   {
				   m += 1;
			   }
			   if (m == 60)
			   {
				   h += 1;
			   }
			   label5.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
		   }));
		}

		private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void cold_Click(object sender, EventArgs e)
		{
			temperature.Text = Convert.ToString(Convert.ToInt16(temperature.Text) - 1);
		}

		private void hot_Click(object sender, EventArgs e)
		{
			temperature.Text = Convert.ToString(Convert.ToInt16(temperature.Text) + 1);
		}

		private void Manager_FormClosed(object sender, FormClosedEventArgs e)
		{
			t.Stop();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void timer_Tick(object sender, EventArgs e)
		{
			//label5.Text = 
		}
	}
}
