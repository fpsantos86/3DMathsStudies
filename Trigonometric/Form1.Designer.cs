namespace Trigonometric
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.picGraph = new System.Windows.Forms.PictureBox();
			this.txtXmin = new System.Windows.Forms.TextBox();
			this.txtXmax = new System.Windows.Forms.TextBox();
			this.txtYmin = new System.Windows.Forms.TextBox();
			this.txtYmax = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(816, 116);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Graph";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// picGraph
			// 
			this.picGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picGraph.Location = new System.Drawing.Point(12, 12);
			this.picGraph.Name = "picGraph";
			this.picGraph.Size = new System.Drawing.Size(750, 426);
			this.picGraph.TabIndex = 1;
			this.picGraph.TabStop = false;
			// 
			// txtXmin
			// 
			this.txtXmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtXmin.Location = new System.Drawing.Point(794, 12);
			this.txtXmin.Name = "txtXmin";
			this.txtXmin.Size = new System.Drawing.Size(100, 20);
			this.txtXmin.TabIndex = 2;
			this.txtXmin.Text = "-1";
			// 
			// txtXmax
			// 
			this.txtXmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtXmax.Location = new System.Drawing.Point(794, 38);
			this.txtXmax.Name = "txtXmax";
			this.txtXmax.Size = new System.Drawing.Size(100, 20);
			this.txtXmax.TabIndex = 2;
			this.txtXmax.Text = "3";
			// 
			// txtYmin
			// 
			this.txtYmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtYmin.Location = new System.Drawing.Point(794, 64);
			this.txtYmin.Name = "txtYmin";
			this.txtYmin.Size = new System.Drawing.Size(100, 20);
			this.txtYmin.TabIndex = 2;
			this.txtYmin.Text = "-3";
			// 
			// txtYmax
			// 
			this.txtYmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtYmax.Location = new System.Drawing.Point(794, 90);
			this.txtYmax.Name = "txtYmax";
			this.txtYmax.Size = new System.Drawing.Size(100, 20);
			this.txtYmax.TabIndex = 2;
			this.txtYmax.Text = "5";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(768, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "X1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(768, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "X2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(768, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Y1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(768, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Y2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtYmax);
			this.Controls.Add(this.txtYmin);
			this.Controls.Add(this.txtXmax);
			this.Controls.Add(this.txtXmin);
			this.Controls.Add(this.picGraph);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox picGraph;
		private System.Windows.Forms.TextBox txtXmin;
		private System.Windows.Forms.TextBox txtXmax;
		private System.Windows.Forms.TextBox txtYmin;
		private System.Windows.Forms.TextBox txtYmax;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

