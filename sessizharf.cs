using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Lütfen bir cümle girin:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                if (ContainsTwoConsecutiveConsonants(word))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            Console.ReadKey();
        }

        static bool ContainsTwoConsecutiveConsonants(string word)
        {
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (!vowels.Contains(word[i]) && !vowels.Contains(word[i + 1]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}


