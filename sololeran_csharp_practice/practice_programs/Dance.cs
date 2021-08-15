//In a dancing competition, each dancer from a pair is evaluated separately,
//and then their points are summed up to get the total pair score.

using System;

namespace sololeran_csharp_practice.practice_programs
{
    class Dance
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator
        public static DancerPoints operator +(DancerPoints one, DancerPoints two)
        {
            string pair_name = one.name + " & " + two.name;
            int pair_points = one.points + two.points;

            DancerPoints pair_result = new DancerPoints(pair_name, pair_points);
            return pair_result;
        }

    }
}