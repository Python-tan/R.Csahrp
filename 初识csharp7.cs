using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Csharp
{	
	class MainClass
	{
		public static void Main(string[] args)
		{
			string http = "s o sooooooooosj ooooooooooosdkhaksdhlsj";
			string rgx=@"(^o+j$)+";
			foreach (Match match in Regex.Matches(http,rgx))
			{
					Console.WriteLine(match.Value);		
			}
		}

	}
}
