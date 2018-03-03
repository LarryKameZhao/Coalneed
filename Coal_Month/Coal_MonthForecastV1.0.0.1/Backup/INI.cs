using System;
using System.Runtime.InteropServices;


namespace MyControl
{

//	Private Declare Function GetPrivateProfileString Lib "kernel32" Alias _
//	"GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal _
//	lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString _
//	As String, ByVal nSize As Long, ByVal lpFileName As String) As Long


	/// <summary>
	/// READINI 的摘要说明。
	/// </summary>
	public class INI
	{

		//引用动态连接库方法
		[DllImport("kernel32")]
		public static extern long WritePrivateProfileString(string section,string key,string val,string filePath);
		[DllImport("kernel32")]
		public static extern int GetPrivateProfileString(string section,string key,string def, System.Text.StringBuilder retVal,int size,string filePath);
		
		public static int GetPrivateProfileString (string section,string key,string def,ref string res,string filePath)
		{
			System.Text.StringBuilder temp = new System.Text.StringBuilder(255);
			int ires = GetPrivateProfileString(section,key,def,temp,255,filePath);

			res = temp.ToString();

			return ires;
		}

	}
}
