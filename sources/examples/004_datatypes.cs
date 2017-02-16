/*
	Coded on : 16/02/2017
	Aim      : To use the variables of different datat types in C#.
	Coded by : Rishikesh Agrawani.
*/
using System;
namespace DataAppplication
{
	class Data
	{
		void UseVariables() //static ... not Ok ... as we are accessing this method using instance.
		{
		/* 	1)Value types:-	*/
			//numbers
			byte b;
			int i;
			short s;
			long l;
			decimal d;
			sbyte sb;
			uint ui;
			ushort us;
			ulong ul;

			double doub;
			float f;

			//character
			char c;

			//boolean
			bool boolean;

		/* 	2)Reference types:-	*/
			object num; //object type
			num = 100;

			dynamic dyn1 = 20; //dynamic type
			dynamic dyn2 = 'H'; //dynamic type

			String s1 = "Lohansa Perry"; //string type
			string s2 = "Hemkesh Agrawani"; //string type
			string s3 = @"Quoted string"; //Quoted string

		/* 	2)Pointer types:-	*/
			// unsafe
			// {
			// 	int *p;
			// 	p = &i;
			// }

		//Assigning values to variables of Value types
			b = 255; 	//0 to 255 (8 bit)
			i = 23;  	//-2,147,483,648 to 2,147,483,647
			s = 32767; 	//-32,768 to 32,767
			l = 45125; 	//-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
			d = 12.05m; //...Search it
			sb = -128;  //-128 to 127
			ui = 45345; //0 to 4,294,967,295
			ul = 65656; //0 to 18,446,744,073,709,551,615
			us = 43234; //0 to 65,535; 

			doub = 345.434; 
			f    = 342.211f;

			c = 'M'; //unicode character (16 bit)
			boolean = true;

		//Displaying values stored in variables
		Console.WriteLine(i);
		Console.WriteLine(b); 
		Console.WriteLine(s);
		Console.WriteLine(l); 
		Console.WriteLine(d);
		Console.WriteLine(sb); 
		Console.WriteLine(ui);
		Console.WriteLine(ul); 
		Console.WriteLine(us);
		Console.WriteLine(doub); 
		Console.WriteLine(f);
		Console.WriteLine(c); 
		Console.WriteLine(boolean); 
		Console.WriteLine(s1);
		Console.WriteLine(s2);
		Console.WriteLine(s3);   
		Console.WriteLine(dyn2);
		Console.WriteLine(dyn1);  
		Console.WriteLine(num);
		}

		static void Main(String[] cmdArgs)
		{
			Data d = new Data();
			d.UseVariables();
		}
	}
}