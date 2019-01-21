using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t\t-------------- EXAM HARI 04 ----------------\n\n\n");

            string jawab = "y";
            do
            {
                Console.Write("Masukkan Nilai n : ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Masukan Nomer Soal : ");
                int soal = int.Parse(Console.ReadLine());

                switch (soal)
                {
                    case 1:
                        Soal01 s1 = new Soal01(n);
                        break;

                    case 2:
                        Soal02 s2 = new Soal02(n);
                        break;

                    case 3:
                        Soal03 s3 = new Soal03(n);
                        break;

                    case 4:
                        Soal04 s4 = new Soal04(n);
                        break;

                    case 5:
                        Soal05 s5 = new Soal05(n);
                        break;

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
                        Console.Write("\nMasukan jumlah bangun yang ingin di cetak : ");
                        int bgn = int.Parse(Console.ReadLine());
                        Soal09 s9 = new Soal09(n, bgn);
                        break;

                    case 10:
                        Console.Write("\nMasukan jumlah bangun yang ingin di cetak : ");
                        bgn = int.Parse(Console.ReadLine());
                        Soal10 s10 = new Soal10(n, bgn);
                        break;
                        break;

                    default:
                        Console.Write("Nomer Soal Tidak ditemukan");
                        break;
                }

                //ganjelan
                Console.Write("\n\nApakah Ingin Mengulang Lagi ? [Y/T]");
                jawab = Console.ReadLine();
            } while (jawab.ToLower() == "y");
        }
    }
}
