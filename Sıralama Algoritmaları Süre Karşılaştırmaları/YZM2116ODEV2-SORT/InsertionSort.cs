using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM2116ODEV2_SORT
{
    public class InsertionSort
    {
        public void InsertionSorting(int[] dizi)
        {
            int j, moved;
            for (int i = 1; i < dizi.Length; i++)
            {
                moved = dizi[i];
                j = i;
                while (j>0&&dizi[j-1]>moved)
                {
                    dizi[j] = dizi[j - 1];
                    j--;
                }
                dizi[j] = moved;
            }
        }
    }
}
