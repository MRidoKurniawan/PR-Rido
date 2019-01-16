using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = 9;
            int j = 3;
            for (int i = 0; i < 9; i++)
            {
                Console.Write("\t {0}{1}{0}", i, j);
            }
            Console.ReadKey();*/

            string jawab = "y";
            while (jawab.ToLower() == "y")
            {
                Console.Write("Masukan Nilai n :");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Pilih Nomor Soal :");
                int soal = int.Parse(Console.ReadLine());

                switch (soal)
                {
                    case 1:
                        Soal01 s1 = new Soal01();
                        break;

                    case 2:
                        Soal02 s2 = new Soal02();
                        break;

                    case 3:
                        soal03 s3 = new soal03();
                        break;

                    case 4:
                        Soal04 s4 = new Soal04();
                        break;

                    case 5:
                        Soal05 s5 = new Soal05();
                        break;

                        //Menggunakan Parameter
                    case 6:
                        Soal06 s6 = new Soal06(n);
                        break;

                    case 7:
                        Soal07 s7 = new Soal07(n);
                        break;

                    case 8:
                        Soal08 s8 = new Soal08(n);
                        break;

                    case 9:
                        Soal09 s9 = new Soal09(n);
                        break;

                    case 10:
                        Soal10 s10 = new Soal10(n);
                        break;

                    default:
                        Console.Write("Soal Tidak Ditemukan....");
                        break;
                }

                //ganjelan
                Console.Write("Apakah ingin Mengulang Kembalai ? [Y/T]");
                jawab = Console.ReadLine();
            }
        }
    }
}
