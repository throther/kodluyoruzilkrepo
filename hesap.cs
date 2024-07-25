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
            Console.WriteLine("Lütfen ikili sayı çiftlerini aralarında boşluk bırakarak girin (örnek: 2 3 1 5 2 5 3 3):");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            if (inputArray.Length % 2 != 0)
            {
                Console.WriteLine("Lütfen ikili çiftler halinde sayı giriniz.");
                return;
            }

            List<int> results = new List<int>();

            for (int i = 0; i < inputArray.Length; i += 2)
            {
                if (int.TryParse(inputArray[i], out int num1) && int.TryParse(inputArray[i + 1], out int num2))
                {
                    int sum = num1 + num2;

                    if (num1 == num2)
                    {
                        results.Add(sum * sum);
                    }
                    else
                    {
                        results.Add(sum);
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen sadece sayıları girin.");
                    return;
                }
            }

            Console.WriteLine("Sonuçlar:");
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}


