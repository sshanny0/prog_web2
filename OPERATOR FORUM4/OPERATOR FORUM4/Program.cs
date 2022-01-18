using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATOR_FORUM4
{
    class Program
    {
        static void Main(string[] args)
        {
            int P, l, a;
            int K, S;

            Console.WriteLine("==================================");
            Console.WriteLine("Program menghitung Sisa Pendapatan");
            Console.WriteLine("==================================");
            Console.Write("Masukkan pendapatan: ");
            P = int.Parse(Console.In.ReadLine());
            Console.Write("Pembayaran uang kos: ");
            l = int.Parse(Console.In.ReadLine());
            Console.Write("Pembayaran uang kuliah: ");
            a = int.Parse(Console.In.ReadLine());
            K = (l + a);
            S = (P - K);
            Console.WriteLine("Jadi total pengeluaran adalah: " + K);
            Console.WriteLine("Sisa uang bulanan yang bisa ditabung adalah: " + S);
            Console.ReadLine();
        }
    }
}
