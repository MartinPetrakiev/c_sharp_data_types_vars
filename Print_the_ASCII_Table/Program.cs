using System;

namespace MyProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 39; i <= 126; i++)
            {
                char c = (char)i;
                Console.Write(c + " ");
            }
        }
    }
}