using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class Soal07 : LogicBase
    {
        public Soal07(int n)
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
                for (int k = 0; k < jmlhKolom; k++)
                {
                    int[] fibo = functionBase.Fibonacci(jmlhKolom);
                    if (b <= k && b + k <= jmlhKolom - 1)
                    {
                        Array2D[b, k] = fibo[b].ToString();
                        Array2D[jmlhBaris - 1 - b, k] = fibo[b].ToString();
                    }
                    else if (b >= k && b + k <= jmlhKolom - 1 )
                    {
                        Array2D[b, k] = fibo[k].ToString();
                        Array2D[b, jmlhBaris - 1 - k] = fibo[k].ToString();
                    }
                }
            }
        }
    }
}
