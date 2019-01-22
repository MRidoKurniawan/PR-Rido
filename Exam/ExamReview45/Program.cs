using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamReview45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t\t\t----------- Logic Hari 05 ------------\n\n");

            string jawab = "y";
            while (jawab.ToLower() == "y")
            {
                Console.Write("Masukan Nilai n : ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("\nMasukan No Soal yang di pilih : ");
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
                        Console.Write("Masukan Jumlah Bangun : ");
                        int bgn = int.Parse(Console.ReadLine());

                        Soal03 s3 = new Soal03(n, bgn);
                        break;

                    default:
                        Console.Write("\nPilihan Nomor Soal Tidak Ditemukan !!!");
                        break;
                }

                // ganjelan
                Console.Write("\n\nApakah Ingin Berlanjut ? [Y/T]");
                jawab = Console.ReadLine();
            }
        }
    }
}
