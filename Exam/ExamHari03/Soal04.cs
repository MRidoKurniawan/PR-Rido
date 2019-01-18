using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class Soal04 : LogicBase
    {
        public Soal04(int n)
        {
            jmlhBaris = 1;
            jmlhKolom = n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] tribo = functionBase.Tribonacci(jmlhKolom);
            for (int k = 0; k < jmlhKolom; k++)
            {
                if (k <= jmlhKolom / 2)
                {
                    // CARA MIRORRING
                    Array2D[0, k] = tribo[k].ToString();
                    Array2D[0, jmlhKolom - 1 - k] = tribo[k].ToString();
                }

                //else if (k >= jmlhKolom / 2)
                //    Array2D[0, k] = tribo[jmlhKolom - 1 - k].ToString();
            }
        }
    }
}
