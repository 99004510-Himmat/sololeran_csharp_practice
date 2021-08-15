// a program to iterate through the array and output words containing the taken letter.
//If there is no such word, the program should output "No match".

using System;
using System.Collections.Generic;

namespace sololeran_csharp_practice.practice_programs
{
    class Words
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();
            var matched_words = new HashSet<string>();
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == Convert.ToChar(letter))
                    {
                        matched_words.Add(word);
                    }
                }
            }

            //to print  
            if (matched_words.Count > 0)
            {
                foreach (string matched_word in matched_words)
                {
                    Console.WriteLine(matched_word);
                }
            }
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}
