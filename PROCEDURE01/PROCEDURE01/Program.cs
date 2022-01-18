using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCEDURE01
{
    class Program
    {
        private static byte masuk(string a)
        {
            byte data;
            Console.Write(a);
            data = Convert.ToByte(Console.ReadLine());
            return data;
        }

        private static void penjumlahan(byte a, byte b)
        {
            byte data;
            data = Convert.ToByte(a + b);
            Console.WriteLine("Penjumlahan {0} dengan {1} = {2}", a, b, data);
        }

        private static void pengurangan(byte a, byte b)

        {
            byte data;
            data = Convert.ToByte(a - b);
            Console.WriteLine("Pengurangan {0} dengan {1} = {2}", a, b, data);
        }

        private static void perkalian(byte a, byte b)
        {
            byte data;
            data = Convert.ToByte(a * b);
            Console.WriteLine("Perkalian {0} dengan {1} = {2}", a, b, data);
        }

        private static void pembagian(byte a, byte b)
        {
            double data;
            data = Convert.ToDouble(a / b);
            Console.WriteLine("Pembagian {0} dengan {1} = {2}", a, b, data);
        }

        public static void Main(string[] args)
        {
            byte a, b;
            a = masuk("Nilai 1 = ");
            b = masuk("Nilai 2 = ");
            perkalian(a, b);
            pembagian(a, b);
            penjumlahan(a, b);
            pengurangan(a, b);
           
            Console.ReadKey(true);
        }
    }
}
