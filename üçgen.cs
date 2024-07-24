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
            Console.Write("Üçgenin boyutunu giriniz: ");
            int boyut = int.Parse(Console.ReadLine());
            for (int i = 1; i <= boyut; i++)
            {
                for (int j = boyut; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

