using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 42;
            char c = (char)num;

            char myChar = '\u002A';

            Console.WriteLine(c.ToString());
            Console.WriteLine(myChar);
        }
    }
}
