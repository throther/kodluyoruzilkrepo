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
                Console.Write("Dairenin yarıçapını giriniz: ");
                int yaricap = int.Parse(Console.ReadLine());

                // Daireyi çiz
                DaireCizici.Ciz(yaricap);
                Console.ReadLine();
            }

        class DaireCizici
        {
            public static void Ciz(int yaricap)
            {
                double kalinlik = 0.4;
                double disR = yaricap + kalinlik;
                double icR = yaricap - kalinlik;

                for (int y = yaricap; y >= -yaricap; --y)
                {
                    for (int x = -yaricap; x < disR * 2; x++)
                    {
                        double deger = x * x + y * y * (1 / kalinlik);

                        if (deger >= icR * icR && deger <= disR * disR)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        }
    }

