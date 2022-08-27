using System;
namespace Csharp1
{
	struct Book/*结构体*/
	{
		public string writer;
		public int age;
		public void display()
		{
			Console.WriteLine("Hello!");
		}
	}
	enum Week
	{
		M,T,W,Th,F,S,Su
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			
		//字符串，字符串连接
          	string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
        	Console.WriteLine("Greetings: {0}", greetings);

            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

           //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}",waiting);
            Console.WriteLine("Message: {0}\n", chat);
			Book book;
			book.writer = "Tan";
			book.age = 14;
			book.display();
			Console.WriteLine((int)Week.W);	
			Console.ReadKey ();
		}
	}
}
