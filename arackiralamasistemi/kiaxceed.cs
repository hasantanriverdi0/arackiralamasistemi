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
    public partial class kiaxceed : Form
    {
        public kiaxceed()
        {
            InitializeComponent();
        }

        private void kiaxceed_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            kiralamaekrani kiralamaekrani = new kiralamaekrani();
            kiralamaekrani.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            kiralakiaxceed kiralakiaxceed = new kiralakiaxceed();
            kiralakiaxceed.Show();
        }
    }
}
