using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console
{
    class Program
    {

        public static int n1 { get; set; }
        public static int n2 { get; set; }
        public static int result { get; set; }


        static void Main(string[] args)
        {
            int op;
            //Console.WriteLine("Hello World...\n");
            Console.WriteLine("==========================  Calculadora básica  ==========================");

            do
            {

                Console.WriteLine("\nDigite o 1° número: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite o 2° número: ");
                n2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEscolha a operação a ser efetuada: \n1 - #Soma \n2 - #Subtração \n3 - #Multiplicação \n4 - #Divisão \n0 - #Sair\n");
                Console.WriteLine("Digite sua opção: ");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    result = imprimirSoma(n1, n2);
                }
                else if (op == 2)
                {
                    result = imprimirSubtracao(n1, n2);
                }
                else if (op == 3)
                {
                    result = imprimirMultiplicacao(n1, n2);
                }
                else if (op == 4)
                {
                    imprimirDivisao(n1, n2);
                }
                else if (op == 0)
                {
                    break;
                }

                Console.WriteLine("\nResultado = " + result);

            } while (op != 0);

        }

        static int imprimirSoma(int n1, int n2)
        {
            int res = n1 + n2;
            return res;
        }

        static int imprimirSubtracao(int n1, int n2)
        {
            int res = n1 - n2;
            return res;
        }

        static int imprimirMultiplicacao(int n1, int n2)
        {
            int res = n1 * n2;
            return res;
        }

        static int imprimirDivisao(int n1, int n2)
        {
            int res = n1 / n2;
            return res;
        }
    }
}
