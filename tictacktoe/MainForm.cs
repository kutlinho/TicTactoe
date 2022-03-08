using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace tictacktoe
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			reset();
		}
		int[,] kon = new int[3, 3];//ilk değeri yok resetlenince 0 x ise 1 O ise 4 değerini alıyor(?)
		int ct, deg, a, b, c = 1, d = 1, fark = 1, vsy = 1;//deg(eski adıyla val) galibiyeti kontrol etmek için kullanılıyor X e 1 O ya 4 değerini veriyoruz toplam 12 olursa O,3 olursa x kazanmış demek oluyor.
		char ltt;
		String oy1 = "", oy2 = "Bilgisayar";//pc ye karşı sizin yazıyor 1. oyuncu için
		Random rst = new Random();
		bool tur = true;
		void reset()
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++) { kon[i, j] = 0; }// arreyleri 0 lar ile dolduruyoruz
			}
			foreach (Control kntrl in this.Controls)
			{
				if (kntrl is Label)
				{
					kntrl.ResetText();//labeller üzerindeki harfleri siliyoruz
				}
			}
			ct = 0;//dolu kare sayısını belirtiyor.4 hamle demek 4 kare dolu demek.
			deg = 1;
			ltt = 'X';
			label10.Text = oy1 + " Oyununuz Başladı.";
		}
		bool Oyun(int x, int y)//oyunun oynanma kısmı labellere değer return ediyor
		{
			if (kon[x, y] == 0)//üst üste gelen değer varmı diye kontrol ediyor
			{
				a = c; b = d; c = x; d = y;//sonuncu ve sondan 2. hamleleri tutuyor
				Label kntrl = link(x, y);//burada koordinatları labellere gönderiyor
				kntrl.Text = ltt.ToString();//hamleleri ekrana yansıtıyor
				kon[x, y] = deg;
				Cevir();// X ve O arasında geçişi yapıyor
				GalKontrol(x, y, kon[x, y]);//yenme veya berabere kalma durumunu kontrol ediyor
				return true;
			}
			else
				return false;
		}
		Label link(int x, int y)
		{
			if (x == 0)
			{
				if (y == 0)
					return label1;
				if (y == 1)
					return label2;
				if (y == 2)
					return label3;
			}
			if (x == 1)
			{
				if (y == 0)
					return label6;
				if (y == 1)
					return label5;
				if (y == 2)
					return label4;
			}
			if (x == 2)
			{
				if (y == 0)
					return label9;
				if (y == 1)
					return label8;
				if (y == 2)
					return label7;
			}
			return null;
		}
		void Cevir()//Bu kısım X Kazandı veya O kazandı için değer dönderiyor değerlendirme kısmına
		{
			if (ltt == 'X')
			{
				ltt = 'O';
				deg = 4;
				ct++;
			}
			else
			{
				ltt = 'X';
				deg = 1;
				ct++;
			}
		}
		void GalKontrol(int l, int m, int n)//galibiyeti değerlendiren kısım
		{
			if (ct == 1)//bu iki satır ilk oyun bittikten sonra kullanıcı değiştirmemesi için
				if (vsy == 1)
					tur = true;//eğere burası çıkarılısa ilk galibiyetten sonra O oyuncuya geçiyor hata oluyor.
			if (ct > 4)//en az 4 hamle 
			{//önce satırı-sütunu kontrol ediyor
				if ((kon[l, 0] + kon[l, 1] + kon[l, 2] == n * 3) || (kon[0, m] + kon[1, m] + kon[2, m] == n * 3))
				{
					ct = n;//(?)
				}
				else
				{//sonra sütunu kontrol ediyor
					if ((kon[0, 0] + kon[1, 1] + kon[2, 2] == n * 3) || (kon[2, 0] + kon[1, 1] + kon[0, 2] == n * 3))
					{
						ct = n;
					}
					else
					{
						if (ct == 9)
						{//beraberlik durumu
							ct = 0;
						}
					}
				}
				if (ct == 1 || ct == 0)
				{//eğer ilk oyuncu kazanırsa ya da berabere kalırsa
					if (ct == 1)
						İlanEt(oy1 + " X KAZANDI!");
					if (ct == 0)
						İlanEt("OYUN BERABERE!");
					reset();
					if (vsy == 1)
						if (oy1 == "Computer")
						{
							tur = false;
							OyunHamle(deg);
						}
						else
							tur = false;
				}
				else
				if (ct == 4)
				{
					İlanEt(oy2 + " O KAZANDI!");
					String temp = oy1;
					oy1 = oy2;
					oy2 = temp;
					reset();
					if (vsy == 1)
						if (oy1 == "Computer")
							OyunHamle(deg);
						else
							tur = false;
				}
			}
		}
		void İlanEt(string stmt)//evet derse oyun yeniden başlıyor,hayır derse çıkıyor
		{
			if (MessageBox.Show(stmt + " Devam etmek ister misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		void OyunHamle(int n)
		{
			bool carry = true;//burası bilgisayarın tek turda birden fazla hamle yapmaması için
			if (fark == 3)//eğer zor seçenek seçilir ise
				carry = ZorAlgoritma(a, b, n);
			if ((fark == 3) && carry)//eğer zor mod seçilirse
			{
				if (n == 1)
					carry = ZorAlgoritma(c, d, 4);
				else
					carry = ZorAlgoritma(c, d, 1);
			}
			if (carry)//3 seviyede de buradan işlem görülüyor
				KolayOrtaAlgoritma();
		}
		bool ZorAlgoritma(int l, int m, int n)
		{
			if (kon[l, 0] + kon[l, 1] + kon[l, 2] == n * 2)// 3 te 2 si doldurulmuş ise satırı kontorl ediyor
			{
				for (int i = 0; i < 3; i++)
				{
					if (Oyun(l, i))
						return false;
				}
			}
			else
				if (kon[0, m] + kon[1, m] + kon[2, m] == n * 2)// 3 te 2 isi sütün için bu da
			{
				for (int i = 0; i < 3; i++)
				{
					if (Oyun(i, m))
						return false;
				}
			}
			else
					if (kon[0, 0] + kon[1, 1] + kon[2, 2] == n * 2)// 3 te 2 si çapraz için kontrol
			{
				for (int i = 0; i < 3; i++)
				{
					if (Oyun(i, i))
						return false;
				}
			}
			else
						if (kon[2, 0] + kon[1, 1] + kon[0, 2] == n * 2)// bu da diğer çapraz için
			{
				for (int i = 0, j = 2; i < 3; i++, j--)
				{
					if (Oyun(i, j))
						return false;
				}
			}

			return true;
		}

		void KolayOrtaAlgoritma()
		{//ilk önce belirli hamle yapılıyor,sonra random başlıyor.Kullanıcı belirlenen yere koyarsa direk switche giriyor.
			int l = 0, m = 1;
			switch (ct)
			{
				default:
					while (!(Oyun(l, m)))
					{
						l = rst.Next(3);
						m = rst.Next(3);
					}
					break;
			}
		}
		void Kutu1Click(object sender, EventArgs e)//sağdan sola butonlar
		{
			if (Oyun(0, 0) && tur == true)
				OyunHamle(deg);
		}

		void Kutu2Click(object sender, EventArgs e)
		{
			if (Oyun(0, 1) && tur == true)
				OyunHamle(deg);
		}

		void Kutu3Click(object sender, EventArgs e)
		{
			if (Oyun(0, 2) && tur == true)
				OyunHamle(deg);
		}

		void Kutu6Click(object sender, EventArgs e)
		{
			if (Oyun(1, 0) && tur == true)
				OyunHamle(deg);
		}

		void Kutu5Click(object sender, EventArgs e)
		{
			if (Oyun(1, 1) && tur == true)
				OyunHamle(deg);
		}

		void Kutu4Click(object sender, EventArgs e)
		{
			if (Oyun(1, 2) && tur == true)
				OyunHamle(deg);
		}

		void Kutu9Click(object sender, EventArgs e)
		{
			if (Oyun(2, 0) && tur == true)
				OyunHamle(deg);
		}
		void Kutu8Click(object sender, EventArgs e)
		{
			if (Oyun(2, 1) && tur == true)
				OyunHamle(deg);
		}

		void Kutu7Click(object sender, EventArgs e)
		{
			if (Oyun(2, 2) && tur == true)
				OyunHamle(deg);
		}

		void KolaySecimKısmı(object sender, EventArgs e)//kolay seçeneği
		{
			YeniOyunKısmı(null, null);
			teksecim();
			easyToolStripMenuItem.Checked = true;
			fark = 1;
		}

		void ZorSecimKısmı(object sender, EventArgs e)//zor seçeneği
		{
			YeniOyunKısmı(null, null);
			teksecim();
			hardToolStripMenuItem.Checked = true;
			fark = 3;
		}

		void teksecim()//hepsi false şeklinde duruyor seçim yapılacağı zaman true haline getiriliyor
		{
			easyToolStripMenuItem.Checked = false;
			hardToolStripMenuItem.Checked = false;
		}
		void VsBilgisayarKısmı(object sender, EventArgs e)//bilgisayara karşı kısmı(sürekli tikli)
		{
			oy1 = "Sizin";
			oy2 = "Bilgisayar";
			reset();
			vsy = 1;
		}
		void YeniOyunKısmı(object sender, EventArgs e)//yeni oyun kısmı
		{
			if (vsy == 1)
			{
				oy1 = "Sizin";
				oy2 = "Bilgisayar";
			}
			reset();
		}
		void ÇıkısKısmı(object sender, EventArgs e)//çıkış
		{
			Application.Exit();
		}
	}
}

