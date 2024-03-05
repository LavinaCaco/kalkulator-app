using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Menu Calculator : \n");

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian \n");
            int action = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Angka Pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Angka Kedua : ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Penjumlahan(a, b);
                        break;
                    }
                case 2:
                    {
                        result = Pengurangan(a, b);
                        break;
                    }
                case 3:
                    {
                        result = Perkalian(a, b);
                        break;
                    }
                case 4:
                    {
                        result = Pembagian(a, b);
                        break;
                    }

                default:
                    Console.WriteLine("Coba Lagi");
                    break;
            }
            Console.WriteLine("Hasilnya {0}", result);
            Console.ReadKey();
        }
        
        public static int Penjumlahan(int a, int b)
        {
            int result = a + b;
            return result;
        }
        
        public static int Pengurangan(int a, int b)
        {
            int result = a - b;
            return result;
        }
        
        public static int Perkalian(int a, int b)
        {
            int result = a * b;
            return result;
        }
        
        public static int Pembagian(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }
}