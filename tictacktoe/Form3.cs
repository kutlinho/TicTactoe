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
    public partial class liderlik : Form
    {
        public liderlik()
        {
            InitializeComponent();
        }
        //Veritabanı bağlantısı
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\siralama.mdb
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veriler.mdb");

        private void liderlik_Load(object sender, EventArgs e)
        {
            kazananlar();
        }

        private void kazananlar()
        {
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglanti;

            // Veritabanındaki verileri fark verisindeki verilere göre büyükten küçüğe sıralama
            komut2.CommandText = ("SELECT *FROM skor ORDER BY Fark DESC");
            OleDbDataReader oku = komut2.ExecuteReader();
           
            //Veritabanından kazanan ve fark verilerini alıp listviewde görüntüleme
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kazanan"].ToString();
                ekle.SubItems.Add(oku["Fark"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
