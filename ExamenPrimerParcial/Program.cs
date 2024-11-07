using ExamenPrimerParcial;

class program
{
    public static void Main(string[] args)
    {
        Asignatura asignatura = new Asignatura();

        Console.WriteLine("Nombre del alumno: ");
        asignatura.NombreAlumno = Console.ReadLine();

        Console.WriteLine("Numero de cuenta: ");
        asignatura.NumeroCuenta = Console.ReadLine();

        Console.WriteLine("Email: ");
        asignatura.Email= Console.ReadLine();


        Console.WriteLine("Nombre de la asignatura: ");
        asignatura.NombreAsignatura = Console.ReadLine();

        Console.WriteLine("Horario: ");
        asignatura.Horario = Console.ReadLine();

        Console.WriteLine("Nombre del docente: ");
        asignatura.NombreDocente = Console.ReadLine();
        Console.WriteLine("");


        try
        {


            while (true)
            {
                Console.WriteLine("Nota del primer parcial (máximo 30): ");
                asignatura.N1 = Convert.ToDouble(Console.ReadLine());

                if (asignatura.N1 <= 30 & asignatura.N1 >= 0) 
                    break; // Sale del bucle si el valor es correcto
                else
                    Console.WriteLine("La Nota del primer parcial no puede exceder el 30%. Inténtalo de nuevo.");
            }

            while (true)
            {
                Console.WriteLine("Nota del segundo parcial (máximo 30): ");
                asignatura.N2 = Convert.ToDouble(Console.ReadLine());

                if (asignatura.N2 <= 30 & asignatura.N2 >= 0)
                    break; // Sale del bucle si el valor es correcto
                else
                    Console.WriteLine("La Nota del segundo parcial no puede exceder el 30%. Inténtalo de nuevo.");
            }

            while (true)
            {
                Console.WriteLine("Nota del tercer parcial (máximo 40): ");
                asignatura.N3 = Convert.ToDouble(Console.ReadLine());

                if (asignatura.N3 <= 40 & asignatura.N3 >= 0)
                    break; // Sale del bucle si el valor es correcto
                else
                    Console.WriteLine("La Nota del tercer parcial no puede exceder el 40%. Inténtalo de nuevo.");
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return;
        }


        asignatura.Imprimir();



    }
}