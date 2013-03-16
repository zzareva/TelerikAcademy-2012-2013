using System;
using System.Linq;
using GSMData.Base;

namespace GSMConsoleApplication
{
	class GSMTest
	{
		public static void RunGSMTest()
		{
			GSM[] test = new GSM[4];
			test[0] = new GSM("iPhone 3G", "Apple", 999) { Owner = "Ivan Ivanov" };
			test[1] = new GSM("5800 Music Express", "Nokia");
			test[2] = new GSM("HTC One", "HTC", 450, "Pencho Georgiev", new Battery("4A83P", 30, 10), new Display(4.57f, 16000000));
			test[2] = new GSM("S5830 Galaxy Ace", "Samsung", 290, new Battery("4A83P", 420, 6.5f), new Display(4.5f, 16000000));
			test[3] = new GSM("Lumia 900", "Nokia",700);

			for (int i = 1; i <= test.Length; i++)
			{
				Console.WriteLine("GSM Test #{0}:",i);
				Console.WriteLine(test[i-1].ToString());
			}
			Console.WriteLine("{0}:",GSM.IPhone4S.Model);
			Console.WriteLine(GSM.IPhone4S.ToString());
		}
	}
}
