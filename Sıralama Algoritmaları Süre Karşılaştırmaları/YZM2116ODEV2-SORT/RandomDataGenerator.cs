using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZM2116ODEV2_SORT
{
    public class RandomDataGenerator
    {   

        /*
         TEK TEK DİZİ OLUŞTURMAK YERİNE 
         AGGED (DÜZENSİZ) İKİ BOYUTLU DİZİ OLUŞTURDUM)    
         */
        public int[][] randomdizi= new int[7][];
       
        public void RandomDataGeneratoring()
        {
            Random Random = new Random();

            randomdizi[0] = new int[100];
            randomdizi[1] = new int[750];
            randomdizi[2] = new int[1500];
            randomdizi[3] = new int[7500];
            randomdizi[4] = new int[15000];
            randomdizi[5] = new int[75000];
            randomdizi[6] = new int[150000];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < randomdizi[i].Length; j++)
                {
                    randomdizi[i][j] = Random.Next();
                }
            }
        }  
    }
}
