using System;
namespace Csharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Woman woman = new Woman(180, 100);
            woman.Product();
            
        }
    }
    class Person
    {
        protected int height;
        protected int weight;
        public Person(int h, int w)
        {
            height= h;
            weight = w;
        }
        public void Product()
        {
            Console.WriteLine("Product is {0}",height*weight);
        }


    }
    class Woman:Person//Csharp不支持多继承
    {
        public Woman(int  h, int w):base(h, w)
        {

            Console.WriteLine("height:{0},weight:{1}",h,w);
        }
    }
}
