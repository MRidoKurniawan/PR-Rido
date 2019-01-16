using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari2
{
    class Soal04
    {
        public Soal04(int n)
        {
            CetakPola(n, n);
        }

        private void CetakPola(int jb, int jk)
        {
            for (int b = 0; b < jb; b++)
            {
                for (int k = 0; k < jk; k++)
                {
                    if (b == k || k == jk / 2)
                        Console.Write("{0}\t", b * 2 + 1);
                    else if (b + k == jb - 1 || b == jb / 2)
                        Console.Write("{0}\t", k * 2);
                    else
                        Console.Write("\t");
                }

                Console.Write("\n\n");
            }
        }
    }
}
