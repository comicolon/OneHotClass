using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHotClass
{
	public class Config : InstanceManager
	{
		public static string VERSION = "0.1.36";     // 버전

		//계정
		public static string LOGIN_EMAIL = "";
		public static string PASSWORD = "";
		public static int PRE_LOGIN_MAIL_SERVER = 2;					// 1. 카카오 2.구글

		//필드값
		public static string CALENDAR_WORD = "itssothatso@gmail.com";				// 달력 중에서 검색어
		public static List<string> ALAM_WORD_LIST = new List<string>(); // 달력 안에서 알람 리스트
		public static string ALAM_WORD1 = "Q&A";
		public static string ALAM_WORD2 = "";
		public static string ALAM_WORD3 = "";
		public static string ALAM_WORD4 = "";
		public static List<Dictionary<string, string>> SCHEDULE_LIST = new List<Dictionary<string, string>>();	// 일정 리스트 리스트
		public static List<string> ALAM_TIME_LIST = new List<string>(); // 알람 타임 리스트
		public static int ALAM_BEFORE_MIN = 5;
		
		public static bool IS_CHAIN_LOGIN = false;						// 연속 로그인을 할지 여부

		public static string PYTHON_PATH = @"C:\Users\comic\AppData\Local\Programs\Python\Python39\python.exe";			// 파이썬 파일 위치

	}
}
