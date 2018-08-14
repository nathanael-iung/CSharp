using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float n1, n2, memoria, mem, temp = 0;
        String op = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            //Exibição direta na tela do número pressionado
            txtResultado.Text += "0";
        }

        private void btnVirgula_Click(object sender, RoutedEventArgs e)
        {
            //Inserção da " , " na tela
            txtResultado.Text += ",";
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                //caso "op" esteja preenchido com +, a conta será efetuada
                case "+":
                    memoria += float.Parse(txtResultado.Text);
                    txtResultado.Text = memoria.ToString();
                    break;

                //caso "op" esteja preenchido com -, a conta será efetuada
                case "-":
                    memoria -= float.Parse(txtResultado.Text);
                    txtResultado.Text = memoria.ToString();
                    break;

                //caso "op" esteja preenchido com *, a conta será efetuada
                case "*":
                    memoria *= float.Parse(txtResultado.Text);
                    txtResultado.Text = memoria.ToString();
                    break;

                //caso "op" esteja preenchido com /, a conta será efetuada
                case "/":
                    memoria /= float.Parse(txtResultado.Text);
                    txtResultado.Text = memoria.ToString();
                    break;

                //caso "op" esteja preenchido com pot, a conta será efetuada
                case "pot":
                    txtResultado.Text = (Math.Pow(memoria, float.Parse(txtResultado.Text)).ToString());
                    break;
            }
        }

        private void btnAdicao_Click(object sender, RoutedEventArgs e)
        {
            //Caso a variável "op" estja preenchida com outro sinal, ocorre a alteração
            //"memoria" será responsável por armazenar o que está na tela para futuras operações
            if (op == "-" || op == "/" || op == "*" || op == "pot" || op == "m+")
            {
                op = "+";
            }
            else
            {
                memoria = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                op = "+";
            }
        }

        private void btnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            //Caso a variável "op" estja preenchida com outro sinal, ocorre a alteração
            //"memoria" será responsável por armazenar o que está na tela para futuras operações
            if (op == "-" || op == "/" || op == "*" || op == "pot" || op == "m+")
            {
                op = "-";
            }
            else
            {
                memoria = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                op = "-";
            }
        }

        private void btnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            //Caso a variável "op" estja preenchida com outro sinal, ocorre a alteração
            //"memoria" será responsável por armazenar o que está na tela para futuras operações
            if (op == "-" || op == "/" || op == "*" || op == "pot" || op == "m+")
            {
                op = "*";
            }
            else
            {
                memoria = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                op = "*";
            }
        }

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {
            //Caso a variável "op" estja preenchida com outro sinal, ocorre a alteração
            //"memoria" será responsável por armazenar o que está na tela para futuras operações
            //Símbolo: ALT + 246
            if (op == "-" || op == "/" || op == "*" || op == "pot" || op == "m+")
            {
                op = "/";
            }
            else
            {
                memoria = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                op = "/";
            }
        }

        private void btnPotenciacao_Click(object sender, RoutedEventArgs e)
        {
            //Caso a variável "op" estja preenchida com outro sinal, ocorre a alteração
            //"memoria" será responsável por armazenar o que está na tela para futuras operações
            if (op == "-" || op == "/" || op == "*" || op == "pot" || op == "m+")
            {
                op = "pot";
            }
            else
            {
                memoria = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                op = "pot";
            }
        }

        private void btnRaizQuadrada_Click(object sender, RoutedEventArgs e)
        {
            //Validação do número positivo e realização da operação
            //Símbolo: ALT + 1141 no campo selecionar do mapa de caracteres
            float num = float.Parse(txtResultado.Text);

            if (num < 0)
            {
                txtResultado.Text = "Inválido. Raiz quadrada de número negativo.";
            }
            else
            {
                txtResultado.Text = Math.Sqrt(num).ToString();
            }
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            //Função para apagar o último número digitado. x receberá a quantia de caracteres da String - 1;
            //O if exibirá a string do início até x.
            //Símbolo: ALT + 27
            int x = txtResultado.Text.Length - 1;
            if (x >= 0)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, x);
            }
        }

        private void btnCe_Click(object sender, RoutedEventArgs e)
        {
            //Zerar as variáveis para resetar a conta
            //Símbolo: ALT + 0140
            n1 = n2 = memoria = 0;
            op = "";
            //Zerar o resultado na tela ao pressionar o botão
            txtResultado.Text = "";
        }

        private void btnMs_Click(object sender, RoutedEventArgs e)
        {
            //"mem" armazenará o que está na tela quando MS for pressionado
            //MR receberá o que está em "mem"
            mem = float.Parse(txtResultado.Text.ToString());
            txtMr.Text = mem.ToString();
        }

        private void btnMc_Click(object sender, RoutedEventArgs e)
        {
            //MC irá zerar o que está armazenado na memoria da calculadora
            mem = 0;
            txtMr.Text = "";
        }

        private void btnMmais_Click(object sender, RoutedEventArgs e)
        {
            memoria += float.Parse(txtResultado.Text) + mem;
            txtResultado.Text = memoria.ToString();
        }

        private void btnMmenos_Click(object sender, RoutedEventArgs e)
        {
            memoria -= float.Parse(txtResultado.Text) - mem;
            txtResultado.Text = memoria.ToString();
        }
    }
}
