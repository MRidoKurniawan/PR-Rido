using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBase
{
    public class LogicBase
    {
        public int jmlhBaris { get; set; }
        public int jmlhKolom { get; set; }
        public string[,] Array2D { get; set; }
    }

    public class functionBase
    {
        public static int[] Fibonacci(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                    result[pos] = 1;
                else
                    result[pos] = result[pos - 1] + result[pos - 2];
            }

            return result;
        }

        public static int[] Tribonacci(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 2)
                    result[pos] = 1;
                else
                    result[pos] = result[pos - 1] + result[pos - 2] + result[pos - 3];
            }

            return result;
        }

        public static void CetakArray(string[,] ar)
        {
            for (int b = 0; b < ar.GetLength(0); b++)
            {
                for (int k = 0; k < ar.GetLength(1); k++)
                {
                    Console.Write("{0}\t", ar[b, k]);
                }

                Console.Write("\n\n");
            }
        }
    }
}
