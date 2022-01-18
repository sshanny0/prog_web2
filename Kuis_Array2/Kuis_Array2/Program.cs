using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuis_Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NAMA = new string[20];
            double[] TJ = new double[10];
            double[] TP = new double[10];
            double[] HL = new double[10];
            double[] GB = new double[10];
            double TOTAL;

            int i;
            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine("Karyawan Ke- " + i);
                Console.Write("\t Inputkan Nama Karyawan: ");
                NAMA[i] = Console.ReadLine();
                Console.Write("\t Masukkan tunjangan jabatan: ");
                TJ[i] = double.Parse(Console.ReadLine());
                Console.Write("\t Masukkan tunjangan pendidikan: ");
                TP[i] = double.Parse(Console.ReadLine());
                Console.Write("\t Masukkan honor lembur: ");
                HL[i] = double.Parse(Console.ReadLine());
                GB[i] = TJ[i] + TP[i];
                Console.WriteLine();
                
            }
            

            Console.Clear();
            Console.WriteLine("                    DATA KARYAWAN                    ");
            Console.WriteLine("               PT SEJAHTERA TECHNOLOGY               ");
            Console.WriteLine("No | Nama Karyawan | Tunjangan Jabatan | Tunjangan Pendidikan | Honor Lembur | Gaji Bersih ");
            
            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine(i + " " + NAMA[i] + "\t" + TJ[i] + "\t" + TP[i] + "\t" + HL[i] + "\t" + GB[i] + "\t");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
            }
            TOTAL = GB[1] + GB[2] + GB[3] + HL[1] + HL[2] + HL[3];
            Console.WriteLine("Total gaji yang dikeluarkan : " + TOTAL);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("                    TERIMA KASIH                    ");
            Console.ReadLine();
        }
    }
}
