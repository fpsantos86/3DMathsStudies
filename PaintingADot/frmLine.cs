using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingADot
{
	public partial class frmLine : Form
	{
		Timer timer = new Timer();

		private float formHeight = 0;
		private float formWidth = 0;
		private float formMiddle = 0;
		private float formCenter = 0;
				
		private float x1 = 0;
		private float x2 = 0;
		private float y1 = 0;
		private float y2 = 0;

		public frmLine()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			 formHeight = panel1.Height;
			 formWidth = panel1.Width;
			 formMiddle = formHeight / 2;
			 formCenter = formWidth / 2;

			 x1 = formCenter;
			 x2 = formCenter + 100;
			 y1 = formMiddle;
			 y2 = formMiddle;

			timer.Enabled = true;
			timer.Interval = 100;  
			timer.Tick += new EventHandler(TimerCallback);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{

			
		}

		private void TimerCallback(object sender, EventArgs e)
		{


			formHeight = panel1.Height;
			formWidth = panel1.Width;
			formMiddle = formHeight / 2;
			formCenter = formWidth / 2;

			x1 = formCenter;
			y1 = formMiddle;

			txtFormCenter.Text = formCenter.ToString();
			txtFormMiddle.Text = formMiddle.ToString();
			txtFormHeight.Text = formHeight.ToString();
			txtFormWidth.Text = formWidth.ToString();

			Point point = panel1.PointToClient(Cursor.Position);

			x2 = point.X;
			y2 = point.Y;


			textBox1.Text = x1.ToString();
			textBox2.Text = y1.ToString();
			textBox3.Text = x2.ToString();
			textBox4.Text = y2.ToString();


		

			panel1.Invalidate();
			
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			SolidBrush solidBrush = new SolidBrush(Color.Blue);
			Pen pen = new Pen(solidBrush, 5);

			
			e.Graphics.DrawLine(pen, x1, y1, x2, y2);
		}
	}
}
