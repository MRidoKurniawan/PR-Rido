using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari05
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
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
                //valeu
                int[] fibo = functionBase.Fibonacci(jmlhKolom * jmlhKolom);
                int ganjil = 1;
                int angka = 0;

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
                            if (bgn % 2 == 0)
                            {
                                Array2D[b, k] = ganjil.ToString();
                                ganjil += 2;
                            }
                            else
                            {
                                Array2D[b, k] = fibo[angka++].ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
