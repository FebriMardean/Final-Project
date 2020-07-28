using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = (" Final Project Mata Kuliah Pemrogaman ");

            List<Kabupaten> listKabupaten = new List<Kabupaten>();

            void Kasus(string nama, string kodekab, int odp, int pdp, int positif)
            {
                listKabupaten.Add(new Kasus { Nama = nama, KodeKab = kodekab, ODP = odp, PDP = pdp, Positif = positif });
            }

            void tampildata()
            {
                int nourut = 1;

                foreach (Kabupaten kabupaten in listKabupaten)
                {
                    Console.WriteLine(" {0}.\t{1} \t\t{2} \t\t{3}", nourut, kabupaten.Nama, kabupaten.KodeKab, kabupaten.Area());
                    nourut++;
                }
            }

            void hapusdata()
            {
                Console.WriteLine(" Data Kabupaten");
                Console.WriteLine();
                Console.WriteLine(" No \tNama Kabupaten \tKode Kabupaten \tJumlah Kasus");
                Console.WriteLine("===========================================================");
                Console.WriteLine();
                tampildata();
                Console.WriteLine();
                Console.WriteLine(" Ketikkan nama Kabupaten yang ingin di hapus ");
                Console.Write(" Nama   : ");
                string nama = Console.ReadLine();
                Kabupaten delete = listKabupaten.SingleOrDefault(x => x.Nama == nama);
                if (listKabupaten.Contains(delete) == true)
                {
                    listKabupaten.Remove(delete);
                    Console.WriteLine(" Data Kabupaten berhasil dihapus");
                }
                else
                {
                    Console.WriteLine("\nKabupaten tidak ditemukan");
                }
            }

            void tambahdata()
            {
                int i, a;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Tambah Data ");
                Console.WriteLine("=====================================");
                Console.WriteLine();
                Console.WriteLine(" Masukkan jumlah data");
                a = int.Parse(Console.ReadLine());
                for (i=1; i<=a; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Input data ke -" + i );
                    Console.Write(" Nama             = ");
                    string nama = Console.ReadLine();
                    Console.Write(" Kode Kab         = ");
                    string kodekab = Console.ReadLine();
                    Console.Write(" Jumlah Kasus ODP = ");
                    int odp = int.Parse(Console.ReadLine());
                    Console.Write(" Jumlah Kasus PDP = ");
                    int pdp = int.Parse(Console.ReadLine());
                    Console.Write(" Jumlah Kasus Positif = ");
                    int positif = int.Parse(Console.ReadLine());

                    Kasus(nama, kodekab, odp, pdp, positif);
                }

               
            }

            bool status = false;
            while (status == false)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine(" Program Pendataan Jumlah Kasus");
                Console.WriteLine("         Covid 19 di DIY");
                Console.WriteLine("================================");
                Console.WriteLine(" Pilih menu Aplikasi");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("\n 1. Tambah Kabupaten");
                Console.WriteLine(" 2. Hapus Kabupaten");
                Console.WriteLine(" 3. Tampilkan Kabupaten");
                Console.WriteLine(" 4. Keluar");
                Console.WriteLine();
                Console.Write(" Nomor Menu [1..4] = ");
                string menu = Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
                if (menu == "1")
                { 
                    tambahdata();
                    Console.WriteLine();
                    Console.WriteLine(" Tekan Sembarang Untuk Kembali ke Menu Awal");
                }
                else if (menu == "2")
                {
                    
                    hapusdata();
                    Console.WriteLine();
                    Console.WriteLine(" Tekan Sembarang Untuk Kembali ke Menu Awal");
                }
                else if (menu == "3")
                {
                    Console.WriteLine(" Data Kabupaten");
                    Console.WriteLine();
                    Console.WriteLine(" No \tNama Kabupaten \tKode Kabupaten \tJumlah Kasus");
                    Console.WriteLine("===========================================================");
                    tampildata();
                    Console.WriteLine();
                    Console.WriteLine(" Tekan Sembarang Untuk Kembali ke Menu Awal");
                }
                else if (menu == "4")
                {
                    status = true;
                    Console.WriteLine(" Tekan Sembarang Untuk Keluar");
                }
                else
                {
                    Console.WriteLine(" Tekan Sembarang Untuk Kembali ke Menu Awal");
                }
                Console.ReadKey();
            }
        }
    }
}
