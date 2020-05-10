using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartesianSpace
{
	public partial class frmCartesian : Form
	{


		public frmCartesian()
		{
			InitializeComponent();
		}

		private void frmCartesian_Load(object sender, EventArgs e)
		{
			pnlCartesian.BackColor = Color.White;
		}

		private void pnlCartesian_Paint(object sender, PaintEventArgs e)
		{
			DrawCartesianSpace(e);
		}

		private void frmCartesian_Resize(object sender, EventArgs e)
		{
			pnlCartesian.Refresh();
		}

		public void DrawCartesianSpace(PaintEventArgs e) 
		{
			try
			{
				SolidBrush solidBrush = new SolidBrush(Color.Blue);
				Pen pen = new Pen(solidBrush, 1);

				var width = pnlCartesian.Width == 0 ? 1 : pnlCartesian.Width;
				var horizontalRatio = ((width * 5) / 100) < 1 ? 1 : ((width * 5) / 100);
				var spaces = width / horizontalRatio;
				var y1 = 0;
				var y2 = pnlCartesian.Height;

				for (int x = 0; x < width; x += spaces)
				{
					e.Graphics.DrawLine(pen, x, y1, x, y2);
				}

				var height = pnlCartesian.Height == 0 ? 1 : pnlCartesian.Height;
				var verticalRatio = ((height * 5) / 100) < 1 ? 1 : ((height * 5) / 100);
				var interval = height / verticalRatio;
				var x1 = 0;
				var x2 = pnlCartesian.Width;

				for (int y = 0; y < height; y += interval)
				{
					e.Graphics.DrawLine(pen, x1, y, x2, y);
				}

				if (vertice1[0] > 0) {
					SolidBrush vertice1Brush = new SolidBrush(Color.Green);
					Pen penVertice1 = new Pen(Color.Green, 2);
					e.Graphics.DrawEllipse(penVertice1,vertice1[0],vertice1[1], 20F,20F);
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);

			}
		}
	
		private bool CatchVertice1 = false;
		private bool CatchVertice2 = false;
		private bool CatchVertice3 = false;
		private bool CatchVertice4 = false;
		private bool CatchVertice5 = false;
		private bool CatchVertice6 = false;
		private bool CatchVertice7 = false;
		private bool CatchVertice8 = false;

		private float[] vertice1 = new float[2];
		private float[] vertice2 = new float[2];
		private float[] vertice3 = new float[2];
		private float[] vertice4 = new float[2];
		private float[] vertice5 = new float[2];
		private float[] vertice6 = new float[2];
		private float[] vertice7 = new float[2];
		private float[] vertice8 = new float[2];


		private void chkVertice1_CheckedChanged(object sender, EventArgs e)
		{
			CatchVertice1 = true;
		}

		private void pnlCartesian_Click(object sender, EventArgs e)
		{
			if (CatchVertice1) 
			{
				Point point = pnlCartesian.PointToClient(Cursor.Position);

				vertice1[0] = point.X;
				vertice1[1] = point.Y;
				pnlCartesian.Refresh();


			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Graphics g = pnlCartesian.CreateGraphics();

			float x1 = 0;
			float x2 = 0;
			float y1 = 0;
			float y2 = 0;
			for (int i = pnlCartesian.Width / 2; i < 1000; i++)
			{
				x1 = i;
				y1 = pnlCartesian.Height / 2;
				x2 = (pnlCartesian.Width / 2) + 100;
				//y2 = (pnlCartesian.Height / 2) + 100;
				y2 = (float)(Math.Sin(i) + 1000);

				g.DrawLine(new Pen(Color.Red, 1), new PointF(x1,y1 ),new PointF(x2, y2));
			}
			///
			//// Create pen.
			Pen blackPen = new Pen(Color.Black, 3);

			//// Create location and size of ellipse.
			//float x = 0.0F;
			//float y = 0.0F;
			//float width = 200.0F;
			//float height = 100.0F;

			//// Create start and sweep angles.
			//float startAngle = 0.0F;
			//float sweepAngle = 45.0F;

			//// Draw pie to screen.
			//g.DrawPie(blackPen, x, y, width, height, startAngle, sweepAngle);

			//g.DrawPolygon(blackPen, new Point[] { new Point(0, 0), new Point(100, 20) , new Point(200, 330) });


		}


	}

	
	
}
