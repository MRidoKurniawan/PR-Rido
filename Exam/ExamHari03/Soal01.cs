using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class Soal01: LogicBase
    {
        public Soal01(int n)
        {
            //jmlhBaris = n; (untuk array 2D)
            jmlhBaris = 1;
            jmlhKolom = n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            CetakArray();
        }

        private void IsiArray()
        {
            /*Console.WriteLine("Nilai jumlah Baris : {0}", jmlhBaris);
            Console.WriteLine("Nilai jumlah Kolom : {0}", jmlhKolom);
            Console.WriteLine("Jumlah             : {0}", jmlhBaris * jmlhKolom);

            for (int b = 0; b < jmlhBaris; b++)
            {
                for (int k = 0; k < jmlhKolom; k++)
                {
                    if (b == k)
                        Array2D[b, k] = (k * 2 + 1).ToString();
                    else if (b + k == jmlhBaris - 1)
                        Array2D[b, k] = (k * 2).ToString();
                }
            }*/

            int[] fibo = functionBase.Fibonacci(jmlhKolom);
            for (int k = 0; k < jmlhKolom; k++)
            {
                Array2D[0, k] = fibo[k].ToString();
            }
        }

        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    Console.Write("{0}\t", Array2D[b, k]);
                }
                Console.Write("\n\n");
            }
        }
    }
}
