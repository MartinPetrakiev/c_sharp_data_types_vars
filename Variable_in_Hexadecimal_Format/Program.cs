using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 254;
            Console.WriteLine(num.ToString("X"));
            Console.WriteLine("0x{0:X2}", num);
        }
    }
}