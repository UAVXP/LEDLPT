using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;
using NAudio;
using NAudio.CoreAudioApi;

namespace LPTPort1
{
	public partial class Form1 : Form
	{
		System.Threading.Thread t;
		public Form1()
		{
			InitializeComponent();
			t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadTest));
		}

		InpOut io = new InpOut();
		enum Pins { Pin1 = 2, Pin2 = 4, Pin3 = 8, Pin4 = 16, Pin5 = 32, Pin6 = 64, Pin7 = 128, Pin8 = 256 };
		enum LightCond { NONE, Red, Green, Blue, RedGreen, RedBlue, GreenBlue };

		byte flags = (byte)Pins.Pin1;

		private void LightLED()
		{
			/*	short data = 0;
				switch (lc)
				{
					case LightCond.NONE:
						data = 0;
						break;
					case LightCond.Red:
						data = 16;
						break;
					case LightCond.Green:
						data = 8;
						break;
					case LightCond.Blue:
						data = 4;
						break;
					case LightCond.RedGreen:
						data = 16+8;
						break;
					case LightCond.RedBlue:
						data = 16+4;
						break;
					case LightCond.GreenBlue:
						data = 8+4;
						break;
				}*/
			io.Out(888, flags);
		}
	//	public void LightLED( byte fl )
	//	{
	//		flags = fl;
	//		LightLED();
	//	}

		//private void checkBox1_CheckedChanged(object sender, EventArgs e)
		//{
		//    if ((sender as CheckBox).Checked)
		//        flags |= (byte)Pins.Pin1;
		//    else
		//        flags -= (byte)Pins.Pin1;
		//    LightLED();
		//}
		
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
			//	if (t.IsAlive || t.IsBackground || t.IsThreadPoolThread)
					t.Abort();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			flags = 0;
			LightLED();
			Environment.Exit(0);
		}

		private void ThreadTest()
		{
			int sleep = Convert.ToInt32((textBox2.Text != "") ? textBox2.Text : "0");
			string text = textBox1.Text;
			int len = text.Length;
			while (true)
			{
			/*	flags |= (byte)Pins.Pin1;
				LightLED();
				System.Threading.Thread.Sleep(sleep);
				flags -= (byte)Pins.Pin1;
				LightLED();
				System.Threading.Thread.Sleep(sleep);
				flags |= (byte)Pins.Pin2;
				LightLED();
				System.Threading.Thread.Sleep(sleep);
				flags -= (byte)Pins.Pin2;
				LightLED();
				System.Threading.Thread.Sleep(sleep);
				flags |= (byte)Pins.Pin3;
				LightLED();
				System.Threading.Thread.Sleep(sleep);
				flags -= (byte)Pins.Pin3;
				LightLED();
				System.Threading.Thread.Sleep(sleep);*/
				for (int i = 0; i < len; i++)
				{
					byte flag = 0;
					switch (text[i])
					{
						case '0':
							flags = 0;
							break;
						case '1':
							flag |= (byte)Pins.Pin1;
							break;
						case '2':
							flag |= (byte)Pins.Pin2;
							break;
						case '3':
							flag |= (byte)Pins.Pin3;
							break;
						case '4':
							flag |= (byte)Pins.Pin1 + (byte)Pins.Pin2;
							break;
						case '5':
							flag |= (byte)Pins.Pin1 + (byte)Pins.Pin3;
							break;
						case '6':
							flag |= (byte)Pins.Pin2 + (byte)Pins.Pin3;
							break;
					}
					flags = flag;
					LightLED();
					if( t.IsAlive )
						System.Threading.Thread.Sleep(sleep);
					flags -= flag;
					LightLED();
				}
			}
		}
		void RestartThread()
		{
			try
			{
				if (t.IsAlive)
				{
					t.Abort();
					t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadTest));
				}
				t.Start();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			RestartThread();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			t.Abort();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			button1_Click(sender, e);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			button1_Click(sender, e);
		}

		public static int Clamp(int val, int min, int max)
		{
			if (val.CompareTo(min) < 0) return min;
			else if (val.CompareTo(max) > 0) return max;
			else return val;
		}
		private void SetVolumeBarLevel(int level)
		{
			level = Clamp(level, 0, 100);
			progressBar1.Value = level;
			label3.Text = level.ToString();

			if (level < 1)
			{
				flags = 0;
				LightLED();
			}
			if (level > 1 && level <= 10)
			{
				flags = 0;
				LightLED();
				flags |= (byte)Pins.Pin3;
			}
			else if (level > 10 && level <= 25)
			{
				flags = 0;
				LightLED();
			//	flags |= (byte)Pins.Pin2;
				flags |= (byte)Pins.Pin3 + (byte)Pins.Pin2;
			}
			else if (level > 25 && level <= 50)
			{
				flags = 0;
				LightLED();
			//	flags |= (byte)Pins.Pin1;
				flags |= (byte)Pins.Pin3 + (byte)Pins.Pin2 + (byte)Pins.Pin1;
			}
			LightLED();
		}
	//	static MMDeviceEnumerator de = new MMDeviceEnumerator();
		static MMDevice device;
		float mply = 1;
		private void timer1_Tick(object sender, EventArgs e)
		{
			float volume = (float)device.AudioMeterInformation.MasterPeakValue * 100 * mply;
			SetVolumeBarLevel((int)volume);
		}
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
			{
				MMDeviceEnumerator de = new MMDeviceEnumerator();
				device = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
				timer1.Start();
			}
			else
			{
				timer1.Stop();
				progressBar1.Value = 0;
				flags = 0;
				LightLED();
			}
		}
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			mply = (sender as TrackBar).Value;
			label4.Text = mply.ToString();
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
			{
			//	RestartThread();
			//	t.Interrupt();
			//	t.Start();
				if (t.IsAlive)
				{
					t.Resume();
					flags = 0;
					LightLED();
				}
				else
					t.Start();
			}
			else
			{
			//	t.Abort();
			//	t.Interrupt();
				if( t.IsAlive )
					t.Suspend();
				flags = 0;
				LightLED();
			}
		}
		
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
		        flags |= (byte)Pins.Pin1;
		    else
		        flags -= (byte)Pins.Pin1;
		    LightLED();
		}
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
				flags |= (byte)Pins.Pin2;
			else
				flags -= (byte)Pins.Pin2;
			LightLED();
		}
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
				flags |= (byte)Pins.Pin3;
			else
				flags -= (byte)Pins.Pin3;
			LightLED();
		}
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
				flags |= (byte)Pins.Pin4;
			else
				flags -= (byte)Pins.Pin4;
			LightLED();
		}
		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
				flags |= (byte)Pins.Pin5;
			else
				flags -= (byte)Pins.Pin5;
			LightLED();
		}
		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
				flags |= (byte)Pins.Pin6;
			else
				flags -= (byte)Pins.Pin6;
			LightLED();
		}
		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
				flags |= (byte)Pins.Pin7;
			else
				flags -= (byte)Pins.Pin7;
			LightLED();
		}
		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
				flags |= unchecked((byte)Pins.Pin8);
			else
				flags -= unchecked((byte)Pins.Pin8);
			LightLED();
		}
	}
}
