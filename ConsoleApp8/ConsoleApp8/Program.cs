//Program 3.11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace operator2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi Nilai Konstan a dan b
            int a = 100, b = 20;
            // Deklarasi Penyimpanan Nilai dengan Variabel X dan W
            Boolean X, W;
            System.Console.WriteLine(" =============================================");
            System.Console.WriteLine(" Menggunakan Operator AND dan OR ");
            System.Console.WriteLine(" ============================================");
            // Proses Analisis Logika Dengan Operator AND dan OR
            X = (a <= 100 && b >= 100);
            W = (a <= 100 || b >= 100);
            // Mencetak Hasil Keluaran
            System.Console.WriteLine("=====================================================");
            System.Console.WriteLine("Mencetak Hasil Dengan Menggunakan Operator Logika And dan OR");
            System.Console.WriteLine("=====================================================");
            System.Console.WriteLine(" Hasil Logika AND dari data a dan b adalah :" + X);
            System.Console.WriteLine(" Hasil Logika OR dari data a dan b adalah :" + W);
            System.Console.WriteLine(" ==================================================");
            System.Console.WriteLine(" Selamat Mencoba Terima Kasih FauziahKasyfi@2015 ");
            System.Console.WriteLine(" ==================================================");
            System.Console.ReadLine();
        }
    }
}