using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_WinForm
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
       
        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "0";
            else
                txt_n1.Text = "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "1";
            else
                txt_n1.Text = "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "2";
            else
                txt_n1.Text = "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "3";
            else
                txt_n1.Text = "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "4";
            else
                txt_n1.Text = "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "5";
            else
                txt_n1.Text = "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "6";
            else
                txt_n1.Text = "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "7";
            else
                txt_n1.Text = "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "8";
            else
                txt_n1.Text = "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_n2.Focus();
            if (txt_n1.Text != "")
                txt_n2.Text = "9";
            else
                txt_n1.Text = "9";
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_Resultado.Clear();
            txt_n1.Focus();
        }

        private void btn_Mais_Click(object sender, EventArgs e)
        {
            decimal n1 = decimal.Parse(txt_n1.Text);
            decimal n2 = decimal.Parse(txt_n2.Text);
            decimal total = n1 + n2;
            txt_Resultado.Text = total.ToString();
            txt_n1.Focus();
        } 

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            decimal n1 = decimal.Parse(txt_n1.Text);
            decimal n2 = decimal.Parse(txt_n2.Text);
            decimal total = n1 - n2;
            txt_Resultado.Text = total.ToString();
            txt_n1.Focus();
        }

        private void btn_Multiplica_Click(object sender, EventArgs e)
        {
            decimal n1 = decimal.Parse(txt_n1.Text);
            decimal n2 = decimal.Parse(txt_n2.Text);
            decimal total = n1 * n2;
            txt_Resultado.Text = total.ToString();
            txt_n1.Focus();
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            decimal n1 = decimal.Parse(txt_n1.Text);
            decimal n2 = decimal.Parse(txt_n2.Text);
            decimal total = n1 / n2;
            txt_Resultado.Text = total.ToString();
            txt_n1.Focus();
        }

        private void txt_Resultado_TextChanged(object sender, EventArgs e)
        {
            txt_Resultado.Enabled = false;
        }
    }
}
