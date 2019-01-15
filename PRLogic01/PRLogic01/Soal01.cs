using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLogic01
{
    class Soal01
    {
        public Soal01()
        {
            Console.Write("Masukkan Nilai n :");
            int n = int.Parse(Console.ReadLine());
            //Baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    //PINDAH KOLOM

                    //Console.Write("\t*");

                    //Console.Write("\t{0}|{1}", b, k);

                    if (b == k)
                    {
                        //Console.Write("\t{0}{1}", b, k);
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }

                //pindah baris
                Console.WriteLine("\n");
            }

            //tahan cetakan
            Console.WriteLine("Tekan Tombol Sembarangan");
            Console.ReadKey();
        }
    }
}
