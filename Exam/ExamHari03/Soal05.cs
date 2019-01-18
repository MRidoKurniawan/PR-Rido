using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class Soal05 : LogicBase
    {
        public Soal05(int n)
        {
            jmlhBaris = n;
            jmlhKolom = n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] fibo = functionBase.Fibonacci(jmlhBaris);
            for (int b = 0; b < jmlhBaris; b++)
            {
                for (int k = 0; k < jmlhKolom; k++)
                {
                    if ((b <= k || b + k >= jmlhKolom - 1) && (k <= jmlhKolom/2))
                        Array2D[b, k] = fibo[k].ToString();
                    else if ((b <= k || b + k >= jmlhKolom - 1) && (k >= jmlhKolom/2))
                        Array2D[b, k] = fibo[jmlhKolom - 1 - k].ToString();
                }
            }
        }
    }
}
