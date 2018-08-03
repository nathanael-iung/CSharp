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

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...VRUUUUUM");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Desacelerando...IIIIIRRRR");
            Velocidade -= 3;
        }
    }
}
