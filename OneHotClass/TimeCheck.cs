using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace OneHotClass
{
	public class TimeCheck : InstanceManager
	{
		bool isAlamed = false;

		internal TimeCheck()
		{
			Timer timer = new Timer();
			timer.Interval = 1000;
			timer.Elapsed += new ElapsedEventHandler(CheckAlamTime);
			timer.Start();
		}

		private void CheckAlamTime(object sender, ElapsedEventArgs e)
		{
			DateTime nowDatetime = GetNowDatetime();
			List<string> atList = Config.ALAM_TIME_LIST;
			for (int i = 0; i < atList.Count; i++)
			{
				Console.WriteLine(atList[i]);
			}
		}

		DateTime GetNowDatetime()
		{
			return DateTime.Now;
		}
	}
}
