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

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
            Velocidade += 15;
        }

        public void Frenar()
        {
            Console.WriteLine("Frenagem acionada...");
            Velocidade += 2;
        }
    }
}
