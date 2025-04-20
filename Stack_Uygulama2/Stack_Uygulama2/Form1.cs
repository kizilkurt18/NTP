using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack İsimler = new Stack();
        private void Listele()
        {
            listeStack.Items.Clear();
            foreach (string eleman in İsimler)
            {
                listeStack.Items.Add(eleman);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            İsimler.Push(txtAdSoyad.Text);
            Listele();
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            İsimler.Pop();
            Listele();
                
        }
    }
}
