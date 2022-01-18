using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pj; //variabel unt menampung nilai panjang
            int lb; //variabel unt menampung nilai lebar
            int L; //variabel yg menampung hasil Luas
            Console.Write("Inputkan nilai panjang :");
            //konversi dari tipe string ke integer
            pj = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan nilai lebar :");
            lb = Convert.ToInt32(Console.ReadLine());
            L = pj * lb;
            Console.WriteLine("Jadi Hasil Luasnya adalah  " + L);
        }
    }
}
