﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari2
{
    class Soal07
    {
        public Soal07(int n)
        {
            CetakPola(n);
        }

        private void CetakPola(int n)
        {
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k == b)
                        Console.Write("{0}\t", b * 2 + 1);
                    else if (k + b == n - 1)
                        Console.Write("{0}\t", k * 2);
                    else if (b < k && b + k < n - 1)
                        Console.Write("A\t");
                    else if (b > k && b + k > n - 1)
                        Console.Write("B\t");
                    else
                        Console.Write("\t");
                }

                Console.Write("\n\n");
            }
        }
    }
}
