using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamReview45
{
    class Soal02 : LogicBase
    {
        public Soal02(int n)
        {
            jmlhBaris = n;
            jmlhKolom = n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int index = 0;
            int ascii = 65;

            int[] fibo = functionBase.Fibonacci(jmlhBaris * jmlhKolom);
            int[] tribo = functionBase.Tribonacci(jmlhBaris * jmlhKolom);

            for (int b = 0; b < jmlhBaris; b++)
            {
                for (int k = 0; k < jmlhKolom; k++)
                {
                    if (b + k >= jmlhKolom/2 && k - b <= jmlhKolom / 2 && b < jmlhBaris / 2)
                    {
                        Array2D[b, k] = fibo[index].ToString();
                        Array2D[jmlhBaris - 1 - b, k] = tribo[index].ToString();
                        index++;
                    }
                    else if (b == jmlhBaris / 2 && k <= jmlhKolom / 2)
                    {
                        Array2D[b, k] = ((char)ascii).ToString();
                        Array2D[b, jmlhKolom - 1 - k] = ((char)ascii).ToString();
                        ascii++;
                    }
                }
            }
        }
    }
}
