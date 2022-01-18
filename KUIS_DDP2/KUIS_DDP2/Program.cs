using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KUIS_DDP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string NAMA, NPM, ALAMAT, ANGKATAN, PS;

            Console.WriteLine("====================================");
            Console.WriteLine("          BIODATA MAHASISWA         ");
            Console.WriteLine("====================================");
            Console.Write("Nama : ");
            NAMA = Console.ReadLine();
            Console.Write("Nomor Pokok : ");
            NPM = Console.ReadLine();
            Console.Write("Alamat : ");
            ALAMAT = Console.ReadLine();
            Console.Write("Angkatan : ");
            ANGKATAN = Console.ReadLine();
            Console.Write("Program Studi : ");
            PS = Console.ReadLine();

            Console.WriteLine("===================================");
            Console.WriteLine("           INFORMASI NILAI         ");
            Console.WriteLine("===================================");
            Console.Write("Nilai Kehadiran: ");
            double NK = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nilai Tugas sebelum UTS: ");
            double NBUTS = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nilai Tugas setelah UTS: ");
            double NSUTS = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nilai UTS: ");
            double NUTS = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nilai UAS: ");
            double NUAS = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("===================================");
            double NA = (NK * 0.1) + (0.25 * NBUTS) + (0.25 * NSUTS) + (0.2 * NUTS) + (0.2 * NUAS);

            string KET, CAT;
            if (NA >= 50)
                CAT = "Selamat Anda Lulus";
            else
                CAT = "Maaf Anda Tidak Lulus";

            if (NA >= 90)
                KET = "A";
            else if (NA >= 70)
                KET = "B";
            else if (NA >= 60)
                KET = "C";
            else if (NA >= 50)
                KET = "D";
            else
                KET = "Maaf Anda Mengulang Semester Depan";

            Console.WriteLine("Nilai Akhir: " + NA);
            Console.WriteLine("Keterangan Nilai: " + KET);
            Console.WriteLine("Catatan: " + CAT);
            Console.ReadLine();
        }
    }
}
