using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int daire;
            int kare;
            int dikdörtgen;
            int hesapla;
            daire = Convert.ToInt32(textBox2.Text);
            kare = Convert.ToInt32(textBox2.Text);
            dikdörtgen = Convert.ToInt32(textBox2.Text);
            hesapla = (daire + 2);
            {
                MessageBox.Show("daireyi +2 topla");
            }
            hesapla = (kare * 2);
            {
                MessageBox.Show("kareyi *2 çarp");
            }
            hesapla = (dikdörtgen / 8);
            {
                MessageBox.Show("dikdörtgeni /8");
            }
  
            {
                MessageBox.Show("sayılar girilmiştir");
            }
        }
    }
}
