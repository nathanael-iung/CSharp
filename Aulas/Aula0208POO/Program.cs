using Aula0208POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro uno = new Carro();
            uno.Modelo = "Uno com escada no teto";
            uno.Ano = 98;
            uno.Placa = "ABC-1234";
            uno.Acelerar();
            uno.Acelerar();
            uno.Frenar();
            uno.Infracao();
            ExecutarTesteMotor(uno);
            Console.WriteLine("\n");
            Console.ReadKey();

            Moto h2r = new Moto();
            h2r.Modelo = ("Kawasaki Ninja H2R");
            h2r.Ano = 2018;
            h2r.Placa = ("|||-||||");
            h2r.Acelerar();
            h2r.Acelerar();
            h2r.Frenar();
            h2r.Infracao();
            h2r.Infracao();
            ExecutarTesteMotor(h2r);
            Console.WriteLine("\n");
            Console.ReadKey();

        }

        static void ExecutarTesteMotor(IMotorizado vec)
        {
            Console.WriteLine("\n\nVelocidade atual: " + vec.Velocidade);
            Console.WriteLine("--Nìvel da pobreza: R$" + vec.Carteira);
        }
    }
}
