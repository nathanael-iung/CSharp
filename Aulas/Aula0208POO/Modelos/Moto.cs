using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208POO.Modelos
{
    class Moto : Veiculo, IMotorizado

    {
        public int Velocidade { get; set; }
        public float Carteira { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("R1 Acelerando...");
            Velocidade += 150;
        }

        public void Frenar()
        {
            Console.WriteLine("R1 Desacelerando...");
            Velocidade -= 120;
        }

        public void Infracao()
        {
            Console.WriteLine("Infração cometida. 5 pontos na carteira. Multa de R$658,00");
            Carteira -= 658;
        }
    }
}
