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
			// 지금 시간을 받아와 스트링으로 정리한다.
			DateTime nowDatetime = GetNowDatetime();
			string[] nowdt = nowDatetime.ToString("yyyy.MM.dd HH:mm:ss").Split(new string[] {" "}, StringSplitOptions.None);
			
			List<string> atList = Config.ALAM_TIME_LIST;
			for (int i = 0; i < atList.Count; i++)
			{
				// 날짜 형식으로 전환 뒤 날짜 / 오전 오후 / 시간 으로 분리
				DateTime dtOri = Convert.ToDateTime(atList[i]);
				string[] dt = dtOri.ToString("yyyy.MM.dd HH:mm:ss").Split(new string[] {" "}, StringSplitOptions.None);

				// 앞뒤 공배제거
				//for (int  j = 0;  j < dt.Length;  j++)
				//{
				//	dt[j].Trim();
				//}

				// 날짜 시간 비교
				if (dt[0] == nowdt[0])
				{
					TimeSpan timeDiff = Convert.ToDateTime(dt[1]) - Convert.ToDateTime(nowdt[1]);

					double diffSecond = timeDiff.TotalSeconds;
					Console.WriteLine(diffSecond);

					if (diffSecond == Config.ALAM_BEFORE_SECOND)
					{
						functions.AlamTost();
						functions.AlamSound();
					}
				}


			}
		}

		DateTime GetNowDatetime()
		{
			return DateTime.Now;
		}
	}
}
