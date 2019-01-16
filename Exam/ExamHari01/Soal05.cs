using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari01
{
    class Soal05
    {
        public Soal05()
        {
            Console.Write("Masukkan Nilai N : ");
            int n = int.Parse(Console.ReadLine());

            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (b == k || b + k == n - 1 || b == 0 || k == 0 || b == n-1 || k == n-1)
                    //if (b == k || b+k == n-1 || b+k == k || b+k == b || b+k == k + n-1 || b+k == b + n-1)
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
