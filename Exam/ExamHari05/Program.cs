﻿using System;
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
                Console.Write("Masukan Nilai n : ");
                int n = int.Parse(Console.ReadLine());
                //Console.Write("Masukan Nilai n2 : ");
                //int n2 = int.Parse(Console.ReadLine());

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
                        Soal09 s9 = new Soal09(n);
                        break;

                    case 10:
                        Soal10 s10 = new Soal10(n);
                        break;

                    case 11:
                        SoalPR1 s11 = new SoalPR1(n);
                        break;

                    case 12:
                        SoalPR2 s12 = new SoalPR2(n);
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
