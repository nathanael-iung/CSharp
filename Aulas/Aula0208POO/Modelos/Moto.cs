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
    
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
            Velocidade += 195;
        }

        public void Frenar()
        {
            Console.WriteLine("Desacelerando...");
            Velocidade += 5;
        }
    }
}
