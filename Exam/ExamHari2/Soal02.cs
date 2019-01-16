using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari2
{
    class Soal02
    {
        public Soal02(int n)
        {
            CetakPola(n);
        }

        private void CetakPola(int n)
        {
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k + b == n - 1)
                        Console.Write("{0}\t", k * 2);
                    else
                        Console.Write("\t");
                }

                Console.Write("\n\n");
            }
        }
    }
}
