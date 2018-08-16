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
        long n1 = 0;
        long n2 = 0;
        long? mem = null;
        String op = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 1;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 1;
                txtResultado.Text = n2.ToString();
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 2;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 2;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 3;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 3;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 4;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 4;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 5;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 5;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 6;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 6;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 7;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 7;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 8;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 8;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 9;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 9;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10);
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10);
                txtResultado.Text = n2.ToString();
            }
        }

        private void btnAdicao_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            //O número 0 será mostrado na tela assim que o símbolo for pressionado
            txtResultado.Text = "";
        }

        private void btnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            //O número 0 será mostrado na tela assim que o símbolo for pressionado
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            //O número 0 será mostrado na tela assim que o símbolo for pressionado
            txtResultado.Text = ""; 
        }

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            //O número 0 será mostrado na tela assim que o símbolo for pressionado
            txtResultado.Text = "";
        }

        private void btnRaizQuadrada_Click(object sender, RoutedEventArgs e)
        {
            //Símbolo: ALT + 1141 no campo selecionar do mapa de caracteres
            if (String.IsNullOrEmpty(op))
            {
                //Raiz quadrada de "n1"
                txtResultado.Text = Math.Sqrt(n1).ToString();
                //Função para converter "n1" para int para que seja armazenada na variável, e então executar a raiz quadrada
                n1 = Convert.ToInt64(Math.Sqrt(n1));
            }
            else
            {
                //Raiz quadrada de "n2"
                txtResultado.Text = Math.Sqrt(n2).ToString();
                //Função para converter "n2" para int para que seja armazenada na variável, e então executar a raiz quadrada
                n2 = Convert.ToInt64(Math.Sqrt(n2));
            }
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {

            switch (op)
            {
                //caso "op" esteja preenchido com +, a conta será efetuada
                case "+":
                    txtResultado.Text = (n1 + n2).ToString();
                    mem = n1 + n2;
                    break;

                //caso "op" esteja preenchido com -, a conta será efetuada
                case "-":
                    txtResultado.Text = (n1 - n2).ToString();
                    mem = n1 - n2;
                    break;

                //caso "op" esteja preenchido com *, a conta será efetuada
                case "*":
                    txtResultado.Text = (n1 * n2).ToString();
                    mem = n1 * n2;
                    break;

                //caso "op" esteja preenchido com /, a conta será efetuada
                case "/":
                    txtResultado.Text = (n1 / n2).ToString();
                    mem = n1 / n2;
                    break;

            }

        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            //Função para identificar se a variável "op" esta vazia. Caso esteja, o if é executada, caso contrario o else será executado
            //Dividir por 10 para que o último número seja apagado. Funcional para varíáveis long e int. Não-funcional para float e Double.
            //Variável deve ser convertida para que seja exibida dentro do TextBox do WPF
            //Símbolo: ALT + 27
            if (String.IsNullOrEmpty(op))
            {
                n1 = n1 / 10;
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = n2 / 10;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btnCe_Click(object sender, RoutedEventArgs e)
        {
            //Zerar as variáveis para resetar a conta
            //Símbolo: ALT + 0140
            n1 = 0;
            n2 = 0;
            op = "";
            //Zerar o resultado na tela ao pressionar o botão
            txtResultado.Text = "0";
        }

        private void btnMemoria_Click(object sender, RoutedEventArgs e)
        {
            txtUltimoResultado.Text = mem.ToString();
            if (String.IsNullOrEmpty(op) && mem.HasValue == true)
            {
                
            }
        }
    }

}
