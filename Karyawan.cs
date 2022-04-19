using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4315
{
    class Karyawan
    {
        private string nama;
        private string nik;
        private int gajibulanan;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Nik
        {
            get { return nik; }
            set { nik = value; }
        }

        public int GajiBulanan
        {
            get { return gajibulanan; }
            set { gajibulanan = value; }
        }
        public Karyawan(string nama, string nik, int gajibulanan)
        {
            this.nama = nama;
            this.nik = nik;
            this.gajibulanan = gajibulanan < 0 ? 0 : gajibulanan;
        }

        public void CetakHasil()
        {
            Console.WriteLine("{0} {1}      {2}", nik, nama, gajibulanan);
        }

        public void gajinaik()
        {
            int naik;
            naik = gajibulanan * 110;
            gajibulanan = naik / 100;
            Console.WriteLine("naik gaji 10%");
        }
    }
}
