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
    public partial class ikikisilik : Form
    {
        public string sirakimde = "X";
        public ikikisilik()
        {
            InitializeComponent();
            if (textBox2.Enabled == false)
            {
                textBox2.BackColor = Color.DarkSalmon;
            }
            sira.Visible = false;
            label3.Visible = false; // Oyun başlayana kadar bunlar gözükmeyecek.
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                    textBox2.BackColor = Color.White;
                    textBox1.Enabled = false;
                    textBox1.Visible = false;

                    textBox2.Enabled = true;
                    textBox2.Visible = true;

                    label1.Visible = false;

                    sira.Text = textBox1.Text;
                    oyuncu1ad.Text = textBox1.Text + " (X)";
                    oyuncu1ad.Visible = true;

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                    startagain();
                    textBox2.Enabled = false;
                    textBox2.Visible = false;
                    label2.Visible = false;

                    oyuncu2ad.Text = textBox2.Text + " (O)";
                    oyuncu2ad.Visible = true;

                    xox.Enabled = true;
                    label12.Enabled = true;
                    label13.Enabled = true;
                    label21.Enabled = true;
                    label22.Enabled = true;
                    label23.Enabled = true;
                    label31.Enabled = true;
                    label32.Enabled = true;
                    label33.Enabled = true;

                    kronometre.Visible = true;
                    sira.Visible = true;
                    label3.Visible = true;
                    timer1.Start();

                    can11.Visible = true;
                    can12.Visible = true;
                    can21.Visible = true;
                    can22.Visible = true;

                    kayit.Visible = true;
            }
        }

        public void xox_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (sirakimde == "X")
            {
                // Eğer sıra X'te ise tıklandığında X yazıp sırayı O'ya devret 
                lbl.Text = "X";
                lbl.Enabled = false;
                sirakimde = "O";
                sira.Text = textBox2.Text;
            }
            else
            {
                // Eğer sıra X'te değil ise tıklandığında O yazıp sırayı X'e devret 
                lbl.Text = "O";
                sirakimde = "X";
                lbl.Enabled = false;
                sira.Text = textBox1.Text;
            }

            // X'in kazanma kontrolu
            if ((xox.Text == label12.Text && label12.Text == label13.Text && label13.Text == "X") ||
               (label21.Text == label22.Text && label22.Text == label23.Text && label23.Text == "X") ||
               (label31.Text == label32.Text && label32.Text == label33.Text && label33.Text == "X") ||
               (xox.Text == label22.Text && label22.Text == label33.Text && label33.Text == "X") ||
               (label13.Text == label22.Text && label22.Text == label31.Text && label31.Text == "X") ||
               (xox.Text == label21.Text && label21.Text == label31.Text && label31.Text == "X") ||
               (label12.Text == label22.Text && label22.Text == label32.Text && label32.Text == "X") ||
               (label13.Text == label23.Text && label23.Text == label33.Text && label33.Text == "X"))
            {
                timer1.Stop();
                MessageBox.Show(oyuncu1ad.Text.ToUpper() + " KAZANDI!");
                startagain();
                skor1.Text = (int.Parse(skor1.Text) + 1).ToString();
                timer1.Start();
            }

            // O'nun kazanma kontrolü
            if ((xox.Text == label12.Text && label12.Text == label13.Text && label13.Text == "O") ||
               (label21.Text == label22.Text && label22.Text == label23.Text && label23.Text == "O") ||
               (label31.Text == label32.Text && label32.Text == label33.Text && label33.Text == "O") ||
               (xox.Text == label22.Text && label22.Text == label33.Text && label33.Text == "O") ||
               (label13.Text == label22.Text && label22.Text == label31.Text && label31.Text == "O") ||
               (xox.Text == label21.Text && label21.Text == label31.Text && label31.Text == "O") ||
               (label12.Text == label22.Text && label22.Text == label32.Text && label32.Text == "O") ||
               (label13.Text == label23.Text && label23.Text == label33.Text && label33.Text == "O"))
            {
                timer1.Stop();
                MessageBox.Show(oyuncu2ad.Text.ToUpper() + " KAZANDI!");
                startagain();
                skor2.Text = (int.Parse(skor2.Text) + 1).ToString();
                timer1.Start();
            }

            //Beraberlik durumu kontrolü
            else if (xox.Text != "" && label12.Text != "" && label13.Text != "" &&
                label21.Text != "" && label22.Text != "" && label23.Text != "" &&
                label31.Text != "" && label32.Text != "" && label33.Text != "")
            {
                timer1.Stop();
                MessageBox.Show("KAZANAN ÇIKMADI!");
                startagain();
                timer1.Start();
            }
            sure = 10;
        }
        int hak1 = 2;
        int hak2 = 2;

        public void startagain()
        {
            xox.Text = "";
            xox.Enabled = true;
            label12.Text = "";
            label12.Enabled = true;
            label13.Text = "";
            label13.Enabled = true;
            label21.Text = "";
            label21.Enabled = true;
            label22.Text = "";
            label22.Enabled = true;
            label23.Text = "";
            label23.Enabled = true;
            label31.Text = "";
            label31.Enabled = true;
            label32.Text = "";
            label32.Enabled = true;
            label33.Text = "";
            label33.Enabled = true;

            hak1 = 2;
            hak2 = 2;

            kronometre.Visible = true;
            timer1.Start();

            can11.Visible = true;
            can12.Visible = true;
            can21.Visible = true;
            can22.Visible = true;

        }

        int sure = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            sure -= 1;
            kronometre.Text = sure.ToString();
            if (sure == 0)
            {

                if (sirakimde == "X")
                {
                    hak1--;
                    if (hak1 == 1)// Can azalması işlemi
                    {
                        can12.Visible = false; // ikinci can silinecek.( Can12 = kullanıcı 1'in 2. canı.)
                    }

                    // Can olmaması durumunda kazanan işemleri
                    if (hak1 == 0)
                    {
                        kronometre.Visible = false;
                        can12.Visible = false; 
                        skor2.Text = (int.Parse(skor2.Text) + 1).ToString();
                        MessageBox.Show(oyuncu2ad.Text.ToUpper() + " KAZANDI!");
                        startagain();
                    }
                    sure = 10;
                    sirakimde = "O";
                    sira.Text = textBox2.Text;
                }
                else
                {
                    //Can azalması işlemi
                    hak2--;
                    if (hak2 == 1)
                    {
                        can22.Visible = false;
                    }

                    // Can olmaması durumunda kazanan işemleri
                    if (hak2 == 0)
                    {
                        kronometre.Visible = false;
                        can21.Visible = false;
                        skor1.Text = (int.Parse(skor1.Text) + 1).ToString();
                        MessageBox.Show(oyuncu1ad.Text.ToUpper() + " KAZANDI!");

                        startagain();
                    }
                    sure = 10;
                    sirakimde = "X";
                    sira.Text = textBox1.Text;
                }
            }
        }

        string kazanan;
        string fark;
        //Veritabanı bağlantısı
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\oyunverileri.mdb
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veriler.mdb");
        private void kayit_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000, 1000000);
            timer1.Stop();
            baglanti.Open();
            //kazanan ve fark verilerinin hesaplanması
            if(int.Parse(skor1.Text) > int.Parse(skor2.Text))
            {
                kazanan = textBox1.Text;
                fark = ((int.Parse(skor1.Text)) - int.Parse(skor2.Text)).ToString();
            }
            else if(int.Parse(skor2.Text) > int.Parse(skor1.Text))
            {
                kazanan = textBox2.Text;
                fark = ((int.Parse(skor2.Text)) - int.Parse(skor1.Text)).ToString();
            }
            else
            {
                fark = ((int.Parse(skor2.Text)) - int.Parse(skor1.Text)).ToString();
                kazanan = "---";
            }
            //veri tabanına verilerin kaydedilmesi
            OleDbCommand komut = new OleDbCommand("insert into skor(Oyuncu1,Skor1,Skor2,Oyuncu2,Fark,Kazanan,Numara) values('" + textBox1.Text + "' , '" + skor1.Text + "' , '" + skor2.Text + "', '" + textBox2.Text + "', '" + fark + "', '" + kazanan + "', '" + sayi.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            
            baglanti.Close();
            MessageBox.Show("Oyun Numarası: " + sayi.ToString() + "\n\n" + "Oyun numarası ile oyun sorgulama kısmından kaldığınız yerden oyununuza devam edebilirsiniz.", "Kayıt");

            // Çıkış
            this.Close();
            Application.Exit();
        }
    }
}

