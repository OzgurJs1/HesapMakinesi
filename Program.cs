using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    public class Program
    {
        public static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi Örneği :)");
            Console.WriteLine("Kaç adet sayı gireceksiniz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Sayı {i + 1}");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Yapmak istediğiniz işlemi seçin: ");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");
            Console.Write("Seçiminiz (1-4): ");

            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            switch (choice)
            {
                case 1:
                    result = Topla(numbers);
                    break;
                
                case 2:
                    result = Cikar(numbers);
                    break;

                case 3:
                    result = Carp(numbers);
                    break;
                
                case 4:
                    result = Bol(numbers);
                    break;
                
                default:
                    Console.WriteLine("Hatalı Seçim. Program Kapanıyor.");
                break;
            }
            Console.WriteLine($"Sonuç = {result}  ");
            Console.ReadKey();
        }
        static double Topla(double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        static double Cikar(double[] numbers)
        {
            double result = numbers[0];
            foreach (double number in numbers)
            {
                result -= number;
            }
            return result;
        }
        static double Carp(double[] numbers)
        {
            double result = 1;
            foreach (double number in numbers)
            {
                result *= number;
            }
            return result;
        }

        static double Bol(double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    result /= numbers[i];
                }
                else
                {
                    Console.Write("Sayı 0' a bölünemez! Program Kapanıyor.");
                    Environment.Exit(0);
                }
            }
            return result;
        }
    }
}
