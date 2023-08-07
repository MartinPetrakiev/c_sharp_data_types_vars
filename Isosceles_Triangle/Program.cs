using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = '©';

            for (int i = 0; i < 6 / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(c);
            Console.Write("\n");
            for (int i = 0; i < 6 / 2 - 1; i++)
            {
                for (int j = 0; j < (6 / 2 - i - 1); j++)
                {
                    Console.Write(" ");

                }
                Console.Write(c);
                for (int k = 0; k < (2 * i + 1); k++)
                {
                    Console.Write(" ");

                }
                Console.Write(c);
                Console.Write("\n");
            }

            for (int l = 0; l < 4 / 2 + 2; l++) {
                Console.Write(c + " ");
            }
        }

        //    ©

        //   © ©

        //  ©   ©

        // © © © ©

    }
}