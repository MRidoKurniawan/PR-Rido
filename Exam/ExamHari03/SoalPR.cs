using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class SoalPR : LogicBase
    {
        public SoalPR(int n)
        {
            jmlhBaris = n;
            jmlhKolom = n * 2 - 1;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int ascii = 65;
            int[] Fibo = functionBase.Fibonacci(jmlhKolom);
            for (int b = 0; b < jmlhBaris; b++)
            {
                for (int k = 0; k < jmlhKolom; k++)
                {
                    if (b == k)
                    {
                        Array2D[b, k] = Fibo[b].ToString();
                        Array2D[b, jmlhKolom - k - 1] = Fibo[b].ToString();
                    }
                    else if (b == jmlhBaris / 2 && k <= jmlhKolom / 2)
                    {
                        Array2D[b, k] = ((char)ascii).ToString();
                        Array2D[b, jmlhKolom - k - 1] = ((char)ascii).ToString();
                        ascii++;
                    }
                    else if (b + k == (jmlhKolom - 1) / 2)
                    {
                        Array2D[b, k] = Fibo[k].ToString();
                        Array2D[b, jmlhKolom - k - 1] = Fibo[k].ToString();
                    }
                }
            }
        }
    }
}
