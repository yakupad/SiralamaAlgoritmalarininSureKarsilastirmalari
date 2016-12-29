using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZM2116ODEV2_SORT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        int[] graphic = new int[7] { 100, 500, 1000, 5000, 10000, 50000, 100000 };
        RandomDataGenerator randomdiziler = new RandomDataGenerator();
        ExecuteTimeHesapla execute = new ExecuteTimeHesapla();
       
        //BUBBLE SORT ASYNC BAŞLANGIÇ
        private async void btnBubble_Click(object sender, EventArgs e)
        {
             await BubbleSort();
        }
        private Task BubbleSort()
        {
            return Task.Factory.StartNew(() =>
            {
               
            randomdiziler.RandomDataGeneratoring();//Dizileri Doldur
            List<string> bubblesonuclarilistesi=new List<string>(); //Sonuçların Eklendiği Liste
            for (int i = 0; i < 7; i++)
            { 
                progressBar1.Value=i;//ProgressBar 7 bölümden oluşuyor her adımda 1 ilerliyor.
               bubblesonuclarilistesi.Add(execute.BubbleExecuteTimeHesapla(randomdiziler.randomdizi[i]));
                dataGridView1.Rows[0].Cells[i].Value = bubblesonuclarilistesi[i];  
                dataGridView1.Update();
                chart1.Series[0].Points.AddXY(randomdiziler.randomdizi[i].Length.ToString(),double.Parse(bubblesonuclarilistesi[i].ToString()));
            }

            });
        }
        //BUBBLE SORT ASYNC BİTİŞ

        private async void btnSelection_Click(object sender, EventArgs e)
        {
            await SelectionSort();
        }
        private Task SelectionSort()
        {
            return Task.Factory.StartNew(() => 
            {
                randomdiziler.RandomDataGeneratoring();
                List<string> selectionsonuclarilistesi = new List<string>();
                for (int i = 0; i < 7; i++)
                {
                    progressBar1.Value = i;
                    selectionsonuclarilistesi.Add(execute.SelectionExecuteTimeHesapla(randomdiziler.randomdizi[i]));
                    dataGridView1.Rows[1].Cells[i].Value = selectionsonuclarilistesi[i];
                    dataGridView1.Update();
                    chart1.Series[1].Points.AddXY(randomdiziler.randomdizi[i].Length.ToString(), double.Parse(selectionsonuclarilistesi[i].ToString()));
                } 
            });
        }

        private async void btnHeap_Click(object sender, EventArgs e)
        {
            await HeapSort();
        }
        private Task HeapSort()
        {
            return Task.Factory.StartNew(() =>
            {
                randomdiziler.RandomDataGeneratoring();
                List<string> heapsonuclarilistesi = new List<string>();
                for (int i = 0; i < 7; i++)
                {
                    progressBar1.Value = i;
                    heapsonuclarilistesi.Add(execute.HeapExecuteTimeHesapla(randomdiziler.randomdizi[i]));
                    dataGridView1.Rows[2].Cells[i].Value = heapsonuclarilistesi[i];
                    dataGridView1.Update();
                    chart1.Series[2].Points.AddXY(randomdiziler.randomdizi[i].Length.ToString(), double.Parse(heapsonuclarilistesi[i].ToString()));

                }
            });
        }

        private async void btnQuick_Click(object sender, EventArgs e)
        {
           await QuickSort();
        }
        private Task QuickSort()
        {
            return Task.Factory.StartNew(() =>
            {
                randomdiziler.RandomDataGeneratoring();
                List<string> quicksonuclarilistesi = new List<string>();
                for (int i = 0; i < 7; i++)
                {
                    progressBar1.Value = i;
                    quicksonuclarilistesi.Add(execute.QuickExecuteTimeHesapla(randomdiziler.randomdizi[i]));
                    dataGridView1.Rows[3].Cells[i].Value = quicksonuclarilistesi[i];
                    dataGridView1.Update();
                    chart1.Series[3].Points.AddXY(randomdiziler.randomdizi[i].Length.ToString(), double.Parse(quicksonuclarilistesi[i].ToString()));
                }  
            });
        }

        private async void btnInsertion_Click(object sender, EventArgs e)
        {
            await InsertionSort();
        }
        private Task InsertionSort()
        {
            return Task.Factory.StartNew(() =>
            {
                randomdiziler.RandomDataGeneratoring();
                List<string> insertionsonuclarilistesi = new List<string>();
                for (int i = 0; i < 7; i++)
                {
                    progressBar1.Value = i;
                    insertionsonuclarilistesi.Add(execute.InsertionExecuteTimeHesapla(randomdiziler.randomdizi[i]));
                    dataGridView1.Rows[4].Cells[i].Value = insertionsonuclarilistesi[i];
                    dataGridView1.Update();
                    chart1.Series[4].Points.AddXY(randomdiziler.randomdizi[i].Length.ToString(), double.Parse(insertionsonuclarilistesi[i].ToString()));

                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            progressBar1.Maximum = 6;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        

        

    }
}
