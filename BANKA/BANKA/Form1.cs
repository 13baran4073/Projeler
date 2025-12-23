using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKA
{
    public partial class Form1 : Form
    {
        BankaHesabi hesap;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hesap = new BankaHesabi();
            label1.Text = "Bakiye: " + hesap.GetBakiye() + " TL";

            timer1.Interval = 10000;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int miktar = Convert.ToInt32(textBox1.Text);

            bool sonuc = hesap.HarcamaYap(miktar);

            if (sonuc)
            {
                label1.Text = "Bakiye: " + hesap.GetBakiye() + " TL";
            }
            else
            {
                MessageBox.Show("Ne harcamaya çalışıyon emmioğlu, para yok daha");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hesap.ParaEkle(100);
            label1.Text = "Bakiye: " + hesap.GetBakiye() + " TL";

            MessageBox.Show("Banka hesabına +100 TL eklendi emmioğlu");
        }
    }
}   