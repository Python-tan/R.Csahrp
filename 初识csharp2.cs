using System;
namespace Csharp
{
    class MainClass
    {
        public  static void Main(string[] args)
        {      
            Cube cub = new Cube(1.0,2.0,3.0,4.0);
            Cube cub1 = new Cube(1.0,2.0,3.0,4.0);
            Cube cub2 = new Cube(1.0,2.0,3.0,4.0);
            Cube cub3 = new Cube(1.0,2.0,3.0,4.0);
            
            Console.WriteLine(cub.getNum());
            Console.WriteLine(cub1.getNum());
            Console.WriteLine(cub2.getNum());//静态成员函数只能通过类直接访问
            Console.WriteLine(cub3.getNum());
            
        } 
    }
    class Cube
    {
        protected double length;
        protected double height;
        protected double breadth;//成员变量默认为private
        public static int num;
        public Cube(params double[] arr)
        {
            if ((arr.Length > 3) || (arr.Length <= 0))
            {
                Console.WriteLine("...");
            }else{
                length = arr[0];
                height = arr[1];
                breadth = arr[2];
            }
            

        }
        ~Cube()//析构函数，对象删除时会调用
        {
            Console.WriteLine("对象已删除");
        }
        public int getNum()
        {
            return num++;
        }



    }
}
