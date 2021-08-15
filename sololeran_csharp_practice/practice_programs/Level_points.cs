//Passing the first level of a video game awards the player 1 point.
//For each subsequent level passed, the points awarded increment by 1
//(2 for the 2nd level, 3 for the 3rd, and so on).
//Calculate and return the total number of points given for all passed levels.

using System;

namespace sololeran_csharp_practice.practice_programs
{
    class Level_points
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        static int Points(int levels)
        {
            int total_points = 0;

            for (int i = 1; i <= levels; i++)
            {
                total_points += i;
            }
            return total_points;
        }
    }
}
