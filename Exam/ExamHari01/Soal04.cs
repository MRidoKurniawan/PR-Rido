using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari01
{
    class Soal04
    {
        public Soal04()
        {
            Console.Write("Masukkan Nilai n :");
            int n = int.Parse(Console.ReadLine());

            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (n % 2 == 1)
                    {
                        if (b == k || b + k == n - 1 || b == n / 2 || k == n / 2)
                            Console.Write("*\t");
                        else
                            Console.Write("\t");
                    }
                    else
                    {
                        int c = n / 2 - 1;
                        if (b == k || b + k == n - 1 || b == n / 2 || k == n / 2 || b == c || k == c)
                            Console.Write("*\t");
                        else
                            Console.Write("\t");
                    }
                }

                Console.Write("\n\n");
            }
            
            Console.ReadKey();
        }
    }
}
