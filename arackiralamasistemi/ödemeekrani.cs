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
    public partial class ödemeekrani : Form
    {
        public ödemeekrani()
        {
            InitializeComponent();
        }

        private void ödemeekrani_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text.Replace("-", "").Trim()) ||
                string.IsNullOrWhiteSpace(maskedTextBox2.Text.Replace("/", "").Trim()) ||
                string.IsNullOrWhiteSpace(maskedTextBox3.Text.Trim()))
            {
                MessageBox.Show("Lütfen tüm alanları doğru bir şekilde doldurunuz.");
                return;
            }
            DialogResult result = MessageBox.Show("Ödemeyi onaylıyor musunuz?", "Ödeme Onayı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Ödemeniz başarıyla tamamlandı, dekont telefonunuza gönderilecektir. Bizi tercih ettiğiniz için teşekkür ederiz.");
                Application.Exit(); // Uygulamayı kapat
            }
            else
            {
                MessageBox.Show("İşleminiz iptal edildi, tekrar deneyiniz.");
                // Uygulama açık kalır ve herhangi bir işlem yapılmaz
            }
        }
        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            // Kart numarası için basit bir kontrol
            if (!System.Text.RegularExpressions.Regex.IsMatch(maskedTextBox1.Text, @"^\d{4} \d{4} \d{4} \d{4}$"))
            {
                MessageBox.Show("Lütfen geçerli bir kart numarası giriniz.");
                e.Cancel = true; // Odağı textbox'tan almayı iptal eder
            }
        }
    }
}
