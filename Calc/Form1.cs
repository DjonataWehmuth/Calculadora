using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double resultado = 0;
        string operador = "";
        
        public Form1()
        {
            InitializeComponent();
            hostorico.Enabled = false;
            tela.Enabled = false;
        }

        private void numero0_Click(object sender, EventArgs e)
        {
            setNumero(0);
        }

        private void numero00_Click(object sender, EventArgs e)
        {
            setNumero(00);
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            setNumero(1);
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            setNumero(2);
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            setNumero(3);
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            setNumero(4);
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            setNumero(5);
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            setNumero(6);
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            setNumero(7);
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            setNumero(8);
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            setNumero(9);
        }

        private void hostorico_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tela_TextChanged(object sender, EventArgs e)
        {

        }

        public void setOperador(String Operador)
        {
            if (resultado != 0)
            {
                num1 = resultado;
                resultado = 0;
                num2 = 0;
                hostorico.Text = num1 + Operador;
                tela.Text = "";
                operador = Operador;
                Operador = "";
            }
            else
            {
                if (operador != Operador)
                {
                    operador = Operador;
                    hostorico.Text = hostorico.Text + Operador;
                    tela.Text = "";
                }
                else if (operador == "")
                {
                    num1 = double.Parse(tela.Text);
                    hostorico.Text = hostorico.Text + Operador;
                    operador = Operador;
                    tela.Text = "";
                }
            }
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            setOperador("+");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calc();
        }

        public void Calc(){
            num2 = double.Parse(tela.Text);
            if (operador == "+")
                {                
                hostorico.Text = hostorico.Text + " = ";
                resultado = num1 + num2;
                hostorico.Text = hostorico.Text + resultado.ToString();
                tela.Text = resultado.ToString();
            }
            else if (operador == "-")
            {
                hostorico.Text = hostorico.Text + " = ";
                resultado = num1 - num2;
                hostorico.Text = hostorico.Text + resultado.ToString();
                tela.Text = resultado.ToString();
            }
            else if (operador == "*")
            {
                hostorico.Text = hostorico.Text + " = ";
                resultado = num1 * num2;
                hostorico.Text = hostorico.Text + resultado.ToString();
                tela.Text = resultado.ToString();
            }
            else if (operador == "/")
            {
                hostorico.Text = hostorico.Text + " = ";
                resultado = num1 / num2;
                hostorico.Text = hostorico.Text + resultado.ToString();
                tela.Text = resultado.ToString();
            }
        }
            
        public void setNumero(double Numero)
        {
            hostorico.Text = hostorico.Text + Numero;
            tela.Text = tela.Text + Numero.ToString();
            if (operador == "")
            {
                if (num1 != 0)
                {
                    num1 = double.Parse(tela.Text);
                }
                else
                {
                    num1 = double.Parse(tela.Text);
                }
                
            }
            else if (operador != "")
            {
                if (num2 != 0)
                {
                    num2 = double.Parse(tela.Text);
                }else
                {
                    num2 = double.Parse(tela.Text);
                }
            }
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            setOperador("-");
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            setOperador("*");
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            setOperador("/");
        }

        private void zerar_Click(object sender, EventArgs e)
        {
            operador = "";
            num1 = 0;
            num2 = 0;
            resultado = 0;
            hostorico.Text = "";
            tela.Text = "";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
           
        }
    }
}