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
            uno.Acelerar();
            ExecutarTesteMotor(uno);
            //Console.WriteLine("Velocidade: " +uno.Velocidade);
            Console.ReadKey();

            Moto r1 = new Moto();
            r1.Modelo = ("Yamaha YZF-R1");
        }

        static void ExecutarTesteMotor(IMotorizado vec)
        {
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Frenar();
            vec.Frenar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);


        }
    }
}
