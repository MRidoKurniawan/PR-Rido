using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari2
{
    class Soal10
    {
        public Soal10(int n)
        {
            CetakPola(n);
        }

        private void CetakPola(int n)
        {
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (b <= n / 2)
                        Console.Write("{0}\t", b * 2);
                    else if (b >= n / 2)
                        Console.Write("{0}\t", (n - 1 - b) * 2);
                    else
                        Console.Write("\t");
                }

                Console.Write("\n\n");
            }
        }
    }
}
