using System;

namespace MyProject
{
    public class Program
    {
        static bool Equals(float x, float y)
        {
            float eps = 0.000001F;
            float diff = Math.Abs(x - y);
            return diff <= eps ||
                   diff <= Math.Max(Math.Abs(x), Math.Abs(y)) * eps;
        }
        static void Main(string[] args)
        {   
            Console.WriteLine("First number: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine(Program.Equals(x, y));
        }
    }
}