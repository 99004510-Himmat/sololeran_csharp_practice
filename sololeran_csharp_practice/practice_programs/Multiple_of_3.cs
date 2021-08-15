// a program to output all numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".

using System;

namespace sololeran_csharp_practice.practice_programs
{
    class Multiple_of_3
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
    }
}
