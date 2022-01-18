using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasHANNY_181
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[20];
            int[] kuis = new int[10];
            int[] uts = new int[10];
            int[] uas = new int[10];
            double[] total = new double[10];
            string[] huruf = new string[20];

            int i, n = 0;
            Console.Write("Inputkan Jumlah Mahasiswa: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)

            {
                Console.WriteLine("Inputkan Mahasiswa Ke-" + i);
                Console.Write("\t Inputkan Nama Mahasiswa: ");
                nama[i] = Console.ReadLine();
                Console.Write("\t Inputkan Nilai Kuis: ");
                kuis[i] = int.Parse(Console.ReadLine());
                Console.Write("\t Inputkan Nilai UTS: ");
                uts[i] = int.Parse(Console.ReadLine());
                Console.Write("\t Inputkan Nilai UAS: ");
                uas[i] = int.Parse(Console.ReadLine());
                total[i] = 0.2 * kuis[i] + 0.4 * uts[i] + 0.4 * uas[i];
                Console.WriteLine();

                if (total[i] >= 80 && total[i] <= 100)
                {
                    huruf[i] = "A";
                }
                else if (total[i] >= 60 && total[i] <= 79)
                {
                    huruf[i] = "B";
                }
                else if (total[i] >= 40 && total[i] <= 59)
                {
                    huruf[i] = "C";
                }
                else if (total[i] >= 20 && total[i] <= 39)
                {
                    huruf[i] = "D";
                }
                else if (total[i] >= 0 && total[i] <= 19)
                {
                    huruf[i] = "E";
                }

            }
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("Sistem Akademik UNAS");
            Console.WriteLine("=========================================");
            Console.WriteLine("No | Nama Mahasiswa | Kuis | UTS | UAS | Total | Nilai |");
            Console.WriteLine("=========================================");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + nama[i] + "\t" + kuis[i] + "\t" + uts[i] + "\t" + uas[i] + "\t" + total[i] + "\t" + huruf[i]);
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("Terima Kasih");
            Console.Read();
        }
    }
}
