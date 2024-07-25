using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static Dictionary<string, int> filmCategories = new Dictionary<string, int>
    {
        {"Action", 0},
        {"Comedy", 0},
        {"Drama", 0},
        {"Horror", 0}
    };

        static Dictionary<string, int> techStackCategories = new Dictionary<string, int>
    {
        {"JavaScript", 0},
        {"Python", 0},
        {"C#", 0},
        {"Java", 0}
    };

        static Dictionary<string, int> sportCategories = new Dictionary<string, int>
    {
        {"Football", 0},
        {"Basketball", 0},
        {"Tennis", 0},
        {"Cricket", 0}
    };

        static Dictionary<string, string> users = new Dictionary<string, string>();

        static void Main()
        {
            Console.WriteLine("Oylamaya hoş geldiniz!");
            Console.WriteLine("Kullanıcı adınızı girin:");
            string username = Console.ReadLine();

            if (!users.ContainsKey(username))
            {
                Console.WriteLine("Kullanıcı bulunamadı. Yeni kullanıcı olarak kaydediliyorsunuz.");
                users.Add(username, username);
            }

            while (true)
            {
                Console.WriteLine("Lütfen oy vermek istediğiniz kategoriyi seçin:");
                Console.WriteLine("1. Film Kategorileri");
                Console.WriteLine("2. Tech Stack Kategorileri");
                Console.WriteLine("3. Spor Kategorileri");
                Console.WriteLine("4. Oylamayı sonlandır ve sonuçları göster");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Vote(filmCategories);
                        break;
                    case "2":
                        Vote(techStackCategories);
                        break;
                    case "3":
                        Vote(sportCategories);
                        break;
                    case "4":
                        DisplayResults();
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }
                Console.ReadKey();
            }
        }

        static void Vote(Dictionary<string, int> categories)
        {
            Console.WriteLine("Lütfen oy vermek istediğiniz alt kategoriyi seçin:");
            foreach (var category in categories.Keys)
            {
                Console.WriteLine(category);
            }

            string subCategory = Console.ReadLine();

            if (categories.ContainsKey(subCategory))
            {
                categories[subCategory]++;
                Console.WriteLine($"{subCategory} için oy verdiniz.");
            }
            else
            {
                Console.WriteLine("Geçersiz kategori, lütfen tekrar deneyin.");
            }
        }

        static void DisplayResults()
        {
            Console.WriteLine("Oylama sonuçları:");
            Console.WriteLine("Film Kategorileri:");
            DisplayCategoryResults(filmCategories);
            Console.WriteLine("Tech Stack Kategorileri:");
            DisplayCategoryResults(techStackCategories);
            Console.WriteLine("Spor Kategorileri:");
            DisplayCategoryResults(sportCategories);
        }

        static void DisplayCategoryResults(Dictionary<string, int> categories)
        {
            int totalVotes = categories.Values.Sum();
            foreach (var category in categories)
            {
                double percentage = totalVotes > 0 ? (category.Value / (double)totalVotes) * 100 : 0;
                Console.WriteLine($"{category.Key}: {category.Value} oy (%{percentage:F2})");
            }
        }
    }
}


