using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tictacktoe
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void oyun_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm bilgisayarmodu = new MainForm();
            bilgisayarmodu.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ikikisilik ikikisi = new ikikisilik();
            ikikisi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            liderlik liderliktablosu = new liderlik();
            liderliktablosu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oyunsorgula sorgulama = new oyunsorgula();
            sorgulama.Show();
        }
    }
}
