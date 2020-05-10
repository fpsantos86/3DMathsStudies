namespace CartesianSpace
{
	partial class frmCartesian
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlCartesian = new System.Windows.Forms.Panel();
			this.chkVertice1 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblVertice1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pnlCartesian
			// 
			this.pnlCartesian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCartesian.Location = new System.Drawing.Point(13, 13);
			this.pnlCartesian.Name = "pnlCartesian";
			this.pnlCartesian.Size = new System.Drawing.Size(608, 414);
			this.pnlCartesian.TabIndex = 0;
			this.pnlCartesian.Click += new System.EventHandler(this.pnlCartesian_Click);
			this.pnlCartesian.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCartesian_Paint);
			// 
			// chkVertice1
			// 
			this.chkVertice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkVertice1.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkVertice1.Location = new System.Drawing.Point(649, 13);
			this.chkVertice1.Name = "chkVertice1";
			this.chkVertice1.Size = new System.Drawing.Size(127, 24);
			this.chkVertice1.TabIndex = 1;
			this.chkVertice1.Text = "Vertice 1";
			this.chkVertice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkVertice1.UseVisualStyleBackColor = true;
			this.chkVertice1.CheckedChanged += new System.EventHandler(this.chkVertice1_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 457);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(101, 20);
			this.textBox1.TabIndex = 2;
			// 
			// lblVertice1
			// 
			this.lblVertice1.AutoSize = true;
			this.lblVertice1.Location = new System.Drawing.Point(12, 441);
			this.lblVertice1.Name = "lblVertice1";
			this.lblVertice1.Size = new System.Drawing.Size(49, 13);
			this.lblVertice1.TabIndex = 3;
			this.lblVertice1.Text = "Vertice 1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(657, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmCartesian
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 537);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblVertice1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.chkVertice1);
			this.Controls.Add(this.pnlCartesian);
			this.Name = "frmCartesian";
			this.Text = "Cartesian Space";
			this.Load += new System.EventHandler(this.frmCartesian_Load);
			this.Resize += new System.EventHandler(this.frmCartesian_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlCartesian;
		private System.Windows.Forms.CheckBox chkVertice1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblVertice1;
		private System.Windows.Forms.Button button1;
	}
}

