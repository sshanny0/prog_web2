using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDDP_FORUM1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama, npm, alm, ang, pr;
            double NA;
            Console.Write("Inputkan Nama Mahasiswa : ");
            nama = Console.ReadLine();
            Console.Write("Inputkan Nomor Pokok Mahasiswa: ");
            npm = Console.ReadLine();
            Console.Write("Inputkan Alamat Mahasiswa : ");
            alm = Console.ReadLine();
            Console.Write("Inputkan Angkatan Mahasiswa : ");
            ang = Console.ReadLine();
            Console.Write("Program Studi Mahasiswa : ");
            pr = Console.ReadLine();

            Console.Write("Inputkan Nilai Kehadiran : ");
            double K = Convert.ToSingle(Console.ReadLine());
            Console.Write("Inputkan Nilai Tugas Sblm UTS : ");
            double TG = Convert.ToSingle(Console.ReadLine());
            Console.Write("Inputkan Nilai Tugas Stlh UTS : ");
            double AY = Convert.ToSingle(Console.ReadLine());
            Console.Write("Inputkan Nilai UTS : ");
            double L = Convert.ToSingle(Console.ReadLine());
            Console.Write("Inputkan Nilai UAS : ");
            double A = Convert.ToSingle(Console.ReadLine());
            NA = (K * 0.1) + (TG * 0.25) + (AY * 0.25) + (L * 0.2) + (A * 0.2);

            Console.WriteLine("Nilai Akhir Anda Adalah : {0}"+ NA);
            Console.WriteLine("==============================");
            Console.WriteLine("==============================");
            Console.WriteLine("Rangkuman Hasil Perolehan Nilai " + nama);
            Console.WriteLine("===============================");
            Console.WriteLine("===============================");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| Nama | Rangkuman Nilai |");
            Console.WriteLine("| Mahasiswa| KH | T1 | T2 | UTS | UAS | ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| " + nama + " | " + AY + " |" + TG + " |" + K + "| " + L+ " | " + A +" | ");
            Console.WriteLine("--------------------------------------------");

            string ket;
            if (NA >= 90)
                ket = "selamat anda mendapat nilai A";
            else if (NA >= 80)
                ket = "selamat anda mendapat nilai B";
            else if (NA >= 70)
                ket = "selamat anda mendapat nilai C";
            else
                ket = "selamat anda mendapatkan nilai D";
            Console.WriteLine(" Keterangan Nilai Anda Adalah: " + ket);
            Console.WriteLine(":::::::::::::::Thank You:::::::::::::::::: ");
        }
    }
}