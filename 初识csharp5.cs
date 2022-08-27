using System;
namespace Csharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            InterChild inter = new InterChild();
            inter.printObject();
            Console.WriteLine("{0}",inter.Age(10));
        }
    }
    //定义接口默认为public
    interface Inter
    {
        void printObject();
        int Age(int age);
    }
    //接口中的成员方法派生类必须全部实现并格式一样
    class InterChild:Inter
    {
        public void printObject()
        {
            Console.WriteLine("I am a SB");
        }
        public int Age(int age)
        {
            return age+100;
        }
    }
}
