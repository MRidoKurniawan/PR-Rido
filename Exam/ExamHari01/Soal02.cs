using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari01
{
    class Soal02
    {
        public Soal02()
        {
            Console.Write("Masukkan Nilai n : ");
            int n = int.Parse(Console.ReadLine());

            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (b + k == n - 1)
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }

                Console.Write("\n\n");
            }

            Console.ReadKey();
        }
    }
}
