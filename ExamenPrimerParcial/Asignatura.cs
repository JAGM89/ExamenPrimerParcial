

using System.Security.Cryptography.X509Certificates;

namespace ExamenPrimerParcial
{
    public class Asignatura:Alumno, IAsignatura
    {
        public double N1 {  get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }
        public string NombreAsignatura {  get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1+N2+N3;
        }

        public double CalcularNotaFinal(double N1, double N2, double N3)
        {
            return N1+ N2 + N3;
        }

       

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal < 60)
                return "Reprobado";
            else if (notaFinal < 80)
                return "Bueno";
            else if (notaFinal < 90)
                return "Muy bueno";
            else
                return "Sobresaliente";
        }

        public void Imprimir()
        {
            double NotaSinParametros=CalcularNotaFinal();
            double NotaConParametros=CalcularNotaFinal(N1,N2,N3);

            Console.WriteLine("");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Numero de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electronico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del Docente: {NombreDocente}");
            Console.WriteLine($"Nota Final: {NotaSinParametros}% -  {MensajeNotaFinal(NotaSinParametros)}");
            Console.WriteLine($"Nota Final: {NotaConParametros}% -  {MensajeNotaFinal(NotaConParametros)}");
            Console.WriteLine("******************************************************************************");

        }


    }
}
