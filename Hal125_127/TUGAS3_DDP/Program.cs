using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS3_DDP
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, x, y;
            Console.WriteLine("+============================================+");
            Console.WriteLine("|Rental Mobil Wilayah Jabodetabek dan Bandung|");
            Console.WriteLine("+============================================+");
            Console.Write("Inputkan Nama Anda: ");
            a = Console.ReadLine();
            Console.Write("Inputkan Alamat Anda: ");
            x = Console.ReadLine();
            Console.Write("Inputkan Nomor HP Anda: ");
            y = Console.ReadLine();
            Console.WriteLine("+===============================+");
            Console.WriteLine(" |   Kota Tujuan Rental:        |");
            Console.WriteLine(" |   1. Jakarta Utara           |");
            Console.WriteLine(" |   2. Jakarta Timur           |");
            Console.WriteLine(" |   3. Jakarta Selatan         |");
            Console.WriteLine(" |   4. Jakarta Barat           |");
            Console.WriteLine(" |   5. Bogor                   |");
            Console.WriteLine(" |   6. Tangerang               |");
            Console.WriteLine(" |   7. Bekasi                  |");
            Console.WriteLine(" |   8. Lembang                 |");
            Console.WriteLine(" |   9. Garut                   |");
            Console.WriteLine(" |   10. Kota Lain di Bandung   |");
            Console.WriteLine("+===============================+");
            string k;
            double b;
            Console.Write(" Inputkan Nomor Kota Tujuan: ");
            k = Console.ReadLine();
            Console.Write(" Inputkan Jarak Tujuan [Km]: ");
            b = double.Parse(Console.ReadLine());
            switch (k)
            {
                case "1":
                    Console.WriteLine(" Total Biaya : Rp " + (20000 * b) + ",-");
                    break;
                case "2":
                    Console.WriteLine(" Total Biaya : Rp " + (15000 * b) + ",-");
                    break;
                case "3":
                    Console.WriteLine(" Total Biaya : Rp " + (10000 * b) + ",-");
                    break;
                case "4":
                    Console.WriteLine(" Total Biaya : Rp " + (20000 * b) + ",-");
                    break;
                case "5":
                    Console.WriteLine(" Total Biaya : Rp " + (25000 * b) + ",-");
                    break;
                case "6":
                    Console.WriteLine(" Total Biaya : Rp " + (25000 * b) + ",-");
                    break;
                case "7":
                    Console.WriteLine(" Total Biaya : Rp " + (30000 * b) + ",-");
                    break;
                case "8":
                    Console.WriteLine(" Total Biaya : Rp " + (25000 * b) + ",-");
                    break;
                case "9":
                    Console.WriteLine(" Total Biaya : Rp " + (40000 * b) + ",-");
                    break;
                case "10":
                    Console.WriteLine(" Total Biaya : Rp " + (40000 * b) + ",-");
                    break;
                default:
                    Console.WriteLine(" Maaf Tidak Ada di Pilihan");
                    break;
            }
            Console.WriteLine("+=============================================+");
            Console.WriteLine("Terima kasih telah menggunakan jasa rental kami");
            Console.WriteLine("+=============================================+");
            Console.ReadLine();
        }
    }
}
