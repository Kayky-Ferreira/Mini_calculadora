﻿using System;
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
        float valor1;
        float valor2;
        float resultado;
        string calculo;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(primeiro_valor.Text);
            valor2 = float.Parse(segundo_valor.Text);
            calculo = resultado_da_soma.Text;
            

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


            if (resultado == -1)
                    {
                        Aviso.Text = "Escolha apenas os caracteres mostrados no topo da página";
                        operacao.Text = "!!!!";
                    }


            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
