#define DE
using System;
using space1;
using space2;
namespace space1
{
    class func1
    {
        public void A()
        {
            Console.WriteLine("AAA");
        }
    }
}
namespace space2
{
    class func2
    {
		
		private readonly int a = 8;//readonly只能在构造函数或初始化时赋值
		public func2(int i)
		{
			a = 9;
			//a = i;

		}

        public void A()
        {
			Console.WriteLine("HHH{0}",a);
        }
    }
}
namespace MainSpace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			
           	func1 f1 = new func1();
            func2 f2 = new func2(2);
			func2 f3 = new func2 (3);
			#if (DE)
            f1.A();
			f2.A();
			f3.A();
			#elif (!DE)
			f2.A ();
			#else
			Console.WriteLine("AAA{0}",f2.a);
			#endif
		}
    }
}
