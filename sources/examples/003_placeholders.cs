/*
	Coded on : 15/02/2017
	Aim      : To understand the use of placeholders in Writer functions.
	Coded by : Rishikesh Agrawani.
*/
using System;
namespace PlacholderApplication{
	class ReaderWriter{
		void Reader()
		{
			string fname, lname;
			Console.Write(">>> Enter your firstname:\t");
			fname = Console.ReadLine();
			Console.Write(">>> Enter your lastname:\t");
			lname = Console.ReadLine();

			ReaderWriter.Writer(fname,lname); //Writer is static, so we can call it using class name
		}

		static void Writer(string firstname,String lastname)
		{
			Console.WriteLine("... Your name is {0} {1}",firstname,lastname);
		}

		static void Main() //Main(String[] cmdArgs ...is optional 
		{
			ReaderWriter obj = new ReaderWriter(); //Instantiation
			obj.Reader(); //Reader() is not a static, so object is required to call it
		}
	}
} 

/*
admins-MacBook-Pro-3:examples admin$ mcs -out:../../mac-executables/placeholders 003_placeholders.cs 
admins-MacBook-Pro-3:examples admin$ mono ../../mac-executables/placeholders 
>>> Enter your firstname:	Rishikesh
>>> Enter your lastname:	Agrawani
... Your name is Rishikesh Agrawani
*/