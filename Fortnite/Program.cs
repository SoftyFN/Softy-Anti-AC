using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace AntiAC
{
	// Token: 0x02000003 RID: 3
	internal class Program
	{
		// Token: 0x0600000E RID: 14
		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
		public static extern int MessageBox(IntPtr h, string m, string c, int type);

		// Token: 0x0600000F RID: 15 RVA: 0x00002190 File Offset: 0x00000390
		private static void Main(string[] args)
		{
			Console.Title = "SoftyFN";
			string str = string.Empty;
			string text = string.Empty;
			foreach (string text2 in args)
			{
				bool flag = text2.Contains("-epicusername=");
				bool flag2 = flag;
				bool flag3 = flag2;
				if (flag3)
				{
					str = text2.Replace("-epicusername=", "");
				}
				text = text + text2 + " ";
			}
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\n[SERVER] Bienvenido a SoftyFN, " + str);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("\n[SERVER] CREADOR DEL SERVER: HUGOFASTT.");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n[SERVER] CO-OWNER: LuciferLOVE KIRA.");
			Console.WriteLine("\n");
			Process process = Process.Start("FortniteClient-Win64-Shipping.exe", text);
			Program.MessageBox((IntPtr)0, "PRESIONA ACEPTAR EN EL SELECTOR DE MODOS", "SoftyFN INJECTOR", 0);
			ProcessHelper.InjectDll(process.Id, Path.Combine(Directory.GetCurrentDirectory(), "SoftyFN.dll"));
			Process.Start("https://discord.io/SoftyFN");
			Console.Read();
			
			process.WaitForExit();
			var Proc = new ProcessStartInfo();
			Proc.CreateNoWindow = true;
			Proc.FileName = "cmd.exe";
			Proc.Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=verify";
			Process.Start(Proc);

		}
	}
}
