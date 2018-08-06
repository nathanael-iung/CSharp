using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208POO.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public float Carteira { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Barco Acelerando...");
            Velocidade += 15;
        }

        public void Frenar()
        {
            Console.WriteLine("Frenagem do barco acionada...");
            Velocidade += 2;
        }

        public void Infracao()
        {
            Console.WriteLine("Infração cometida. Multa de R$ 3500,00");
            Carteira -= 3500;
        }
    }
}
