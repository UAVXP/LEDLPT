using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace LPTPort1
{
	class InpOut
	{
		[DllImport("inpout32.dll")]
		private static extern UInt32 IsInpOutDriverOpen();
		[DllImport("inpout32.dll")]
		private static extern void Out32(short PortAddress, short Data);
		[DllImport("inpout32.dll")]
		private static extern char Inp32(short PortAddress);

		[DllImport("inpout32.dll")]
		private static extern void DlPortWritePortUshort(short PortAddress, ushort Data);
		[DllImport("inpout32.dll")]
		private static extern ushort DlPortReadPortUshort(short PortAddress);

		[DllImport("inpout32.dll")]
		private static extern void DlPortWritePortUlong(int PortAddress, uint Data);
		[DllImport("inpout32.dll")]
		private static extern uint DlPortReadPortUlong(int PortAddress);

		[DllImport("inpoutx64.dll")]
		private static extern bool GetPhysLong(ref int PortAddress, ref uint Data);
		[DllImport("inpoutx64.dll")]
		private static extern bool SetPhysLong(ref int PortAddress, ref uint Data);


		[DllImport("inpoutx64.dll", EntryPoint = "IsInpOutDriverOpen")]
		private static extern UInt32 IsInpOutDriverOpen_x64();
		[DllImport("inpoutx64.dll", EntryPoint = "Out32")]
		private static extern void Out32_x64(short PortAddress, short Data);
		[DllImport("inpoutx64.dll", EntryPoint = "Inp32")]
		private static extern char Inp32_x64(short PortAddress);

		[DllImport("inpoutx64.dll", EntryPoint = "DlPortWritePortUshort")]
		private static extern void DlPortWritePortUshort_x64(short PortAddress, ushort Data);
		[DllImport("inpoutx64.dll", EntryPoint = "DlPortReadPortUshort")]
		private static extern ushort DlPortReadPortUshort_x64(short PortAddress);

		[DllImport("inpoutx64.dll", EntryPoint = "DlPortWritePortUlong")]
		private static extern void DlPortWritePortUlong_x64(int PortAddress, uint Data);
		[DllImport("inpoutx64.dll", EntryPoint = "DlPortReadPortUlong")]
		private static extern uint DlPortReadPortUlong_x64(int PortAddress);

		[DllImport("inpoutx64.dll", EntryPoint = "GetPhysLong")]
		private static extern bool GetPhysLong_x64(ref int PortAddress, ref uint Data);
		[DllImport("inpoutx64.dll", EntryPoint = "SetPhysLong")]
		private static extern bool SetPhysLong_x64(ref int PortAddress, ref uint Data);

		bool m_bX64 = false;

		public InpOut()
		{
			try
			{
				uint nResult = 0;
				try
				{
					nResult = IsInpOutDriverOpen();
				}
				catch (BadImageFormatException)
				{
					nResult = IsInpOutDriverOpen_x64();
					if (nResult != 0)
						m_bX64 = true;

				}

				if (nResult == 0)
				{
					Console.WriteLine("Unable to open InpOut32 driver");
				}
			}
			catch (DllNotFoundException ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
				Console.WriteLine("Unable to find InpOut32.dll");
			}
		}

		public void Out(short PortAddress, short Data)
		{
			if (m_bX64)
				Out32_x64(PortAddress, Data);
			else
				Out32(PortAddress, Data);
		}
	}
}
