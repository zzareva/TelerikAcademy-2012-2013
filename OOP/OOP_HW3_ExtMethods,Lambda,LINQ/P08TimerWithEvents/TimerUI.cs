using System;
using System.Linq;

namespace P08TimerWithEvents
{
	class TimerUI
	{
		static void Main()
		{
			Timer execute = new Timer();
			execute.Tick += SampleMethod;
			execute.Tick += SampleMethod2;
			execute.StartTimer(2000);

			Console.WriteLine("Press the Enter key to exit the program.");
			Console.ReadLine();
		}
		public static void SampleMethod(object sender, EventArgs e)
		{
			Console.Write(DateTime.Now);
		}
		public static void SampleMethod2(object sender, EventArgs e)
		{
			Console.WriteLine();
		}
	}
}
