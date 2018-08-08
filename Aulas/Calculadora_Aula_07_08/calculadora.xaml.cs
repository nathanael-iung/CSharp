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

namespace Calculadora_Aula_07_08
{
    /// <summary>
    /// Interaction logic for Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        long n1 = 0;
        //long n2 = 0;
        //String op = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            n1 = (n1 * 10) + 1;
            
        }
    }
}
