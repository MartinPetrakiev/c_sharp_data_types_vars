using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine(a + " " + b);

            int c;

            c = a;
            a = b;
            b = c;
            
            Console.WriteLine(a + " " + b);

        }
    }
}