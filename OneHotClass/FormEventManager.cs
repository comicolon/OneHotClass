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
			//버튼
			mainForm.button_codestates.Click += Button_Click;
			mainForm.button_login.Click += Button_Click;
			mainForm.button_preLoginKakao.Click += Button_Click;
			mainForm.button_preLoginGoogle.Click += Button_Click;
			mainForm.button_2ndLogin.Click += Button_Click;
			mainForm.button_logout.Click += Button_Click;
			mainForm.button_getSchedule.Click += Button_Click;
			mainForm.button_zoomLink.Click += Button_Click;

			mainForm.checkBox_chainLogin.CheckedChanged += Checkbox_Check;
		}

		public void Checkbox_Check(object sender, EventArgs e)
		{
			if (mainForm.checkBox_chainLogin.Checked == true)
			{
				Config.IS_CHAIN_LOGIN = true;
			}
			else if (mainForm.checkBox_chainLogin.Checked == false)
			{
				Config.IS_CHAIN_LOGIN = false;
			}
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
			if (sender.Equals(mainForm.button_logout))
			{
				functions.logOut();
			}
			if (sender.Equals(mainForm.button_getSchedule))
			{
				functions.GetSchedule();
			}
			if (sender.Equals(mainForm.button_zoomLink))
			{
				functions.OpenZoom();
			}

			// 1차 로그인 카카오
			if (sender.Equals(mainForm.button_preLoginKakao))
			{
				Config.PRE_LOGIN_MAIL_SERVER = 1;
			}
			// 1차 로그인 구글
			if (sender.Equals(mainForm.button_preLoginGoogle))
			{
				Config.PRE_LOGIN_MAIL_SERVER = 2;
			}
		}
	}
}