using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_calculadora
{
    public partial class Form1 : Form
    {
        double valor1;
        double valor2;
        double resultado;
        string calculo;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //ligando as Variáveis as caixas
            valor1 = double.Parse(primeiro_valor.Text);
            valor2 = double.Parse(segundo_valor.Text);
            calculo = operacao.Text;
            
            //Switch para fazer os calculos
            switch (calculo)
            {
                case "+": // Caso digitar + ele vai somar
                    resultado = valor1 + valor2;
                    break;
                case "-": //Caso digitar - ele vai subtrair
                    resultado = valor1 - valor2;
                    break;
                case "/": //Caso digitar / ele vai dividir
                    resultado = valor1 / valor2;
                    break;
                case "x": //Caso digitar x ele vai multiplicar
                    resultado = valor1 * valor2;
                    break;
                default: //Caso o usuário digite errado ele da um valor negativo e um aviso
                    resultado = -1;
                    break;

            }

            //If para imprimir os calculos
            if (resultado == -1)
            {
                        Aviso.Text = "Escolha apenas os caracteres mostrados no topo da página".ToUpper();
                        operacao.Text = "!!!!!!!atenção!!!!!!!".ToUpper();
            }
            else
            {
                resultado_do_calculo.Text = Convert.ToString("O resultado é: " + resultado);
            }

        }

        //Config para o botão para limpar todos o campos de texto
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            primeiro_valor.Text = "";
            segundo_valor.Text = "";
            operacao.Text = "";
            Aviso.Text = "";
            resultado_do_calculo.Text = "O resultado é: ___";

        }
    }
}
