namespace LPTPort1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Pattern:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(121, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Speed:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(124, 55);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "100";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(20, 42);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(244, 23);
			this.progressBar1.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(269, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "0";
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(20, 19);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(59, 17);
			this.checkBox5.TabIndex = 13;
			this.checkBox5.Text = "Enable";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(18, 55);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 14;
			this.textBox1.Text = "123";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(18, 19);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(59, 17);
			this.checkBox6.TabIndex = 15;
			this.checkBox6.Text = "Enable";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.AutoSize = false;
			this.trackBar1.Location = new System.Drawing.Point(18, 85);
			this.trackBar1.Maximum = 20;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(258, 24);
			this.trackBar1.TabIndex = 16;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(80, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(301, 115);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sound activation";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(274, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.checkBox6);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(80, 133);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(301, 84);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Patterns";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkBox10);
			this.groupBox3.Controls.Add(this.checkBox9);
			this.groupBox3.Controls.Add(this.checkBox8);
			this.groupBox3.Controls.Add(this.checkBox7);
			this.groupBox3.Controls.Add(this.checkBox4);
			this.groupBox3.Controls.Add(this.checkBox3);
			this.groupBox3.Controls.Add(this.checkBox2);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(62, 205);
			this.groupBox3.TabIndex = 19;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Pins";
			// 
			// checkBox10
			// 
			this.checkBox10.AutoSize = true;
			this.checkBox10.Location = new System.Drawing.Point(6, 180);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(50, 17);
			this.checkBox10.TabIndex = 28;
			this.checkBox10.Text = "Pin 8";
			this.checkBox10.UseVisualStyleBackColor = true;
			this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.Location = new System.Drawing.Point(6, 157);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(50, 17);
			this.checkBox9.TabIndex = 27;
			this.checkBox9.Text = "Pin 7";
			this.checkBox9.UseVisualStyleBackColor = true;
			this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Location = new System.Drawing.Point(6, 134);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(50, 17);
			this.checkBox8.TabIndex = 26;
			this.checkBox8.Text = "Pin 6";
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Location = new System.Drawing.Point(6, 111);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(50, 17);
			this.checkBox7.TabIndex = 25;
			this.checkBox7.Text = "Pin 5";
			this.checkBox7.UseVisualStyleBackColor = true;
			this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(6, 88);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(50, 17);
			this.checkBox4.TabIndex = 24;
			this.checkBox4.Text = "Pin 4";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(6, 65);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(50, 17);
			this.checkBox3.TabIndex = 23;
			this.checkBox3.Text = "Pin 3";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(6, 42);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(50, 17);
			this.checkBox2.TabIndex = 22;
			this.checkBox2.Text = "Pin 2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(6, 19);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(50, 17);
			this.checkBox1.TabIndex = 21;
			this.checkBox1.Text = "Pin 1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Gain";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 229);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Some shitload";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label5;
	}
}

