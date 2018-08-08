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
        String op = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
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
            if (op == "")
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
            if (op == "")
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
            if (op == "")
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
            if (op == "")
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
            if (op == "")
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
            if (op == "")
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
            if (op == "")
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
            if (op == "")
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
            if (op == "")
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
            txtResultado.Text = "0";
        }

        private void btnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            txtResultado.Text = "0";
        }

        private void btnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            txtResultado.Text = "0";
        }

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            txtResultado.Text = "0";
        }

        private void btnRaizQuadrada_Click(object sender, RoutedEventArgs e)
        {
            //Símbolo: ALT + 1141 no campo selecionar do mapa de caracteres
            op = "√¯";
            txtResultado.Text = Math.Sqrt(n1).ToString();
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {

            switch (op)
            {
                case "+":
                    txtResultado.Text = (n1 + n2).ToString();
                    //txtResultado.Text = (n1 + " + " + n2 + " = " + n1 + n2).ToString();
                    break;

                case "-":
                    txtResultado.Text = (n1 - n2).ToString();
                    break;

                case "*":
                    txtResultado.Text = (n1 * n2).ToString();
                    break;

                case "/":
                    txtResultado.Text = (n1 / n2).ToString();
                    break;

            }

        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            //Símbolo: ALT + 27
            if(op == "")
            {
                n1 = 0;                
            }
            else
            {
                n2 = 0;               
            }

            txtResultado.Text = "0";
        }
    }

}
