//a program to discount all of the prices and output a new price list in the format shown below.

using System;
using System.Collections.Generic;

namespace sololeran_csharp_practice.practice_programs
{
    class Coffe_time
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            foreach (string coffeeName in coffee.Keys)
            {
                Console.WriteLine(coffeeName + ": " + (coffee[coffeeName] - (coffee[coffeeName] * discount / 100)));
            }
        }
    }
}
