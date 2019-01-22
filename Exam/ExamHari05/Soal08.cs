using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari05
{
    class Soal08 : LogicBase
    {
        public Soal08(int n)
        {
            jmlhBangun = n;
            jmlhBaris = (n * n + n) / 2;
            jmlhKolom = jmlhBaris;
            Array2D = new string[jmlhBaris, jmlhKolom];
            IsiArray();
            functionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            //value
            int ganjil = 1;
            int genap = 2;

            for (int bgn = 0; bgn < jmlhBangun; bgn++)
            {
                int strB = (bgn * bgn + bgn) / 2;
                int strK = strB;
                int endB = strB + bgn;
                int endK = endB;

                //flow
                bool kanan = true;
                //string arah = "kanan";

                for (int b = strB; b <= endB; b++)
                {
                    for (int k = strK; k <= endK; k++)
                    {
                        Array2D[b, kanan ? k : endK - k + strK] = bgn % 2 == 0 ? ganjil.ToString() : genap.ToString();
                        if (bgn % 2 == 0)
                            ganjil += 2;
                        else
                            genap += 2;

                        /*if (kanan)
                        {
                            if (bgn % 2 == 0)
                            {
                                Array2D[b, k] = ganjil.ToString();
                                ganjil += 2;
                            }
                            else
                            {
                                Array2D[b, k] = genap.ToString();
                                genap += 2;
                            }
                        }
                        else
                        {
                            if (bgn % 2 == 0)
                            {
                                Array2D[b, endK - k + strK] = ganjil.ToString();
                                ganjil += 2;
                            }
                            else
                            {
                                Array2D[b, endK - k + strK] = genap.ToString();
                                genap += 2;
                            }
                        }*/
                    }
                    kanan = !kanan;

                    /*if (arah == "kanan")
                        arah = "kiri";
                    else
                        arah = "kanan";*/
                }
            }
        }
    }
}
