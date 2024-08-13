
namespace Pregunta1_PaolaDeras
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int nota1, int nota2, int nota3)
        {
            return nota1 + nota2 + nota3;
        }
        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal <= 59) return "Reprobado";
            else if (notaFinal <= 79) return "Bueno";
            else if (notaFinal <= 89) return "Muy Bueno";
            else return "Sobresaliente";
        }
        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();
            string mensaje = MensajeNotaFinal(notaFinal);

            Console.WriteLine("**************************************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electrónico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota final: {notaFinal}% - {mensaje}");

            notaFinal = CalcularNotaFinal(N1, N2, N3);
            mensaje = MensajeNotaFinal(notaFinal);

            Console.WriteLine($"Nota final: {notaFinal}% - {mensaje}");
            Console.WriteLine("**************************************************");

        }
    }
}
