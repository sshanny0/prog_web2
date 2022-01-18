using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_SDA
{
    class Program
    {
        class menu
        {
            public String nama;
            public menu next;
        }
        static void Main(string[] args)
        {
            Console.WriteLine ("Selamat Datang di rumah makan sejahtera!");
            Console.WriteLine("\nBerikut adalah daftar menu kami: \n\n");

            menu menu_1 = new menu();
            menu menu_2 = new menu();
            menu menu_3 = new menu();
            menu menu_4 = new menu();
            menu menu_5 = new menu();
            menu menu_6 = new menu();

            menu_1.nama = "Nasi Goreng";
            menu_2.nama = "Mie Goreng";
            menu_3.nama = "Martabak Telur";
            menu_4.nama = "Es Jeruk";
            menu_5.nama = "Air Mineral";
            menu_6.nama = "Es Teh Manis";

            menu_1.next = menu_2;
            menu_2.next = menu_3;
            menu_3.next = menu_4;
            menu_4.next = menu_5;
            menu_5.next = menu_6;

            while (menu_1 != null)
            {
                Console.WriteLine(menu_1.nama);
                menu_1 = menu_1.next;
            }
            Console.WriteLine("\n\nTerima kasih dan selamat menikmati ");

            Console.ReadKey();
        }
    }
}
