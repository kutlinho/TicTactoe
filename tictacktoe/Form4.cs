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

namespace tictacktoe
{
    public partial class oyunsorgula : Form
    {
        public oyunsorgula()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantısı
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veriler.mdb");


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            //Oyun numarasını veritabanında sorgulama
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from skor where Numara like '" + textBox1.Text + "'", baglanti);
            DataTable aramatablo = new DataTable();
            adtr.Fill(aramatablo);
            dataGridView1.DataSource = aramatablo;

            // Veritabanında numara ile kayıtlı oyun varsa oyuna devam etme butonunun görünür olması
            OleDbCommand arax = new OleDbCommand("select count(*) from skor where Numara='" + textBox1.Text + "'", baglanti);
            if (arax.ExecuteScalar().ToString() == "1" )
            {
                kayitlioyunlar.Visible = true;
            }
            baglanti.Close();
        }


        private void kayitlioyunlar_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komutsil = new OleDbCommand("delete *from skor where Numara='" + textBox1.Text + "'", baglanti);
            komutsil.ExecuteNonQuery();
            baglanti.Close();

            ikikisilik ikikisi = new ikikisilik();
            ikikisi.Show();
            
            // Kayıtlı oyun verilerinin oyun ekranına katarılması
            ikikisi.oyuncu1ad.Text = dataGridView1.CurrentRow.Cells["Oyuncu1"].Value.ToString();
            ikikisi.oyuncu2ad.Text = dataGridView1.CurrentRow.Cells["Oyuncu2"].Value.ToString();
            ikikisi.textBox1.Text = dataGridView1.CurrentRow.Cells["Oyuncu1"].Value.ToString();
            ikikisi.textBox2.Text = dataGridView1.CurrentRow.Cells["Oyuncu2"].Value.ToString();
            ikikisi.skor1.Text = dataGridView1.CurrentRow.Cells["Skor1"].Value.ToString();
            ikikisi.skor2.Text = dataGridView1.CurrentRow.Cells["Skor2"].Value.ToString();


            // başlangıç ayarlarının yapılması
            if (ikikisi.sirakimde == "X")
            {
                ikikisi.sira.Text = ikikisi.textBox1.Text;
            }
            ikikisi.oyuncu1ad.Visible = true;
            ikikisi.oyuncu2ad.Visible = true;
            ikikisi.textBox1.Visible = false;
            ikikisi.textBox1.Enabled = false;
            ikikisi.textBox2.Visible = false;
            ikikisi.textBox2.Enabled = false;
            ikikisi.label1.Visible = false;
            ikikisi.label2.Visible = false;
            ikikisi.label3.Visible = true;
            ikikisi.sira.Visible = true;
            ikikisi.startagain();
            ikikisi.kayit.Visible = true;
            this.Close();
        }
    }
}
