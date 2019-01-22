using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamReview45
{
    class Soal03 : LogicBase
    {
        public Soal03(int n, int bgn)
        {
            jmlhBangun = bgn;
            jmlhBaris = n;
            jmlhKolom = (n * bgn) - (bgn - 1);
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int bgn = 0; bgn < jmlhBangun; bgn++)
            {
                for (int b = 0; b < jmlhBaris; b++)
                {
                    int ascii = 65;
                    for (int k = 0; k < jmlhKolom; k++)
                    {
                        if (b + k == jmlhBaris / 2)
                        {
                            Array2D[b, k + ((jmlhBaris - 1) * bgn)] = ((char)ascii).ToString();
                            Array2D[jmlhBaris - 1 - b, k + ((jmlhBaris - 1) * bgn)] = ((char)ascii).ToString();
                            Array2D[b, (jmlhBaris - 1 - k) + ((jmlhBaris - 1) * bgn)] = ((char)ascii).ToString();
                            Array2D[jmlhBaris - 1 - b, (jmlhBaris - 1 - k) + ((jmlhBaris - 1) * bgn)] = ((char)ascii).ToString();
                        }
                    }
                }
            }
        }
    }
}
