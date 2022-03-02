using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patterns");
            for (int i = 1; i < 4; i++)
            {
                for (int k = 4; k > i; k--)
                {
                    Console.Write("*");
                }
                for(int h=3;h<6;h++)
                {
                    Console.WriteLine(" ");
                }
                //for (int j = 3; j < 6; j++)
                //{
                //    Console.WriteLine("*");
                //}
                Console.WriteLine("");
            }
        }
            //{
        //     int a=10,b=26;
        //    Console.WriteLine("a={0} b={1}", a, b);
        //    swap(a, b);
        //}
        //static public void swap(int a, int b)
        //{
        //    a = a * b;
        //    b = a / b;
        //    a = a / b;
        //    Console.WriteLine("a=" + a + "b=" + b);
        //}

    }
}
