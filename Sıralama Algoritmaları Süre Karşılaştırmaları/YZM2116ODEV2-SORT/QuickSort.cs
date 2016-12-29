using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM2116ODEV2_SORT
{
    public class QuickSort
    {
        public void QuickSorting(int[] dizi,int altindis,int ustindis)
        {
            int yeni_altindis = altindis, yeni_ustindis = ustindis, h;
            int pivot = dizi[(altindis + ustindis) / 2];

            do
            {
                while (dizi[yeni_altindis]<pivot)
                {
                    yeni_altindis++;
                }
                while (dizi[yeni_ustindis]>pivot)
                {
                    yeni_ustindis--;
                }
                if (yeni_altindis<=yeni_ustindis)
                {
                    h = dizi[yeni_altindis];
                    dizi[yeni_altindis] = dizi[yeni_ustindis];
                    dizi[yeni_ustindis] = h;
                    yeni_altindis++;
                    yeni_ustindis--;
                }
            } while (yeni_altindis<=yeni_ustindis);
            if (altindis < yeni_ustindis)
                QuickSorting(dizi, altindis, yeni_ustindis);
            if (yeni_altindis < ustindis)
                QuickSorting(dizi, yeni_altindis, ustindis);
        }
    }
}
