using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCEDURE02
{
    class datadiri
    {
        private void input()
        {
            String NL, NP, TTL, SMP, ALAMAT, TB, CITA2, AGAMA, HOBI;
        }
    }
}

namespace MAINPROCEDURE
    {
        class Program
        {
            static void Main(string[] args)
            {
                PROCEDURE02.datadiri datadiri = new PROCEDURE02.datadiri();
                Console.WriteLine();
                Console.Write("NAMA LENGKAP: ");
                string NL = Console.ReadLine();
                Console.Write("NAMA PANGGILAN: ");
                string NP = Console.ReadLine();
                Console.Write("TTL: ");
                string TTL = Console.ReadLine();
                Console.Write("ASAL SMP: ");
                string SMP = Console.ReadLine();
                Console.Write("ALAMAT: ");
                string ALAMAT = Console.ReadLine();
                Console.Write("TINGGI/BERAT: ");
                string TB = Console.ReadLine();
                Console.Write("CITA-CITA: ");
                string CITA2 = Console.ReadLine();
                Console.Write("AGAMA: ");
                string AGAMA = Console.ReadLine();
                Console.Write("HOBI: ");
                string HOBI = Console.ReadLine();

                Console.ReadLine();
            }
        }
    }
