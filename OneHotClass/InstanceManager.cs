using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHotClass
{
	public class InstanceManager
	{
		public static MainForm mainForm = MainForm.mainForm;

		public static Config config = new Config();
		public static Functions functions = new Functions();

		public static FormEventManager formEventManager = new FormEventManager(); //폼 이벤트
	}
}
