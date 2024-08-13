using Pregunta1_PaolaDeras;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.Write("Ingrese el nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Ingrese número de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese correo electronico");
            asignatura.Email = Console.ReadLine();

            Console.Write("Ingrese nombre de la clase: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el horario de la clase:");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Ingrese nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del primer parcial (máximo 30):");
            asignatura.N1 = Convert.ToInt32(Console.ReadLine());
            if (asignatura.N1 > 30)
                throw new ArgumentOutOfRangeException("La nota del primer parcial no puede ser mayor a 30.");

            Console.WriteLine("Ingrese la nota del segundo parcial (máximo 30):");
            asignatura.N2 = Convert.ToInt32(Console.ReadLine());
            if (asignatura.N2 > 30)
                throw new ArgumentOutOfRangeException("La nota del segundo parcial no puede ser mayor a 30.");

            Console.WriteLine("Ingrese la nota del tercer parcial (máximo 40):");
            asignatura.N3 = Convert.ToInt32(Console.ReadLine());
            if (asignatura.N3 > 40)
                throw new ArgumentOutOfRangeException("La nota del tercer parcial no puede ser mayor a 40.");

            asignatura.Imprimir();
        }

        catch (FormatException)
        {
            Console.WriteLine("Una de las notas ingresadas no tiene el formato válido");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}


