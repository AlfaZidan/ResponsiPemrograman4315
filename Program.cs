using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4315
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("190302123", "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan("190302123", "Paijo", 2000000);

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("=============================");
            Console.Write("1 ");karyawan1.CetakHasil();
            Console.Write("2 ");karyawan1.CetakHasil();
            Console.WriteLine();
            karyawan1.naik();
            karyawan2.naik();

            Console.WriteLine();
            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); karyawan1.CetakHasil();
            Console.Write("2 "); karyawan2.CetakHasil();

            Console.WriteLine("tekan sembarang untuk keluar");
            Console.ReadKey();
        }
    }
}
