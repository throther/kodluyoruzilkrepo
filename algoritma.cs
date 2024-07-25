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
            Console.WriteLine("String ve sayı şeklinde (aralarında virgül ile) girdi yapınız (çıkmak için boş enter tuşlayın):");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                // Girdi verisini ayır
                string[] parts = input.Split(',');
                if (parts.Length != 2 || !int.TryParse(parts[1], out int index))
                {
                    Console.WriteLine("Geçersiz girdi, lütfen tekrar deneyin.");
                    continue;
                }

                string text = parts[0];

                // Belirtilen indexi kontrol et ve karakteri çıkar
                if (index < 0 || index >= text.Length)
                {
                    Console.WriteLine("Geçersiz index, lütfen tekrar deneyin.");
                    continue;
                }

                string result = RemoveCharacterAtIndex(text, index);
                Console.WriteLine(result);
            }
        }

        static string RemoveCharacterAtIndex(string text, int index)
        {
            return text.Remove(index, 1);
        }
    }
}


