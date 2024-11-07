
namespace ExamenPrimerParcial
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal();//metodo sin parametros
        public double CalcularNotaFinal(double N1, double N2, double N3); //metodo con parametros
        public string MensajeNotaFinal (double notaFinal);//Mensaje

        public void Imprimir();






    }
}
