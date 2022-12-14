using System;

namespace Csharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Box a = new Box(1);
            Box b = new Box(2);
            Console.WriteLine(a+b);
        }
    }
    //静态多态性包括函数重载与运算符重载
    class printData 
    {//函数重载
        public void Print(string a)
        {
            Console.WriteLine(a);
        }
        public void Print(int a)
        {
            Console.WriteLine("{0}",a);
        }
        public void Print(float a)
        {
            Console.WriteLine(a);
        }
        public void Print(double a)
        {
            Console.WriteLine(a);
        }
    }
    class Box
    {
         int age;
         public Box(int A)
         {
            age = A;
         }
         public static int operator+ (Box a, Box b)
         {
             return a.age+b.age;
                                
         }
    }
    //动态多态性包括抽象类与虚方法等
    abstract class Shape
    {
        public abstract int height();
    }
    class A
    {
        public virtual int a()
        {
            Console.WriteLine("AAA");
            return 0;
        }
    }
}
