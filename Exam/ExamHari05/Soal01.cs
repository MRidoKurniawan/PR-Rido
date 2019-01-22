using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari05
{
    class Soal01 : LogicBase
    {
        public Soal01(int n)
        {
            jmlhBangun = n;
            jmlhBaris = (n * n + n) / 2;
            jmlhKolom = jmlhBaris;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int bgn = 0; bgn < jmlhBangun; bgn++)
            {
                // Starting Point
                int strB = (bgn * bgn + bgn) / 2;
                int strK = strB;

                // Ending Point
                int endB = strB + bgn;
                int endK = endB;

                for (int b = strB; b <= endB; b++)
                {
                    for (int k = strK; k <= endK; k++)
                    {
                        Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}
