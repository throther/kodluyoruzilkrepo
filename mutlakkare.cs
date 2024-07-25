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
            Console.WriteLine("Lütfen aralarında boşluk bırakarak sayıları girin (örnek: 56 45 68 77):");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int threshold = 67;
            int smallDifferenceSum = 0;
            int largeDifferenceSquaredSum = 0;
            foreach (string s in inputArray)
            {
                if (int.TryParse(s, out int number))
                {
                    if (number < threshold)
                    {
                        smallDifferenceSum += (threshold - number);
                    }
                    else if (number > threshold)
                    {
                        largeDifferenceSquaredSum += (int)Math.Pow(Math.Abs(number - threshold), 2);
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen sadece sayıları girin.");
                    return;
                }
            }
            Console.WriteLine("67'den küçük olan sayıların farklarının toplamı: " + smallDifferenceSum);
            Console.WriteLine("67'den büyük olan sayıların farklarının mutlak karelerinin toplamı: " + largeDifferenceSquaredSum);
            Console.ReadKey();
        }
    }
}


