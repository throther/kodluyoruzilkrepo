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
            Console.Write("Fibonacci serisinin derinliğini girin: ");
            int depth = int.Parse(Console.ReadLine());

            if (depth <= 0)
            {
                Console.WriteLine("Derinlik pozitif bir sayı olmalıdır.");
                return;
            }

            long[] fibonacciSeries = new long[depth];
            fibonacciSeries[0] = 0;

            if (depth > 1)
            {
                fibonacciSeries[1] = 1;
                for (int i = 2; i < depth; i++)
                {
                    fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
                }
            }

            double average = CalculateAverage(fibonacciSeries);
            Console.WriteLine($"Fibonacci serisinin ortalaması: {average}");
            Console.ReadKey();
        }

        static double CalculateAverage(long[] series)
        {
            long sum = 0;
            foreach (long number in series)
            {
                sum += number;
            }
            return (double)sum / series.Length;
        }
    }
}

