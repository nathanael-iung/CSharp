using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208POO.Modelos
{
    class Carro : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public float Carteira { get; set; }
        
        public void Acelerar()
        {
            Console.WriteLine("Uno Acelerando...VRUUUUUM");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Uno Desacelerando...IIIIIRRRR");
            Velocidade -= 3;
        }

        public void Infracao()
        {
            Console.WriteLine("Infração cometida. 10 pontos na carteira. Multa de R$1550,00.");
            Carteira -= 1550;
        }
    }
}
