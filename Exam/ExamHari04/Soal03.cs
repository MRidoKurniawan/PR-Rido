using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari04
{
    class Soal03 : LogicBase
    {
        public Soal03(int n)
        {
            jmlhBaris = n;
            jmlhKolom = n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int b = 0; b < jmlhBaris; b++)
            {
                int angka = 1;
                for (int k = 0; k < jmlhKolom; k++)
                {
                    if (b+k >= jmlhBaris/2 && k - b <= jmlhBaris/2 && b <= jmlhBaris / 2)
                    {
                        Array2D[b, k] = angka.ToString();
                        Array2D[jmlhBaris - 1 - b, k] = angka.ToString();
                        angka++;
                    }
                }
            }
        }
    }
}
