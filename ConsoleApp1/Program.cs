using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UASPAW_Administrasi
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>
    /// class Administrasi merupakan class objek untuk memasukan data nama, NIS, kelas, alamat, JK, walas
    /// </remarks>
    public class Administrasi
    {
        /// <summary>
        /// operasi variable data siswa
        /// </summary>
        /// <code>
        /// </code>
        /// <param name="n">
        /// </param>

        public void administrasi()
        {
            ///<summary>
            /// mendefinisikan variable data siswa yang bertipe string dengan panjang data masing masing 35
            ///</summary>
            ///<example>
            ///masukkan nama : nanda
            ///</example>

            string[] nama = new string[35];
            string[] NIS = new string[35];
            string[] kelas = new string[35];
            string[] alamat = new string[35];
            string[] JK = new string[35];
            string[] walas = new string[35];

            int i, n = 0;
            //menginput jumlah data siswa yang ingin dimasukkan
            Console.WriteLine(" DATA ADMINISTRASI SISWA ");
            Console.WriteLine("=========================");
            Console.Write("Masukan Jumlah Siswa = ");
            Console.Write("\n");
            n = int.Parse(Console.ReadLine());
            //Mengisi data yang di input user dengan perulangan For
            ///<summary>
            ///variable untuk mengisi data  yang diinput user yaitu nama,NIS,JK,alamat,kelas,walas
            ///</summary>
            ///<param>
            ///</param>
            for (i = 1; i <= n; i++)
            {
                //Menampilkan 'Masukan data siswa ke-' variable i
                Console.WriteLine("Masukan data siswa ke-" + i);
                Console.WriteLine("=========================");
                Console.WriteLine("\n");
                //Menampilkan Masukan nama siswa
                Console.Write("Masukan nama siswa = ");
                nama[i] = Console.ReadLine();
                //Menampilkan Masukan Nomor Induk Siswa
                Console.Write("Masukan Nomor Induk Siswa = ");
                NIS[i] = Console.ReadLine();
                //Menampilkan Masukan Jenis Kelamin
                Console.Write("Masukan jenis kelamin = ");
                JK[i] = Console.ReadLine();
                //Menampilkan Masukan alamat
                Console.Write("Masukan alamat = ");
                alamat[i] = Console.ReadLine();
                //Menampilkan Masukan Kelas
                Console.Write("Masukan kelas = ");
                kelas[i] = Console.ReadLine();
                //Menampilkan Masukan Wali Kelas
                Console.Write("Masukan nama wali kelas = ");
                walas[i] = Console.ReadLine();
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.Write("Tekan 'ENTER' untuk menampilkan data");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("     DATA ADMINISTRASI SISWA YANG DI INPUT       ");
            Console.WriteLine("=================================================");
            Console.Write("\n");
            Console.WriteLine("NO  |  Nama  |  NIS  |  Jenis Kelamin  |  Alamat  |  Kelas  |  Wali Kelas");

            //Menampilkan hasil dari data yg telah di masukan oleh user dengan perulangan for
            ///<summary>
            ///menginisialisasi untuk menampilkan data setiap siswa yang disimpan sesuai dengan formatnya
            ///</summary>
            ///<param>
            ///for (i = 1; i <= n; i++) untuk mengeksekusi perintah-perintah yang ada di dalamnya sebanyak "n" kali
            ///</param>
            ///<example>
            ///1. nana  | 202101400 | Pr | Sleman | A | Heru
            ///</example>
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(" " + i + "      " + nama[i] + "\t" + NIS[i] + "\t" + JK[i] + "\t          " + alamat[i] + "\t" + kelas[i] + "\t" + walas[i]);



            }
            Console.WriteLine();
            Console.Write("Press any key....");
            Console.ReadLine();
        }

        /// <summary>
        /// Di dalam Main()metode, turunan kelas Administrasidibuat dengan memanggil konstruktornya dengan newkata kunci. 
        /// Kemudian, administrasi()metode kelas Administrasidipanggil menggunakan instance yang dibuat Admnst. 
        /// Tujuan kode ini adalah menjalankan administrasi()metode kelas Administrasi, 
        /// yang mungkin berisi fungsionalitas untuk mengelola tugas administratif.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Memanggil class administrasi
            Administrasi Admnst = new Administrasi();
            Admnst.administrasi();
        }
    }
}
