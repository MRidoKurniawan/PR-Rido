using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class Soal08 : LogicBase
    {
        public Soal08(int n)
        {
            jmlhBaris = n;
            jmlhKolom = n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            //int[] arr = new int[jmlhKolom];
            for (int b = 0; b < jmlhBaris; b++)
            {
                for (int k = 0; k < jmlhKolom; k++)
                {
                    //int[] arr = new int[jmlhKolom];
                    if (b <= k && b + k <= jmlhKolom - 1 && b % 2 == 0)
                    {
                        Array2D[b, k] = (b + 1).ToString();
                        Array2D[jmlhBaris - 1 - b, k] = (b + 1).ToString();
                    }
                    else if (b >= k && b + k <= jmlhKolom - 1 && k % 2 == 0)
                    {
                        Array2D[b, k] = (k + 1).ToString();
                        Array2D[b, jmlhBaris - 1 - k] = (k + 1).ToString();
                    }
                }
            }
        }
    }
}
