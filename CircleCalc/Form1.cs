using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCalc
{
	public partial class Form1 : Form
	{
		Graphics g;
		Pen p;
		float centerpointx;
		float centerpointy;
		public Form1()
		{
			InitializeComponent();
		}

		public double DEGTORAD(int deg) {
			return Math.PI * deg / 180;
		}

		public void GenerateCircle(int degree, int radius) {

			for (int i = 0; i < degree; i++)
			{
				if (i == 0)
				{
					PointF p1 = new PointF();
					PointF p2 = new PointF();

					p1.X = centerpointx + ((float)Math.Cos(DEGTORAD(360)) * radius);
					p1.Y = centerpointy + ((float)Math.Sin(DEGTORAD(360)) * radius);
					p2.X = centerpointx + ((float)Math.Cos(DEGTORAD(1)) * radius);
					p2.Y = centerpointy + ((float)Math.Sin(DEGTORAD(1)) * radius);
					g.DrawLine(p, p1, p2);
				}
				else {
					PointF p1 = new PointF();
					PointF p2 = new PointF();

					p1.X = centerpointx + ((float)Math.Cos(DEGTORAD(i-1)) * radius);
					p1.Y = centerpointy + ((float)Math.Sin(DEGTORAD(i-1)) * radius);
					p2.X = centerpointx + ((float)Math.Cos(DEGTORAD(i)) * radius);
					p2.Y = centerpointy + ((float)Math.Sin(DEGTORAD(i)) * radius);
					g.DrawLine(p, p1, p2);
				}

				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			g = this.CreateGraphics();
			p = new Pen(Brushes.Black, 0.1f);
			centerpointx = this.Width / 2;
			centerpointy = this.Height / 2;
			GenerateCircle(360, 50);
		}
	}
}
