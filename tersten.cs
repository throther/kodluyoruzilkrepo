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
            Console.Write("İfade giriniz:");
            string ifade = Console.ReadLine();
            string result = "";

            for (int i = ifade.Length - 1; i >= 0; i--)
            {
                result += ifade[i];
            }
            Console.WriteLine("Sonuç: " + result);
            Console.ReadKey();
        }
        }
}


