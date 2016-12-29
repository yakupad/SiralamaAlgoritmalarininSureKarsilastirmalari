using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM2116ODEV2_SORT
{
    public class SelectionSort
    {
        public void SelectionSorting(int[] dizi)
        {
            int n = dizi.Length;
            int minIndis = 0;

            for (int i = 0; i < n; i++)
            {
                minIndis = i;
                for (int j = i+1; j < n; j++)
                {
                    if (dizi[j] < dizi[minIndis])
                        minIndis = j;
                }

                if(minIndis!=i)
                {
                    int temp = dizi[i];
                    dizi[i] = dizi[minIndis];
                    dizi[minIndis] = temp;
                }
            }

        }
    }
}
