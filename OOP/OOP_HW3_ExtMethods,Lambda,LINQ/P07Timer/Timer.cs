using System;
using System.Linq;
using System.Threading;
using System.Timers;

namespace P07Timer
{
	public static class Timer
	{
		public static void Execute(Action action, int seconds)
		{
			while (true)
			{
				Thread.Sleep(seconds * 1000);
				action();
			}
		}
	}
}
