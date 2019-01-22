using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari05
{
    class SoalPR1 : LogicBase
    {
        public SoalPR1(int n)
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
                int strK = (jmlhBangun - 1 - bgn) * (jmlhBangun - 1 - bgn);
                int endB = strB + (jmlhBangun - 1 - bgn);
                int endK = strK + ((jmlhBangun - 1 - bgn) * 2);

                int index = 0;
                int[] fibo = functionBase.Fibonacci(jmlhKolom * jmlhBangun);
                for (int b = strB; b <= endB; b++)
                {
                    for (int k = strK; k <= endK; k++)
                    {
                        if (b + k >= strK + endB && b - k >= endB - endK)
                            Array2D[b, k] = fibo[index++].ToString();
                    }
                }
            }
        }
    }
}
