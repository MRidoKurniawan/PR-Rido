using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t\t\t----------- Logic Hari 05 ------------\n\n");

            string jawab = "y";
            while (jawab.ToLower() == "y")
            {
                Console.Write("Masukan Nilai n1 : ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai n2 : ");
                int n2 = int.Parse(Console.ReadLine());

                Console.Write("\nMasukan No Soal yang di pilih : ");
                int soal = int.Parse(Console.ReadLine());

                switch (soal)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:
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
