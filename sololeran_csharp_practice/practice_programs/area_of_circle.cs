//a program that will calculate the area of ​​a circle.

using System;

namespace sololeran_csharp_practice.practice_programs
{
    class Area_of_circle
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;

            radius = Convert.ToDouble(Console.ReadLine());

            double area = pi * radius * radius;

            Console.WriteLine(area);
        }
    }
}
