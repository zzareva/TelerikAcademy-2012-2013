using System;
using System.Linq;
using System.Timers;

namespace P08TimerWithEvents
{
	public class Timer
	{
		private readonly System.Timers.Timer timer = new System.Timers.Timer();

		public void StartTimer(int seconds)
		{
			timer.Elapsed += new ElapsedEventHandler(TimedEvent);
			timer.Interval = seconds;
			timer.Enabled = true;
			timer.Start();
		}
		public void TimedEvent(object sourse, ElapsedEventArgs e)
		{
			OnTick(EventArgs.Empty);
		}
  
		private void OnTick(EventArgs e)
		{
			if (Tick != null)
				Tick(this,e);
		}

		public event EventHandler Tick;
	}

}
