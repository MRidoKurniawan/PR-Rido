using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari2
{
    class Soal1
    {
        public Soal1(int n)
        {
            CetakPola(n, n);
        }

        private void CetakPola(int jb, int jk)
        {
            //int ganjil = 1;

            for (int b = 0; b < jb; b++)
            {
                for (int k = 0; k < jk; k++)
                {
                    if (k == b)
                    {
                        //Console.Write("{0}\t", ganjil);
                        //ganjil = ganjil + 2;
                        //ganjil += 2;

                        Console.Write("{0}\t", b * 2 + 1);
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }

                Console.Write("\n\n");
            }
        }
    }
}
