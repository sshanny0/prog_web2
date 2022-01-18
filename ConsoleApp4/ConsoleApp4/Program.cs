using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // variabel inputan
            int jml, hrg, total;
            long tlp;
            string plgn, nb;

            // variabel konstan     
            hrg = 3500000;

            // Statement input dan output
            Console.WriteLine("==============================================\n\n");
            Console.WriteLine("Rekapitulasi Pembelian Produk PT Untung Selalu\n\n");
            Console.WriteLine("==============================================\n\n");
            Console.Write("Inputkan Nama Produk                      : ");
            nb = Console.ReadLine();
            Console.Write("Inputkan Jumlah Produk                    : ");
            jml = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nHarga Produk dengan Nilai Konstan adalah: ");
            Console.Write("{0}", hrg);
            Console.Write("\nInputkan Nama Pelanggan                 : ");
            plgn = Console.ReadLine();
            Console.Write("\nInputkan No.Telp Pelanggan              : ");
            tlp = Convert.ToInt64(Console.ReadLine());
            total = (hrg * jml);
            Console.WriteLine("Total Pembayaran Adalah               : " + total);
            Console.WriteLine("\n Terima Kasih Atas Kunjungan Anda ");
            Console.WriteLine("\n          Sampai Jumpa Lagi di PT Untung Selalu ");
            Console.WriteLine("\n================================================");
            Console.ReadLine();
        }
    }
}
