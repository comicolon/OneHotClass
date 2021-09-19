using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHotClass
{
	public class FormEventManager : InstanceManager
	{
		public FormEventManager()
		{
			mainForm.button_codestates.Click += Button_Click;
			mainForm.button_login.Click += Button_Click;
			mainForm.button_2ndLogin.Click += Button_Click;
			mainForm.button_logout.Click += Button_Click;
			mainForm.button_getSchedule.Click += Button_Click;
			mainForm.button_zoomLink.Click += Button_Click;

		}

		private void Button_Click(object sender, EventArgs e)
		{
			if (sender.Equals(mainForm.button_login))
			{
				functions.PreLogin();
			}
			if (sender.Equals(mainForm.button_2ndLogin))
			{
				functions.Login(mainForm.textBox_email.Text, mainForm.textBox_password.Text);
			}
			if (sender.Equals(mainForm.button_codestates))
			{
				functions.OpenCodeStates(1);
			}
			if (sender.Equals(mainForm.button_getSchedule))
			{
				functions.GetSchedule();
			}
			if (sender.Equals(mainForm.button_zoomLink))
			{
				functions.OpenZoom();
			}

		}
	}
}