using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace myFitTimer
{
	class MyFitTimerTracker
	{
		public Stopwatch stopWatch;

		public MyFitTimerTracker()
		{
			stopWatch = new Stopwatch();
			
		}
		public void start()
		{
			stopWatch.Start();
		}
		public void stop()
		{
			stopWatch.Stop();
		}
		public void clear()
		{
			stopWatch.Reset();
		}
		public string Elapsed() {

			return stopWatch.Elapsed.ToString(@"hh\:mm\:ss");


		}
		public bool isRunning()
		{
			return stopWatch.IsRunning;
		}
	
		
	}
}
