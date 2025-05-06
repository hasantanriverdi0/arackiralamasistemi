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
    public partial class audia3 : Form
    {
        public audia3()
        {
            InitializeComponent();
        }

        private void audia3_Load(object sender, EventArgs e)
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
            kiralaaudia3 kiralaaudia3 = new kiralaaudia3();
            kiralaaudia3.Show();
        }
    }
}
