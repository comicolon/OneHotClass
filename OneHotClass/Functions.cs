using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace OneHotClass
{
	public class Functions : InstanceManager
	{
		public void Login (string email, string password)
		{
			// 1) Create Process Info
			var psi = new ProcessStartInfo();
			psi.FileName = @"C:\Users\comic\AppData\Local\Programs\Python\Python39\python.exe";

			// 2) Provide script and arguments
			string currentPath = Environment.CurrentDirectory;
			Console.WriteLine(currentPath);
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

			Console.WriteLine(linkInEmail);
			OpenCodeStates(2, linkInEmail);
		}

		//암호화된 utf-8 형식을 복호화 해준다
		public static string UnescapeHex(string data)
		{
			return Encoding.UTF8.GetString(Array.ConvertAll(Regex.Unescape(data).ToCharArray(), c => (byte)c));
		}

		// 코드 스페이츠 홈페이지 열기 1스탭은 처음 로그인 2스탭은 이메일 링크
		internal void OpenCodeStates(int step, string link = "")
		{
			if (step == 1 && link == "")
			{
				System.Diagnostics.Process.Start("https://urclass.codestates.com/login");
			}
			else if (step == 2 && link != "")
			{
				System.Diagnostics.Process.Start(link);
			}
		}
	}
}