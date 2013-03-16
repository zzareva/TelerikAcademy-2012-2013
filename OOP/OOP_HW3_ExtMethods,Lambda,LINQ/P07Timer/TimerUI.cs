//P07 Using delegates write a class Timer that can execute certain method at each t seconds.

using System;
using System.Linq;

namespace P07Timer
{
	class TimerUI
	{
		static void Main()
		{
			Timer.Execute(() => Console.WriteLine(DateTime.Now), 2);
		}
	}
}
