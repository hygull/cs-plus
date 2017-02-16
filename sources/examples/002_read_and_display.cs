/*
	Coded on : 15/02/2017
	Aim      : To print hello world message onto the console after taking i/p from keyboard.
	Coded by : Rishikesh Agrawani.
*/
using System;

namespace ReadWriteApplication{
	class ReadShow{
		//Take input
		static void ReadInput(){	//if void ReadInput()...002_read_and_display.cs(27,4): error CS0120: An object reference is required to access non-static member `ReadWriteApplication.ReadShow.ReadInput()'
			string name;
			Console.Write("What is your name : ");
			name = Console.ReadLine(); //ReadKey() produces error
			ShowName(name); //ReadShow.ShowName(name);...ok here(for static methods)
		}

		//Show input data
		static void ShowName(string name)
		{
			Console.WriteLine("Oh!!! you are "+name+'.'); //Console.WriteLine("Oh!!! you are ",name); ...not ok.Just check it
		}

		//Driver program
		static void Main(string[] cmdArgs)
		{
			ReadInput(); //ReadShow.ReadInput(); is also ok
		}
	}
}
