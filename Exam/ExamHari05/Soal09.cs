using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari05
{
    class Soal09 : LogicBase
    {
        public Soal09(int n)
        {
            jmlhBangun = n;
            jmlhBaris = (n * n + n) / 2;
            jmlhKolom = n * 2 - 1;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int bgn = 0; bgn < jmlhBangun; bgn++)
            {
                int strB = (bgn * bgn + bgn) / 2;
                int strK = ((jmlhBangun * 2 - 1) / 2) - bgn;
                int endB = strB + bgn;
                int endK = strK + (bgn * 2);

                for (int b = strB; b <= endB; b++)
                {
                    for (int k = strK; k <= endK; k++)
                    {
                        if (b + k >= strK + endB && b - k >= endB - endK)
                        {
                            Array2D[b, k] = "*";
                        }
                    }
                }
            }
        }
    }
}
