using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnd.Enabled = false;
            btnc.Enabled = false;
            btnb.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnb.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldno.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyno.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btna.Text;
            if (label5.Text==label4.Text)
            {
                dogru++;
                lbldno.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyno.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btnc.Enabled = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnc.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldno.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyno.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btnd.Enabled = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnd.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldno.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyno.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnd.Enabled = false;
            btnc.Enabled = false;
            btnb.Enabled = false;
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnd.Enabled = true;
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnsonraki.Enabled = false;

            soruno++;
            lblsno.Text = soruno.ToString();
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;

            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında kurulmuştur?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Galataaray kaç yılında kurulmuştur?";
                btna.Text = "1903";
                btnb.Text = "1905";
                btnc.Text = "1907";
                btnd.Text = "1909";
                label4.Text = "1905";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "H.Z muhammed (S.A.V) kaç yılında doğmuştur?";
                btna.Text = "412";
                btnb.Text = "563";
                btnc.Text = "570";
                btnd.Text = "571";
                label4.Text = "571";
            }
            if (soruno==4)
            {
                btna.Enabled = false;
                btnd.Enabled = false;
                btnc.Enabled = false;
                btnb.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("Doğru:"+dogru+"\n"+"Yanlış:"+yanlis);
            }
        }
    }
}
