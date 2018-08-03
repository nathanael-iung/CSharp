
namespace Aula0208POO.Modelos
{
    interface IMotorizado
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Frenar();

    }
}
