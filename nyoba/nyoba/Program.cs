using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyoba
{
    class circulary
    {
        public String nama;
        public circulary next;
    }
    class Program
    {
        static void Main(string[] args)
        {
            circulary tail = new circulary();
            circulary a = new circulary();
            a.nama = "Nabilah Ananda P";

            circulary b = new circulary();
            b.nama = "Shafira Shalehanny";

            circulary c = new circulary();
            c.nama = "Cintya Damayanti";

            circulary d = new circulary();
            d.nama = "Melati Indah P";

            circulary e = new circulary();
            e.nama = "Faza Nadhira";
            tail = e; //untuk menunjukkan bahwa c ada di posisi tail

            a.next = b; //untuk menghubungkan tiap list
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = a;

            while (tail != null)
            //perintah ini akan dilakukan terus menerus karena tail tidak pernah ‘null’
            {
                Console.WriteLine(tail.nama);
                tail = tail.next;
            }
            Console.ReadKey();
        }
    }
}
