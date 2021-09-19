using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace OneHotClass
{
	public class Functions : InstanceManager
	{
		//로그인 처리
		public void Login (string email, string password)
		{
			// 1) Create Process Info
			var psi = new ProcessStartInfo();
			//psi.FileName = @"C:\Users\comic\AppData\Local\Programs\Python\Python39\python.exe";
			psi.FileName = @mainForm.textBox_pythonPath.Text;
			//Console.WriteLine(psi.FileName);

			// 2) Provide script and arguments
			string currentPath = Environment.CurrentDirectory;
			//Console.WriteLine(currentPath);
			var script = currentPath + @"\login.py";

			psi.Arguments = $"\"{script}\" \"{email}\" \"{password}\"";

			// 3) Process configuration
			psi.UseShellExecute = false;
			psi.CreateNoWindow = false;
			psi.RedirectStandardOutput = true;
			psi.RedirectStandardError = true;

			// 4) Excute process and get output
			var errors = "";
			var results = "";

			using (var process = Process.Start(psi))
			{
				errors = process.StandardOutput.ReadToEnd();
				results = process.StandardOutput.ReadToEnd();
			}

			// 5) Display Output 
			Console.WriteLine("errors");
			Console.WriteLine(errors);
			Console.WriteLine();
			Console.WriteLine("results");
			Console.WriteLine(results);

			//---------------------------------------------------------------
			// 인코딩된 바이트를 받아와서 디코딩

			var getResult = errors;

			Console.WriteLine(getResult);

			var content = UnescapeHex(getResult);

			Console.WriteLine(content);

			string linkInEmail = "";
			bool isLink = false;
			for (int i = 0; i < content.Length; i++)
			{
				if (content[i].ToString() == "<")
				{
					isLink = true;
					continue;
				}
				else if (content[i].ToString() == ">")
				{
					isLink = false;
					break;
				}

				if (isLink == true)
				{
					linkInEmail += content[i].ToString();
				}
			}

			OpenCodeStates(3, linkInEmail);
		}


		//암호화된 utf-8 형식을 복호화 해준다
		public static string UnescapeHex(string data)
		{
			return Encoding.UTF8.GetString(Array.ConvertAll(Regex.Unescape(data).ToCharArray(), c => (byte)c));
		}

		internal void PreLogin()
		{
			if (Config.PRE_LOGIN_MAIL_SERVER == 1)
			{
				OpenCodeStates(21);
			}
			else if (Config.PRE_LOGIN_MAIL_SERVER == 2)
			{
				OpenCodeStates(22);
			}

			//체인 로그인이 활성화 되어있다면
			if (Config.IS_CHAIN_LOGIN == true)
			{
				Thread.Sleep(2000);
				Login(mainForm.textBox_email.Text, mainForm.textBox_password.Text);
			}
		}

		// 코드 스페이츠 홈페이지 열기 1스탭은 처음 로그인 2스탭은 이메일 링크
		internal void OpenCodeStates(int step, string link = "")
		{
			if (step == 1 && link == "")
			{
				System.Diagnostics.Process.Start("https://urclass.codestates.com");
			}
			else if (step == 21 && link == "")
			{
				System.Diagnostics.Process.Start("https://accounts.kakao.com/login?continue=https%3A%2F%2Fkauth.kakao.com%2Foauth%2Fauthorize%3Fresponse_type%3Dcode%26redirect_uri%3Dhttps%253A%252F%252Furclass.codestates.com%252Fauth%253Fsocial_provider%253Dkakao%26client_id%3D43984033602adcda52af84344f1daa74");
			}
			else if (step == 22 && link == "")
			{
				System.Diagnostics.Process.Start("https://accounts.google.com/o/oauth2/v2/auth/oauthchooseaccount?response_type=code&scope=profile%20email&redirect_uri=https%3A%2F%2Furclass.codestates.com%2Fauth%3Fsocial_provider%3Dgoogle&propmt=consent&client_id=430860350629-p0iei83mun2uhg4ma0be52qbv8p97k8e.apps.googleusercontent.com&flowName=GeneralOAuthFlow");
			}
			else if (step == 3 && link != "")
			{
				System.Diagnostics.Process.Start(link);
			}
		}

		internal void GetSchedule()
		{
			GoogleCalenda.getSchedule();
		}

		// 줌 링크를 열어준다.
		internal void OpenZoom()
		{
			if (GoogleCalenda.zoomLink != null)
			{
				System.Diagnostics.Process.Start(GoogleCalenda.zoomLink);
			}
			else
			{
				MessageBox.Show("일정표를 먼저 불러오세요.");
			}
		}
		internal void logOut()
		{
			System.Diagnostics.Process.Start("https://urclass.codestates.com");

		}
	}
}