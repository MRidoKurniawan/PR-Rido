using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03
{
    class Soal02 : LogicBase
    {
        public Soal02(int n)
        {
            jmlhBaris = 1;
            jmlhKolom = n;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            CetakArray();
        }

        private void IsiArray()
        {
            int[] tribo = functionBase.Tribonacci(jmlhKolom);
            for (int k = 0; k < jmlhKolom; k++)
            {
                Array2D[0, k] = tribo[k].ToString();
            }
        }

        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLongLength(1); k++)
                {
                    Console.Write("{0}\t", Array2D[b, k]);
                }

                Console.Write("\n\n");
            }
        }
    }
}
