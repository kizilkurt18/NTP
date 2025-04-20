using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizinMetotları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = { 20000, 25000, 19000 , 52000 , 65000 , 18000 , 51000 , 100000 , 80000 , 70000};
        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk = sayilar.Length;
            MessageBox.Show("Dizinin Uzunluğu = " + uzunluk.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int boyut = sayilar.Rank;
            MessageBox.Show("Dizinin Boyutu = " + boyut.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int enYuksek = sayilar.Max();
            MessageBox.Show("Dizindeki En Yüksek Sayı = " + enYuksek.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int enDusuk = sayilar.Min();
            MessageBox.Show("Dizindeki En Dusuk Sayı = " + enDusuk.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = sayilar.Sum();
            MessageBox.Show("Dizindeki Sayıların Toplamı = " + toplam.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double ortalama = sayilar.Average();
            MessageBox.Show("Dizindeki Sayıların Ortalaması = " + ortalama.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ilkSayi = sayilar.First();
            MessageBox.Show("Dizindeki İlk Sayı = " + ilkSayi.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sonSayi = sayilar.Last();
            MessageBox.Show("Dizindeki Son Sayı = " + sonSayi.ToString());
        }
    }
}
