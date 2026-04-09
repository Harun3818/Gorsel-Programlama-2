using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devpiramit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            string sonuc = "";

            for (int i = 1; i <= n; i++)
            {
                // boşluklar
                for (int j = 1; j <= n - i; j++)
                {
                    sonuc += " ";
                }

                // sayılar
                for (int k = 1; k <= i; k++)
                {
                    sonuc += k + " ";
                }

                sonuc += "\n";
            }

            label1.Text = sonuc;
        }
    }
}
