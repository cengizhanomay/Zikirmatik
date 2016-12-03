using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Zikirmatik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=zikirmatik.accdb";

        double sayı = 0;

        private void btnsayıarttır_Click(object sender, EventArgs e)
        {
            sayı++;
            lblsayılar.Text = sayı.ToString();

            if (sayı == 99999)
            {
                lblsayılar.Text = "0";
            }

            OleDbConnection baglan = new OleDbConnection(baglanti);
            {
                baglan.Open();

                OleDbCommand guncelle = new OleDbCommand("update tablozikir set [sayılar]='" + lblsayılar.Text + "'", baglan);
                guncelle.ExecuteNonQuery();
                baglan.Close();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Salevat sayısını sıfırlamak istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                sayı = 0;
                lblsayılar.Text = sayı.ToString();
                OleDbConnection baglan = new OleDbConnection(baglanti);
                {
                    baglan.Open();

                    OleDbCommand guncelle = new OleDbCommand("update tablozikir set [sayılar]='" + lblsayılar.Text + "'", baglan);
                    guncelle.ExecuteNonQuery();
                    baglan.Close();
                }
            }
        }

        private void btnbaşla_Click(object sender, EventArgs e)
        {
            btnbaşla.Enabled = false;
            btnsayıarttır.Enabled = true;
            btnreset.Enabled = true;
            OleDbDataAdapter adaptor = new OleDbDataAdapter();
            OleDbConnection bağlantı = new OleDbConnection();
            DataSet ds = new DataSet();
            OleDbCommand komut = new OleDbCommand();
            DataRow satir;
            string bmetin;
            bmetin = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=zikirmatik.accdb";
            bağlantı.ConnectionString = bmetin;
            bağlantı = new OleDbConnection(bmetin);
            bağlantı.Open();
            komut.CommandText = "select *from tablozikir";
            adaptor.SelectCommand = komut;
            komut.Connection = bağlantı;
            adaptor.Fill(ds, "tablozikir");
            satir = ds.Tables["tablozikir"].Rows[0];
            textBox1.Text = satir["sayılar"].ToString();
            sayı = Convert.ToDouble(textBox1.Text);
            lblsayılar.Text = sayı.ToString();
            bağlantı.Close();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
