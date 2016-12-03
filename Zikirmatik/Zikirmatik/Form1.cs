using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zikirmatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnzkrmtk1_Click(object sender, EventArgs e)
        {
            Form2 zkrmtk = new Form2();
            zkrmtk.ShowDialog();
        }

        private void btnzkrmtk2_Click(object sender, EventArgs e)
        {
            Form3 zkrmtk2 = new Form3();
            zkrmtk2.ShowDialog();
        }

        private void btnzkrmtk3_Click(object sender, EventArgs e)
        {
            Form4 zkrmtk3 = new Form4();
            zkrmtk3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] söz1 = { "Kıyamette bana en yakın olan, en çok salevat getirendir.", "Cuma günleri bana 80 salevat okuyanın 80 yıllık günahı affolur." };
            string[] söz2 = { "Günde yüz salevat okuyan, kıyamette şehidlerle beraber olur.", "Günde bin salevat okuyan, Cennetteki yerini görmeden ölmez." };
            string[] söz3 = { "Bana bir salevat getirene Allahü teâlâ, on rahmet ihsan eder, on günahını yok eder ve derecesini on kat yükseltir.", "Salevat sizin için zekattır." };
            Random rastgele = new Random();
            int a, b, c;

            a = rastgele.Next(0, 2);
            b = rastgele.Next(0, 2);
            c = rastgele.Next(0, 2);

            lblyazı1.Text = söz1[a];
            lblyazı2.Text = söz2[b];
            lblyazı3.Text = söz3[c];

        }
    }
}
