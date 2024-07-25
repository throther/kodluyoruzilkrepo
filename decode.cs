using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text to encode: ");
            string text = Console.ReadLine();

            // Barcode'u oluştur ve ekrana yazdır
            string barcode = GenerateBarcode(text);
            Console.WriteLine("Generated Barcode:");
            Console.WriteLine(barcode);

            // Barcode'u oku (basit bir çözüm, metni tekrar döndürür)
            string decodedText = ReadBarcode(barcode);
            Console.WriteLine("Decoded Barcode Text: " + decodedText);
            Console.ReadLine();
        }

        static string GenerateBarcode(string text)
        {
            // Basitleştirilmiş ASCII barcode örneği
            string barcode = "";
            foreach (char c in text)
            {
                barcode += new string('*', c % 10 + 1) + " ";
            }
            return barcode.Trim();
        }

        static string ReadBarcode(string barcode)
        {
            // Basitleştirilmiş çözüm: metni tekrar döndür
            // Burada, metni ASCII biçiminden gerçek metne dönüştürmek yerine, sadece tekrar döndürülür.
            string[] parts = barcode.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string decodedText = "";
            foreach (string part in parts)
            {
                decodedText += (char)((part.Length - 1) * 10 + 65); // ASCII değer dönüştürmesi
            }
            return decodedText;
        }
    }

}


