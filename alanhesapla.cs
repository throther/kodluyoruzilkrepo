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
            Console.WriteLine("Geometrik şekil seçin (Daire, Üçgen, Kare, Dikdörtgen):");
            string shape = Console.ReadLine().ToLower();

            Console.WriteLine("Hangi hesaplamayı yapmak istiyorsunuz (Çevre, Alan):");
            string calculation = Console.ReadLine().ToLower();

            IShape geometricShape = null;

            switch (shape)
            {
                case "daire":
                    geometricShape = new Circle();
                    break;
                case "üçgen":
                    geometricShape = new Triangle();
                    break;
                case "kare":
                    geometricShape = new Square();
                    break;
                case "dikdörtgen":
                    geometricShape = new Rectangle();
                    break;
                default:
                    Console.WriteLine("Geçersiz şekil.");
                    return;
            }

            geometricShape.GetDimensionsFromUser();

            switch (calculation)
            {
                case "çevre":
                    Console.WriteLine($"Çevre: {geometricShape.CalculatePerimeter()}");
                    break;
                case "alan":
                    Console.WriteLine($"Alan: {geometricShape.CalculateArea()}");
                    break;
                default:
                    Console.WriteLine("Geçersiz hesaplama türü.");
                    break;
            }
        }
    }

    public interface IShape
    {
        void GetDimensionsFromUser();
        double CalculateArea();
        double CalculatePerimeter();
    }

    public class Circle : IShape
    {
        private double radius;

        public void GetDimensionsFromUser()
        {
            Console.WriteLine("Yarıçapı girin:");
            radius = double.Parse(Console.ReadLine());
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Triangle : IShape
    {
        private double side1, side2, side3;

        public void GetDimensionsFromUser()
        {
            Console.WriteLine("1. kenar uzunluğunu girin:");
            side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2. kenar uzunluğunu girin:");
            side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("3. kenar uzunluğunu girin:");
            side3 = double.Parse(Console.ReadLine());
        }

        public double CalculateArea()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
    }

    public class Square : IShape
    {
        private double side;

        public void GetDimensionsFromUser()
        {
            Console.WriteLine("Kenar uzunluğunu girin:");
            side = double.Parse(Console.ReadLine());
        }

        public double CalculateArea()
        {
            return side * side;
        }

        public double CalculatePerimeter()
        {
            return 4 * side;
        }
    }

    public class Rectangle : IShape
    {
        private double length, width;

        public void GetDimensionsFromUser()
        {
            Console.WriteLine("Uzun kenar uzunluğunu girin:");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Kısa kenar uzunluğunu girin:");
            width = double.Parse(Console.ReadLine());
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
}


