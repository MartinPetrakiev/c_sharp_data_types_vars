using System;

namespace MyProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> a = null;
            Nullable<double> b = null;

            Console.WriteLine("Value of a: " + a.GetValueOrDefault());
            Console.WriteLine("Value of b: " + b.GetValueOrDefault());

            a = 25;
            Console.WriteLine("Value of a: " + a.GetValueOrDefault());

        }
    }
}