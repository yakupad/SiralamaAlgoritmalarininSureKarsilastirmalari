using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM2116ODEV2_SORT
{
    public class BubbleSort
    {
        public void BubbleSorting(int[] dizi)
        {
            int tarama;
            bool swapped = false;
            for (tarama = 0; tarama < dizi.Length; tarama++)
            {
                swapped = false;
                for (int i = 0; i <(dizi.Length-tarama-1); i++)
                {
                    if(dizi[i]>dizi[i+1])
                    {
                        int temp;
                        temp = dizi[i];
                        dizi[i] = dizi[i + 1];
                        dizi[i + 1] = temp;
                        swapped = true;
                    }

                }
                if (!swapped)
                    break;
            }
        }
    }
}
