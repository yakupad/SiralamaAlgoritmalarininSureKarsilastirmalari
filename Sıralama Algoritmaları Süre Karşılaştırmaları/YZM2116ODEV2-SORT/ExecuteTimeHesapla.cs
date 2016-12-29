using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM2116ODEV2_SORT
{
    public class ExecuteTimeHesapla
    {
        public string BubbleExecuteTimeHesapla(int[] dizi)
        {
            BubbleSort bubblesort = new BubbleSort();
            Stopwatch executetime = new Stopwatch();
            executetime.Reset();
            executetime.Start();
            bubblesort.BubbleSorting(dizi);
            executetime.Stop();
            return executetime.Elapsed.TotalMilliseconds.ToString();
        }
        public string HeapExecuteTimeHesapla(int[] dizi)
        {
            HeapSort heapsort = new HeapSort();
            Stopwatch executetime = new Stopwatch();
            executetime.Reset();
            executetime.Start();
            heapsort.HeapSorting(dizi);
            executetime.Stop();
            return executetime.Elapsed.TotalMilliseconds.ToString();
        }
        public string InsertionExecuteTimeHesapla(int[] dizi)
        {
            InsertionSort insertionsort = new InsertionSort();
            Stopwatch executetime = new Stopwatch();
            executetime.Reset();
            executetime.Start();
            insertionsort.InsertionSorting(dizi);
            executetime.Stop();
            return executetime.Elapsed.TotalMilliseconds.ToString();

        }
        public string QuickExecuteTimeHesapla(int[] dizi)
        {
            QuickSort quicksort = new QuickSort();
            Stopwatch executetime = new Stopwatch();
            executetime.Reset();
            executetime.Start();
            quicksort.QuickSorting(dizi, 0, dizi.Length - 1);
            executetime.Stop();
            return executetime.Elapsed.TotalMilliseconds.ToString();
        }
        public string SelectionExecuteTimeHesapla(int[] dizi)
        {
            SelectionSort selectionsort = new SelectionSort();
            Stopwatch executetime = new Stopwatch();
            executetime.Reset();
            executetime.Start();
            selectionsort.SelectionSorting(dizi);
            executetime.Stop();
            return executetime.Elapsed.TotalMilliseconds.ToString();
        }
    }
}

