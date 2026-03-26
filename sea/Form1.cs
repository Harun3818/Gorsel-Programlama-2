using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sea
{
    public partial class Form1 : Form
    {
        string kelime = "ELMA";
        string gosterilen = "";
        int hata = 0;

        List<char> yanlisHarfler = new List<char>();
        Image[] resimler;

        public Form1()

        {
            InitializeComponent();
            this.Load += Form1_Load;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            resimler = new Image[]
         {
                Properties.Resources.A,
                Properties.Resources.B,
                Properties.Resources.C,
                Properties.Resources.D,
                Properties.Resources.E,
                Properties.Resources.F,
                Properties.Resources.H
         };

            // Kelimeyi _ _ _ şeklinde göster
            gosterilen = new string('_', kelime.Length);
            label3.Text = gosterilen;

            // İlk resim
            pictureBox1.Image = resimler[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            char harf = char.ToUpper(textBox1.Text[0]);
            textBox1.Clear();

            if (kelime.Contains(harf))
            {
                char[] dizi = gosterilen.ToCharArray();

                for (int i = 0; i < kelime.Length; i++)
                {
                    if (kelime[i] == harf)
                        dizi[i] = harf;
                }

                gosterilen = new string(dizi);
                label3.Text = gosterilen;

                // kazanma kontrolü
                if (gosterilen == kelime)
                {
                    MessageBox.Show("Kazandın!");
                }
            }
            else
            {
                if (!yanlisHarfler.Contains(harf))
                {
                    yanlisHarfler.Add(harf);
                    label1.Text = string.Join(" ", yanlisHarfler);

                    hata++;
                    ResimGuncelle();

                    // kaybetme kontrolü
                    if (hata == 6)
                    {
                        MessageBox.Show("Kaybettin! Kelime: " + kelime);
                    }
                }
            }
        }
        void ResimGuncelle()
        {
            switch (hata)
            {
                case 1: pictureBox1.Image = Properties.Resources.B; break;
                case 2: pictureBox1.Image = Properties.Resources.C; break;
                case 3: pictureBox1.Image = Properties.Resources.D; break;
                case 4: pictureBox1.Image = Properties.Resources.E; break;
                case 5: pictureBox1.Image = Properties.Resources.F; break;
                case 6: pictureBox1.Image = Properties.Resources.H; break;
            }
        }
    }
}
