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
    public partial class kiralaaudirs7 : Form
    {
        public kiralaaudirs7()
        {
            InitializeComponent();

            button1.Enabled = false;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            radioButton1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

            for (int i = 1; i <= 24; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 30; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            button3.Click += new EventHandler(button3_Click);
        }

        private void kiralaaudirs7_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            audirs7 audirs7 = new audirs7();
            audirs7.Show();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = radioButton2.Checked;
            comboBox2.Enabled = radioButton1.Checked;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            if (radioButton1.Checked)
            {
                int sayi = int.Parse(comboBox2.SelectedItem.ToString());
                sonuc = sayi * 103;
            }
            else if (radioButton2.Checked)
            {
                int sayi = int.Parse(comboBox1.SelectedItem.ToString());
                sonuc = sayi * 2450;
            }
            label2.Text = sonuc.ToString() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ödemeekrani ödemeekrani = new ödemeekrani();
            ödemeekrani.Show();
        }
    }
}
