using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using Weapons;
using System.Speech.Synthesis;

namespace Houdini
{
    class Script
    {

		[DllImport("Kernel32.dll")]
		public static extern bool QueryPerformanceFrequency(out long lpFrequency);

		[DllImport("Kernel32.dll")]
		public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

		[DllImport("User32.dll")]
		public static extern short GetAsyncKeyState(int VK);

		public static void TTS(string toSpeak)
		{
			new Thread(delegate ()
			{
				Thread.CurrentThread.IsBackground = true;
				using (SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer())
				{
					speechSynthesizer.Volume = 60;
					speechSynthesizer.Speak(toSpeak);
					speechSynthesizer.Dispose();
				}
			}).Start();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000B630 File Offset: 0x00009830
		public static void QuerySleep(int ms)
		{
			long num;
			Script.QueryPerformanceFrequency(out num);
			num /= 1000L;
			long num2;
			Script.QueryPerformanceCounter(out num2);
			long num3 = num2 / num + (long)ms;
			for (num2 = 0L; num2 < num3; num2 /= num)
			{
				Script.QueryPerformanceCounter(out num2);
			}
		}
		public static double Randomize(float val, int randomnes)
		{
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			byte[] array = new byte[4];
			if (randomnes == 0)
			{
				return val;
			}
			rngcryptoServiceProvider.GetBytes(array);
			return (float)((int)Math.Round((double)((float)((BitConverter.ToInt32(array, 0) - 1073741823) / 100000000 * randomnes / 16)))) + val;
		}

		public static int scopeToInt()
        {
			if (DaBabyware.scope=="HANDMADE")
            {
				return 4;
            }
			if (DaBabyware.scope == "HOLOSIGHT")
            {
				return 1;
            }
			if (DaBabyware.scope == "8X")
			{
				return 2;
			}
			if (DaBabyware.scope == "16X")
			{
				return 3;
			}
			else
            {
				return -1;
            }
		}

        public static double getScope(double val)
		{
			if (scopeToInt() == 1)
				return val * 1.18605;
			if (scopeToInt() == 2)
				return val * 3.83721;
			if (scopeToInt() == 3)
				return val * 7.65116;
			if (scopeToInt() == 4)
				return val * .8;
			return val;
		}

		public static int weaponToInt(string w)
        {
			if (w == "AK47")
            {
				return 0;
			}
			if (w == "THOMPSON")
			{
				return 1;
			}
			if (w == "CUSTOM")
			{
				return 2;
			}
			if (w == "LR-300")
			{
				return 3;
			}
			if (w == "MP5")
			{
				return 4;
			}
			if (w == "M249")
			{
				return 5;
			} else
            {
				return -1;
            }
		}
		public static double tofovandsens(double sens, int fov, double val, int currentscope, int currentbarrel)
		{
			double a = (0.5 * fov * val) / (sens * 90);
			return getScope(a);
		}

		public static double tofovandsensBLATANT(double sens, int fov, double val)
		{
			double a = (0.5 * fov * val) / (sens * 90);
			return getScope(a);
		}

		public static int barrelToInt()
        {
			if (DaBabyware.attachment == "SURPRESSOR")
            {
				return 2;
            } else if (DaBabyware.attachment == "NONE")
            {
				return 0;
            } else
            {
				return -1;
            }
        }

		public static void Smoothing(double delay, double control_time, double x, double y)
		{
			int num = (int)delay - (int)control_time;
			control_time += (double)num;
			int num2 = 0;
			int num3 = 0;
			double num4 = 0.0;
			for (int i = 1; i <= (int)Math.Round(control_time); i++)
			{
				int num5 = i * (int)Math.Round((double)x) / (int)Math.Round(control_time);
				int num6 = i * (int)Math.Round((double)y) / (int)Math.Round(control_time);
				double num7 = (double)i * control_time / control_time;
				Mouse.mouse_move(num5 - num2, num6 - num3);
				Script.QuerySleep((int)Math.Floor(num7 - num4));
				num2 = num5;
				num3 = num6;
				num4 = num7;
			}

		}

		public static void Blatant(double delay, double control_time, double x, double y)
		{
			int x_ = 0, y_ = 0, t_ = 0;
			for (int i = 1; i <= (int)control_time; ++i)
			{
				double xI = i * x / control_time;
				double yI = i * y / (int)control_time;
				int tI = i * (int)control_time / (int)control_time;
				int xX = (int)xI - (int)x_;
				int yY = (int)yI - (int)y_;
				/*if (nosc)
				{
					xX = xX * 1.1;
					yY = yY * 1.1;
				}*/
				Mouse.mouse_move(xX, yY);
				QuerySleep((int)tI - (int)t_);
				x_ = (int)xI; y_ = (int)yI; t_ = tI;
			}
			QuerySleep((int)delay - (int)control_time);

		}

	}
}
