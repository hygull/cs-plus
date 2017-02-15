/*
	Coded on : 15/02/2017
	Aim      : To print hello world message onto the console.
	Coded by : Rishikesh Agrawani.
*/

using System;
namespace WelcomeApplication
{
	class Hello
	{
		public static void Main(string[] cmdArgs) //string is an alias in C# for System.String. So technically, there is no difference. It's like int vs. System.Int32.
		{
			Console.WriteLine("Hello C# programmers!!!");
			Console.Write("Is it true that ");
			Console.Write("C# is a part of the .NET framework.");
			Console.WriteLine();
		}
	}
}