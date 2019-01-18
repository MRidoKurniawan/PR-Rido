using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
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
                    int ascii = 64;

                    if (b <= k && b + k <= jmlhBaris - 1)
                    {
                        /*if (b % 2 == 0)
                        {
                            Array2D[b, k] = fibo[b / 2].ToString();
                            Array2D[jmlhBaris - 1 - b, k] = fibo[b / 2].ToString();
                        }
                        else
                        {
                            Array2D[b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                            Array2D[b, jmlhKolom - 1 - k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        }*/

                        Array2D[b, k] = b % 2 == 0 ? fibo[b / 2].ToString() : ((char)(ascii + (b + 1) / 2)).ToString();
                        Array2D[jmlhKolom - 1 - b, k] = b % 2 == 0 ? fibo[b / 2].ToString() : ((char)(ascii + (b + 1) / 2)).ToString();
                    }
                    else if (b >= k && b + k <= jmlhKolom - 1)
                    {
                        Array2D[b, k] = k % 2 == 0 ? fibo[k / 2].ToString() : ((char)(ascii + (k + 1) / 2)).ToString();
                        Array2D[b, jmlhKolom - 1 - k] = k % 2 == 0 ? fibo[k / 2].ToString() : ((char)(ascii + (k + 1) / 2)).ToString();
                    }
                }
            }
        }
    }
}
