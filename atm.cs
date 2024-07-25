using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static Dictionary<string, string> users = new Dictionary<string, string>
    {
        {"user1", "password1"},
        {"user2", "password2"},
        {"user3", "password3"}
    };

        static Dictionary<string, double> balances = new Dictionary<string, double>
    {
        {"user1", 1000.0},
        {"user2", 2000.0},
        {"user3", 3000.0}
    };

        static List<string> transactions = new List<string>();
        static List<string> failedAttempts = new List<string>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("ATM Sistemine Hoş Geldiniz!");
                Console.WriteLine("Lütfen kullanıcı adınızı girin:");
                string username = Console.ReadLine();
                Console.WriteLine("Lütfen şifrenizi girin:");
                string password = Console.ReadLine();

                if (AuthenticateUser(username, password))
                {
                    Console.WriteLine("Giriş başarılı!");
                    ShowMenu(username);
                }
                else
                {
                    Console.WriteLine("Hatalı kullanıcı adı veya şifre. Tekrar deneyin.");
                    failedAttempts.Add($"Başarısız giriş denemesi: {username}");
                }
            }
        }

        static bool AuthenticateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }

        static void ShowMenu(string username)
        {
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Para Çekme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Ödeme Yapma");
                Console.WriteLine("4. Gün Sonu Al");
                Console.WriteLine("5. Çıkış");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Withdraw(username);
                        break;
                    case "2":
                        Deposit(username);
                        break;
                    case "3":
                        MakePayment(username);
                        break;
                    case "4":
                        EndOfDay();
                        return;
                    case "5":
                        Console.WriteLine("Çıkış yapıldı.");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void Withdraw(string username)
        {
            Console.WriteLine("Çekmek istediğiniz miktarı girin:");
            double amount = double.Parse(Console.ReadLine());
            if (balances[username] >= amount)
            {
                balances[username] -= amount;
                transactions.Add($"{username} çekti: {amount} TL");
                Console.WriteLine($"Başarılı! Yeni bakiyeniz: {balances[username]} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }

        static void Deposit(string username)
        {
            Console.WriteLine("Yatırmak istediğiniz miktarı girin:");
            double amount = double.Parse(Console.ReadLine());
            balances[username] += amount;
            transactions.Add($"{username} yatırdı: {amount} TL");
            Console.WriteLine($"Başarılı! Yeni bakiyeniz: {balances[username]} TL");
        }

        static void MakePayment(string username)
        {
            Console.WriteLine("Ödeme yapmak istediğiniz miktarı girin:");
            double amount = double.Parse(Console.ReadLine());
            if (balances[username] >= amount)
            {
                balances[username] -= amount;
                transactions.Add($"{username} ödeme yaptı: {amount} TL");
                Console.WriteLine($"Başarılı! Yeni bakiyeniz: {balances[username]} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }

        static void EndOfDay()
        {
            string fileName = $"EOD_{DateTime.Now:ddMMyyyy}.txt";
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("Gün Sonu Raporu");
                sw.WriteLine("İşlemler:");
                foreach (var transaction in transactions)
                {
                    sw.WriteLine(transaction);
                }
                sw.WriteLine("Başarısız Giriş Denemeleri:");
                foreach (var attempt in failedAttempts)
                {
                    sw.WriteLine(attempt);
                }
            }
            Console.WriteLine("Gün sonu raporu oluşturuldu.");
        }
    }
}


