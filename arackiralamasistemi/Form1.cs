using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arackiralamasistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kiralamaekrani kiralamaekrani = new kiralamaekrani();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string ad = textBox_ad.Text;
            string tc = textBox_tc.Text;
            string numara = textBox_no.Text;

            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(tc) && !string.IsNullOrEmpty(numara))
            {
                bool tcSadeceSayiMi = tc.All(char.IsDigit) && numara.All(char.IsDigit);
                bool adSadeceHarfMi = ad.All(c => char.IsLetter(c) || c == ' ');

                if (tcSadeceSayiMi && adSadeceHarfMi)
                {
                    if (textBox_tc.Text.Length < 11)
                    {
                        MessageBox.Show("TC Kimlik en az 11 haneli olmalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (textBox_no.Text.Length < 10)
                    {
                        MessageBox.Show("Telefon numarası en az 10 haneli olmalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else 
                    {
                        if (kiralamaekrani == null)
                        {
                            kiralamaekrani = new kiralamaekrani();
                        }                      
                        kiralamaekrani.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Ad Soyad, TC Kimlik ve Telefon Numarası uygun formatta olmalıdır.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ad Soyad, TC Kimlik ve Telefon Numarası bölümlerini eksiksiz doldurun.");
            }
        }
    }
}