using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSınıfı_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter tuşu çalışıyor");
        }

        private void btnGancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esc tuşu çalışıyor");
        }

        private void btnControlBox_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
            {
                this.ControlBox = false;
            }
            else
            {
                this.ControlBox = true;
            }
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.ShowDialog();
        }
    }
}
