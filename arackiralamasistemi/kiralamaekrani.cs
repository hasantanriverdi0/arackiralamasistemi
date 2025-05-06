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
    public partial class kiralamaekrani : Form
    {
        public kiralamaekrani()
        {
            InitializeComponent();
        }

        private void kiralamaekrani_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            audia3 audia3 = new audia3();
            audia3.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toyotacorolla toyotacorolla = new toyotacorolla();
            toyotacorolla.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kiaxceed kiaxceed = new kiaxceed();
            kiaxceed.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hondaaccord hondaaccord = new hondaaccord();
            hondaaccord.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kiaforte kiaforte = new kiaforte();
            kiaforte.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            audirs7 audirs7 = new audirs7();
            audirs7.Show();
            this.Close();
        }
    }
}
