using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLogic01
{
    class Soal03
    {
        public Soal03()
        {
            //memasukkan inputan nilai N
            Console.Write("Masukkan Nilai N : ");
            int n = int.Parse(Console.ReadLine());

            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (b == k || b + k == n - 1)
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
