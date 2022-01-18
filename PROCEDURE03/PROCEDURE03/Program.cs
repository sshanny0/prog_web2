using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCEDURE03
{

    class Persegi
    {
        private int nilai1;
        float kel1, luas1;
        public void Keliling(int h)
        {
            nilai1 = h;
            kel1 = nilai1 * 4;
        }
        public void Luas(int h)
        {
            nilai1 = h;
            luas1 = nilai1 * nilai1;
        }
        public void hasilkel1()
        {
            Console.WriteLine(kel1);
        }
        public void hasilluas1()
        {
            Console.WriteLine(luas1);
        }
    }

    class Persegi_Panjang
    {
        private int nilai2, nilai3;
        float kel2, luas2;
        public void Keliling2(int i, int j)
        {
            nilai2 = i;
            nilai3 = j;
            kel2 = 2 * (nilai2 + nilai3);
        }
        public void Luas2(int i, int j)
        {
            nilai2 = i;
            nilai3 = j;
            luas2 = nilai2 * nilai3;
        }
        public void hasilkel2()
        {
            Console.WriteLine(kel2);
        }
        public void hasilluas2()
        {
            Console.WriteLine(luas2);
        }
    }

    class Segitiga
    {
        private int nilai4, nilai5, nilai6;
        float kel3, luas3;
        public void Keliling3(int k, int l, int m)
        {
            nilai4 = k;
            nilai5 = l;
            nilai6 = m;
            kel3 = nilai4 + nilai5 + nilai6;
        }
        public void Luas3(int k, int l)
        {
            nilai4 = k;
            nilai5 = l;
            luas3 = nilai4 * nilai5 / 2;
        }
        public void hasilkel3()
        {
            Console.WriteLine(kel3);
        }
        public void hasilluas3()
        {
            Console.WriteLine(luas3);
        }
    }

}

namespace PROCEDURE03
{
    class Program
    {
        public static void Main(string[] args)
        {
            int h, i, j, k, l, m;

            Persegi v = new Persegi();
            Persegi_Panjang w = new Persegi_Panjang();
            Segitiga x = new Segitiga();

            Console.WriteLine("    Persegi     ");
            Console.Write("\nMasukkan sisi: ");
            h = Convert.ToInt32(Console.ReadLine());
            v.Keliling(h);
            Console.Write("Hasil Keliling Persegi: ");
            v.hasilkel1();
            v.Luas(h);
            Console.Write("Hasil Luas Persegi: ");
            v.hasilluas1();

            Console.WriteLine();
            Console.WriteLine("    Persegi Panjang     ");
            Console.Write("\nMasukkan panjang: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            j = Convert.ToInt32(Console.ReadLine());
            w.Keliling2(i, j);
            Console.Write("Hasil Keliling Persegi Panjang: ");
            w.hasilkel2();
            w.Luas2(i, j);
            Console.Write("Hasil Luas Persegi Panjang: ");
            w.hasilluas2();

            Console.WriteLine();
            Console.WriteLine("    Segitiga    ");
            Console.Write("\nMasukkan alas: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan tinggi: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan sisi: ");
            m = Convert.ToInt32(Console.ReadLine());
            x.Keliling3(k, l, m);
            Console.Write("Hasil Keliling Segitiga: ");
            x.hasilkel3();
            x.Luas3(k, l);
            Console.Write("Hasil Luas Segitiga: ");
            x.hasilluas3();
            Console.ReadKey(true);
        }
    }
}