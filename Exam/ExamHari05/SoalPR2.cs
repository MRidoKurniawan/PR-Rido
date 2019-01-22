using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari05
{
    class SoalPR2 : LogicBase
    {
        public SoalPR2(int n)
        {
            jmlhBangun = n;
            jmlhBaris = (n * n + n) / 2;
            jmlhKolom = n * n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int bgn = 0; bgn < jmlhBangun; bgn++)
            {
                int strB = ((bgn * bgn + bgn) / 2) + ((jmlhBangun - bgn) * bgn);
                int strK = (bgn * bgn) + ((jmlhBangun - bgn) * bgn) * 2;
                int endB = strB + (jmlhBangun - 1 - bgn);
                int endK = strK + ((jmlhBangun - 1 - bgn) * 2);

                int index = 0;
                int[] tribo = functionBase.Tribonacci(jmlhKolom * jmlhBangun);
                for (int b = strB; b <= endB; b++)
                {
                    for (int k = strK; k <= endK; k++)
                    {
                        if (b + k >= strK + endB && k - b <= endK - endB)
                            Array2D[b, k] = tribo[index++].ToString();
                    }
                }
            }
        }
    }
}
