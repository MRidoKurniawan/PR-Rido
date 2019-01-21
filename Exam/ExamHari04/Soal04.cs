using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari04
{
    class Soal04 : LogicBase
    {
        public Soal04(int n)
        {
            jmlhBaris = n;
            jmlhKolom = n * 2 - 1;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int b = 0; b < jmlhBaris; b++)
            {
                int ascii = 65;
                for (int k = 0; k < jmlhKolom; k++)
                {
                    if (b + k >= jmlhBaris - 1 && k - b <= jmlhBaris - 1)
                        Array2D[b, k] = ((char)ascii++).ToString();
                }
            }
        }
    }
}
