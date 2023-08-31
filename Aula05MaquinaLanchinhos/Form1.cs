using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05MaquinaLanchinhos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "- Ruffles";
            lblValor.Text = "- R$ 06,50";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "- Barra de Cereal";
            lblValor.Text = "- R$ 02,50";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "- Bolinho de chocolate";
            lblValor.Text = "- R$ 03,50";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "- Suco de Laranja";
            lblValor.Text = "- R$ 07,00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "-";
            lblValor.Text = "-";
            txtPagamento.Text = "";
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(lblValor.Text.Replace("- R$", ""));
            double digitado = double.Parse(txtPagamento.Text);
            if (valor == digitado)
            {
                MessageBox.Show("Boa escolha! Aproveite seu lanchinho :)");
            }
            else
            {
                MessageBox.Show("Insira o valor do produto no formato 00,00");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "- Coca lata";
            lblValor.Text = "- R$ 05,50";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "- Chocolate";
            lblValor.Text = "- R$ 03,00";
        }
    }
}
