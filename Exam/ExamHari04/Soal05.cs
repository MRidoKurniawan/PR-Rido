using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari04
{
    class Soal05:LogicBase
    {
        public Soal05(int n)
        {
            jmlhBaris = n;
            jmlhKolom = jmlhBaris * 2 - 1;
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
                    if (b <= k && b + k <= jmlhKolom - 1)
                        Array2D[b, k] = ((char)ascii++).ToString();
                }
            }
        }
    }
}
