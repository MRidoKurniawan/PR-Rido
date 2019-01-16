using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari2
{
    class Soal09
    {
        public Soal09(int n)
        {
            CetakPola(n);
        }

        private void CetakPola(int n)
        {
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k <= n / 2)
                        Console.Write("{0}\t", k * 2 + 1);
                    else if (k >= n / 2)
                        Console.Write("{0}\t", (n-1-k)*2 + 1);
                    else
                        Console.Write("\t");
                }

                Console.Write("\n\n");
            }
        }
    }
}
