using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class Soal09 : LogicBase
    {
        public Soal09(int n)
        {
            jmlhBaris = n;
            jmlhKolom = n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] fibo = functionBase.Fibonacci(jmlhKolom);
            for (int b = 0; b < jmlhBaris; b++)
            {
                for (int k = 0; k < jmlhKolom; k++)
                {
                    //Atas
                    if (b <= k && b + k <= jmlhBaris - 1 && b % 2 == 0)
                    {
                        // Agar meloncat-loncat
                        Array2D[b, k] = fibo[b / 2].ToString();
                        //Miroring
                        Array2D[jmlhBaris - 1 - b, k] = fibo[b / 2].ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= jmlhKolom - 1 && k % 2 == 0)
                    {
                        Array2D[b, k] = fibo[k / 2].ToString();
                        Array2D[b, jmlhKolom - 1 - k] = fibo[k / 2].ToString();
                    }
                }
            }
        }
    }
}
