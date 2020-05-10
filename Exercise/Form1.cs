using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{


	public partial class Form1 : Form
	{
		Graphics g;
		Pen pen;
		const float UM_CENTIMETRO = 37.795275591F;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = $"Width: {panel1.Width} / Height: {panel1.Height}";

			panel1.BackColor = Color.White;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DrawCartesianSpace();
		}

		public void DrawCartesianSpace() 
		{ 
			
			g = panel1.CreateGraphics();
			var height = panel1.Height;
			var width = panel1.Width;

			
			var middle = height / 2;
			var center = width / 2;

			pen = new Pen(Color.Silver, 0.3F);

			for (float y = middle; y < height; y+= UM_CENTIMETRO)
			{
				g.DrawLine(pen, 0, y, width, y);
			}

			for (float y = middle; y >= 1; y -= UM_CENTIMETRO)
			{
				g.DrawLine(pen, 0, y, width, y);
			}

			for (float x = center; x < width; x += UM_CENTIMETRO)
			{
				g.DrawLine(pen, x, 0, x, height);
			}

			for (float x = center; x >=1; x -= UM_CENTIMETRO)
			{
				g.DrawLine(pen, x, 0, x, height);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DrawCircleInTheCenter();
		}

		public void DrawCircleInTheCenter() 
		{
			g = panel1.CreateGraphics();
			var height = panel1.Height;
			var width = panel1.Width;

		

			pen = new Pen(Color.Red, 0.5F);
			
			var diameter = (5 * UM_CENTIMETRO) *2F;

			var x = (width / 2) - (diameter/2);
			var y = (height / 2) - (diameter / 2);

			g.DrawEllipse(pen, (float)x, (float)y , (float)diameter, (float)diameter);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DrawAxis();
		}

		public void DrawAxis() {
			g = panel1.CreateGraphics();
			var height = panel1.Height;
			var width = panel1.Width;

			pen = new Pen(Color.Blue, 0.5F);

			var middle = height / 2;
			var center = width / 2;
			g.DrawLine(pen, 0, middle, width, middle);
		
			g.DrawLine(pen, center, 0, center, height);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			Point point = panel1.PointToClient(Cursor.Position);
			var x = point.X;
			var y = point.Y;

			toolStripStatusLabel2.Text = $"X: {x} / Y: {y}";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DrawAngle45();
		}


		public void DrawAngle45() 
		{
			g = panel1.CreateGraphics();
			var height = panel1.Height;
			var width = panel1.Width;

			var middle = height / 2;
			var center = width / 2;

			pen = new Pen(Color.Red, 1);

			g.DrawLine(pen, center, middle, center + (4 * UM_CENTIMETRO),middle - (4* UM_CENTIMETRO));
		}

		private void button5_Click(object sender, EventArgs e)
		{
			DrawAngle90();
		}

		public void DrawAngle90()
		{
			g = panel1.CreateGraphics();
			var height = panel1.Height;
			var width = panel1.Width;

			var middle = height / 2;
			var center = width / 2;

			pen = new Pen(Color.Black, 3);

			g.DrawRectangle(pen, center, middle- UM_CENTIMETRO, (UM_CENTIMETRO), (UM_CENTIMETRO));
		}
	}
}
