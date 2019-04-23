using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace BinaryGame
{
    public partial class form1 : Form
    {
        SoundPlayer ply = new SoundPlayer(Properties.Resources.click);

        public form1()
        {
            InitializeComponent();
            Random num = new Random();
            lblMust.Text = num.Next(1, 256).ToString();
            goProgressBar();
        }

        private void chooseLevel()
        {
            if (lblScore.Text == "600")
            {
                label1.Hide();
            }
            else if (lblScore.Text == "1050")
            {
                lblHave.Hide();
                label4.Hide();
                progressBar1.Width = 640;
                label6.Width = 846;
            }
        }

        private void checkButtons()
        {
            btn256.Enabled = true;
            btn128.Enabled = true;
            btn64.Enabled = true;
            btn32.Enabled = true;
            btn16.Enabled = true;
            btn8.Enabled = true;
            btn4.Enabled = true;
            btn2.Enabled = true;
            btn1.Enabled = true;
        }

        private void calculate()
        {
            int num1 = int.Parse(lblHave.Text);
            int num2 = int.Parse(lblMust.Text);

            if (num1 == num2)
            {
                int score = int.Parse(lblScore.Text);
                score = score + 150;
                lblScore.Text = score.ToString();
                btn1.Text = "0";
                btn2.Text = "0";
                btn4.Text = "0";
                btn8.Text = "0";
                btn16.Text = "0";
                btn32.Text = "0";
                btn32.Text = "0";
                btn64.Text = "0";
                btn128.Text = "0";
                btn256.Text = "0";
                lblHave.Text = "0";
                Random num = new Random();
                lblMust.Text = num.Next(1, 256).ToString();
                checkButtons();
                goProgressBar();
                chooseLevel();
                SoundPlayer snd = new SoundPlayer(Properties.Resources.OK);
                snd.Play();
            }
            else
            {
                SoundPlayer snd = new SoundPlayer(Properties.Resources._false);
                snd.Play();
            }
        }

        private async void goProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Step = 10;
            progressBar1.Value = 0;
            progressBar1.Maximum = 300;

            for (int i = 1; i < 300; i++)
            {
                progressBar1.PerformStep();
                await Task.Delay(1000);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn1.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 1;
            lblHave.Text = numThere.ToString();

            if (btn1.Text == "1")
            {
                btn1.Enabled = false;
            }
        }

        private void Btn128_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn128.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 128;
            lblHave.Text = numThere.ToString();
           
            if (btn128.Text == "1")
            {
                btn128.Enabled = false;
            }

        }

        private void Btn64_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn64.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 64;
            lblHave.Text = numThere.ToString();

            if (btn64.Text == "1")
            {
                btn64.Enabled = false;
            }
        }

        private void Btn32_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn32.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 32;
            lblHave.Text = numThere.ToString();

            if (btn32.Text == "1")
            {
                btn32.Enabled = false;
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn8.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 8;
            lblHave.Text = numThere.ToString();

            if (btn8.Text == "1")
            {
                btn8.Enabled = false;
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn2.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 2;
            lblHave.Text = numThere.ToString();

            if (btn2.Text == "1")
            {
                btn2.Enabled = false;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn4.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 4;
            lblHave.Text = numThere.ToString();

            if (btn4.Text == "1")
            {
                btn4.Enabled = false;
            }
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn16.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 16;
            lblHave.Text = numThere.ToString();

            if (btn16.Text == "1")
            {
                btn16.Enabled = false;
            }       
        }

        private void BtnVynulovat_Click(object sender, EventArgs e)
        {
            ply.Play();
            btn1.Text = "0";
            btn2.Text = "0";
            btn4.Text = "0";
            btn8.Text = "0";
            btn16.Text = "0";
            btn32.Text = "0";
            btn32.Text = "0";
            btn64.Text = "0";
            btn128.Text = "0";
            btn256.Text = "0";
            lblHave.Text = "0";
            checkButtons();
        }

        private void Btn256_Click(object sender, EventArgs e)
        {
            ply.Play();
            int kolikrat = 1;
            btn256.Text = "1";
            kolikrat++;
            int numThere = int.Parse(lblHave.Text);
            numThere = numThere + 256;
            lblHave.Text = numThere.ToString();

            if (btn256.Text == "1")
            {
                btn256.Enabled = false;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void KonceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OHřeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAbout frm = new formAbout();
            frm.Show();
        }

        private void NápovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp frm = new FormHelp();
            frm.Show();
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}