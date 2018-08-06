
namespace Aula0208POO.Modelos
{
    interface IMotorizado
    {
        int Velocidade { get; set; }
        float Carteira { get; set; }

        void Acelerar();
        void Frenar();
        void Infracao();

    }
}
