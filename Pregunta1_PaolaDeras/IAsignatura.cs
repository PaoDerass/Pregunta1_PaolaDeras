

namespace Pregunta1_PaolaDeras
{
    public interface IAsignatura
    {
        double CalcularNotaFinal();
        double CalcularNotaFinal(int nota1, int nota2, int nota3);
        string MensajeNotaFinal(double notaFinal);
        void Imprimir();

    }
}
