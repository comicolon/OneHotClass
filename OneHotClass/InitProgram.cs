using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHotClass
{
	public class InitProgram : InstanceManager
	{
		public InitProgram()
		{
			//이메일 세팅
			if(Config.LOGIN_EMAIL != null)
			{
				mainForm.textBox_email.Text = Config.LOGIN_EMAIL;
			}

			// 비밀번호 세팅
			if(Config.PASSWORD != null)
			{
				mainForm.textBox_password.Text = Config.PASSWORD;
			}

			// 가져올 달력 검색어 세팅
			if(Config.CALENDAR_WORD != null)
			{
				mainForm.textBox_calendarWord.Text = Config.CALENDAR_WORD;
			}

			// 알람 글자 세팅
			Config.ALAM_WORD_LIST.Add(Config.ALAM_WORD1);
			Config.ALAM_WORD_LIST.Add(Config.ALAM_WORD2);
			Config.ALAM_WORD_LIST.Add(Config.ALAM_WORD3);
			Config.ALAM_WORD_LIST.Add(Config.ALAM_WORD4);

			if(Config.ALAM_WORD_LIST.Count() > 0)
			{
				mainForm.textBox_searchWord1.Text = Config.ALAM_WORD_LIST[0];
				mainForm.textBox_searchWord2.Text = Config.ALAM_WORD_LIST[1];
				mainForm.textBox_searchWord3.Text = Config.ALAM_WORD_LIST[2];
				mainForm.textBox_searchWord4.Text = Config.ALAM_WORD_LIST[3];
			}

			

		}


	}
}
