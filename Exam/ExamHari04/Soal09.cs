using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari04
{
    class Soal09 : LogicBase
    {
        public Soal09(int n, int bgn)
        {
            jmlhBaris = n;
            jmlhKolom = (n * bgn) - (bgn - 1);
            jmlhBangun = bgn;
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
                    int angka = 1;
                    for (int k = 0; k < jmlhKolom; k++)
                    {
                        if (b + k >= jmlhBaris/2 && k - b <= jmlhBaris/2 && b <= jmlhBaris/2 && k <= jmlhBaris/2)
                        {
                            Array2D[b, k + ((jmlhBaris - 1) * bgn)] = angka.ToString();
                            Array2D[jmlhBaris - 1 - b, k + ((jmlhBaris - 1) * bgn)] = angka.ToString();
                            Array2D[b, (jmlhBaris - 1 - k) + ((jmlhBaris - 1) * bgn)] = angka.ToString();
                            Array2D[jmlhBaris - 1 - b, (jmlhBaris - 1 - k) + ((jmlhBaris - 1) * bgn)] = angka.ToString();
                            angka += 2;
                        }
                    }
                }
            }
        }
    }
}
