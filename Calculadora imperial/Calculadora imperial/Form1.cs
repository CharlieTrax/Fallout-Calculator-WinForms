using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_imperial
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double final;
        private int operation;

        private bool valor1TemPonto = false;
        private bool valor2TemPonto = false;
        private bool operacaoSelecionada = false;
        private bool prontoParaNovaOperacao = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.LimeGreen;
            this.Font = new Font("Consolas", 14F, FontStyle.Bold);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.LimeGreen;
                    btn.Font = new Font("Courier New", 16F, FontStyle.Bold);
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, Color.LimeGreen); // brilho suave ao passar o mouse
                    btn.UseVisualStyleBackColor = false;

                    btn.FlatAppearance.BorderColor = Color.LimeGreen;
                    btn.FlatAppearance.BorderSize = 1;
                }
                else if (ctrl is TextBox txt)
                {
                    txt.TextAlign = HorizontalAlignment.Right;
                    txt.BackColor = Color.Black;
                    txt.ForeColor = Color.LimeGreen;
                    txt.Font = new Font("Courier New", 24F, FontStyle.Bold);
                    txt.BorderStyle = BorderStyle.None;
                }
                else if (ctrl is System.Windows.Forms.Label lbl)
                {
                    lbl.ForeColor = Color.LimeGreen;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //tecla 4
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tecla 7
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (!operacaoSelecionada && !string.IsNullOrWhiteSpace(Display.Text))
           {     //porcentagem
                operation = 6;
                valor1TemPonto = Display.Text.Contains(".");
                valor1 = Convert.ToDouble(Display.Text);
                Display.Text = "";
                operacaoSelecionada = true;
           }
        }

        private void Potencia_Click(object sender, EventArgs e)
        {
            if (!operacaoSelecionada && !string.IsNullOrWhiteSpace(Display.Text))
            {    //potencia
                operation = 5;
                valor1TemPonto = Display.Text.Contains(".");
                valor1 = Convert.ToDouble(Display.Text);
                Display.Text = "";
                operacaoSelecionada = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //apagar
            Display.Text = "";
            operacaoSelecionada = true;
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            if (!operacaoSelecionada && !string.IsNullOrWhiteSpace(Display.Text))
            {   //subtracao
               operation = 2;
               valor1TemPonto = Display.Text.Contains(".");
               valor1 = Convert.ToDouble(Display.Text);
               Display.Text = "";
               operacaoSelecionada = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //tecla 1
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "1";
        }

        private void tl8_Click(object sender, EventArgs e)
        {
            //tecla 8
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "8";
        }

        private void tl9_Click(object sender, EventArgs e)
        {
            //tecla 9
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "9";
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            if (!operacaoSelecionada && !string.IsNullOrWhiteSpace(Display.Text))
            {   //soma
                operation = 1;
                valor1TemPonto = Display.Text.Contains(".");
                valor1 = Convert.ToDouble(Display.Text);
                Display.Text = "";
                operacaoSelecionada = true;
            }
        }

        private void tl5_Click(object sender, EventArgs e)
        {
            //tecla 5
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "5";
        }

        private void tl6_Click(object sender, EventArgs e)
        {
            //tecla 6
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "6";
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            if (!operacaoSelecionada && !string.IsNullOrWhiteSpace(Display.Text))
            {    //multiplicacao
                operation = 3;
                valor1TemPonto = Display.Text.Contains(".");
                valor1 = Convert.ToDouble(Display.Text);
                Display.Text = "";
                operacaoSelecionada = true;
            }
        }
        private void tl2_Click(object sender, EventArgs e)
        {
            //tecla 2
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "2";
        }

        private void tl3_Click(object sender, EventArgs e)
        {
            //tecla 3
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "3";
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if (!operacaoSelecionada && !string.IsNullOrWhiteSpace(Display.Text))
            {   //divisao
                operation = 4;
                valor1TemPonto = Display.Text.Contains(".");
                valor1 = Convert.ToDouble(Display.Text);
                Display.Text = "";
                operacaoSelecionada = true;
            }
        }
        private void ponto_Click(object sender, EventArgs e)
        {
            //ponto
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }

            if (!Display.Text.Contains("."))
            {
                Display.Text += ".";
            }
        }

 

        private void tl0_Click(object sender, EventArgs e)
        {
            //tecla 0
            if (prontoParaNovaOperacao)
            {
                Display.Text = "";
                operacaoSelecionada = false;
                prontoParaNovaOperacao = false;
            }
            Display.Text += "0";
        }

        private void raiz_quadrada_Click(object sender, EventArgs e)
        {
            if (!operacaoSelecionada && !string.IsNullOrWhiteSpace(Display.Text))
            {   // raiz quadrada
                valor1 = Convert.ToDouble(Display.Text);
                valor1TemPonto = Display.Text.Contains(".");
                final = Math.Sqrt(valor1);
                Display.Text = final.ToString();
                operacaoSelecionada = true;
            }
        }
        private void resultado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Display.Text))
                return;
            //resultado
            valor2TemPonto = Display.Text.Contains(".");
            valor2 = Convert.ToDouble(Display.Text);

            switch (operation)
            {
                case 1:
                    final = valor1 + valor2; // Soma
                    break;
                case 2:
                    final = valor1 - valor2; // Subtração
                    break;
                case 3:
                    final = valor1 * valor2; // Multiplicação
                    break;
                case 4:
                    if (valor2 == 0)
                    {
                        Display.Text = "Erro";
                        operacaoSelecionada = false;
                        return;
                    }
                    final = valor1 / valor2;
                    break;
                case 5:
                    final = Math.Pow(valor1, valor2); // Potenciação
                    break;
                case 6:
                    final = (valor1 / 100) * valor2;
                    break;
            }

            // Verifica se algum valor tinha ponto
            if (valor1TemPonto || valor2TemPonto)
                Display.Text = final.ToString("F1"); // sempre mostra uma casa decimal (ex: 5.0)
            else if (final % 1 == 0)
                Display.Text = ((int)final).ToString(); // exibe como inteiro
            else
                Display.Text = final.ToString(); // exibe decimal normalmente

            valor1 = final;
            valor1TemPonto = Display.Text.Contains("."); //evita uso de dois pontos
            operacaoSelecionada = false; //evita uso de dois sinais
            prontoParaNovaOperacao = true; // permite nova operação porq tava bugando

            //madeby.CharlieTyo

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
