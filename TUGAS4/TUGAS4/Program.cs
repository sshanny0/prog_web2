using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS4
{
    class Program
    {
        static void Main(string[] args)
        {
            int JUMLAH, HARGA, TOTAL;
            string NB, NOTELP, PELANGGAN;
            HARGA = 50000;

            Console.WriteLine("============================================\n");
            Console.WriteLine("Selamat datang di Toko Buku Sejahtera!\n");
            Console.Write("Masukkan Nama Barang yang ingin Anda Pesan: ");
            NB = Console.ReadLine();
            Console.Write("Masukkan Jumlah Barang yang ingin Anda Pesan: ");
            JUMLAH = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Harga produk dengan nilai konstan adalah: ");
            Console.Write("{0}", HARGA);
            Console.Write("\n\nNama Pemesan: ");
            PELANGGAN = Console.ReadLine();
            Console.Write("Nomor Telepon Pemesan: ");
            NOTELP = Console.ReadLine();
            TOTAL = HARGA * JUMLAH;
            Console.WriteLine("\nTotal harga barang yang harus anda bayarkan adalah: " + TOTAL);
            Console.WriteLine("\n\nTerima kasih atas kunjungan Anda!");
            Console.WriteLine("============================================");
        }
    }
}
