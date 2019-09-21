using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ilkSayi;
        string yapılacakİslem;     
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "1";
            }
            else { 
            txtSonuc.Text += "1";
            }
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "2";
            }
            else
            {
                txtSonuc.Text += "2";
            }
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "3";
            }
            else
            {
                txtSonuc.Text += "3";
        }
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "4";
            }
            else
            {
                txtSonuc.Text += "4";
            }
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "5";
            }
            else
            {
                txtSonuc.Text += "5";
        }
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "6";
            }
            else
            {
                txtSonuc.Text += "6";
            }
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "7";
            }
            else
            {
                txtSonuc.Text += "7";
        }
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "8";
            }
            else
            {
                txtSonuc.Text += "8";
        }
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "";
            }
            else
           {
                txtSonuc.Text += "9";
           }
          }
        private void Btn0_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text != "0")
            {
                txtSonuc.Text += "0";
            }
        }
        private void Btnondalık_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += ",";
        }
        private void BtnArtı_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = null;
            yapılacakİslem = "+";
        }
        private void BtnEksi_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = null;
            yapılacakİslem = "-";
        }
        private void BtnCarpi_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = null;
            yapılacakİslem = "*";
        }
        private void BtnBolu_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = null;
            yapılacakİslem = "/";
        }
        private void Btnesittir_Click(object sender, EventArgs e)
        {
            double sonuc;
            double ikinciSayi;
            ikinciSayi = Convert.ToDouble(txtSonuc.Text);
            if (yapılacakİslem == "+")
            {
                sonuc = (ilkSayi + ikinciSayi);
                txtSonuc.Text = Convert.ToString(sonuc);
                ilkSayi =sonuc;
            }
            if (yapılacakİslem == "-")

            {
                sonuc = (ilkSayi- ikinciSayi);
                txtSonuc.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }
            if (yapılacakİslem== "*")
            {
                sonuc = (ilkSayi * ikinciSayi);
                txtSonuc.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }
            if (yapılacakİslem == "/")
                if (ikinciSayi == 0)
                {
                    txtSonuc.Text = "İşlem Hatalı";
                }
                else
                {
                 sonuc = (ilkSayi / ikinciSayi);
                 txtSonuc.Text = Convert.ToString(sonuc);
                 ilkSayi = sonuc;
                }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = null;
        }
    }
}