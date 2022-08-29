using System;
namespace Csharp
{
    class MainClass
    {
        public class IsZero:ApplicationException
        {
            public IsZero(string stri):base (message)//不知道为什么message不存在

            {
                    Console.WriteLine(stri);
            }
        }
        public void func(int a)
        {
            if (a == 0)
             {
                throw(new IsZero("ji ni tai mei"));
             }
             Console.WriteLine("{0}",a/2);
        }
        public static void Main(string[] args)
        {
            MainClass mc = new MainClass(); 
            try
            {
                mc.func(0);
            }            
            catch(IsZero e)
            {
            
                Console.WriteLine("You have a error:{0}",e);
            }
            finally
            {
                Console.WriteLine("This is a FINALLY!");
            }          

        }

    }
}
