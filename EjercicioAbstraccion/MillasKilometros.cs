
namespace EjercicioAbstraccion
{
    public class MillasKilometros : FormulaMatematica
    {
        public double Millas, Kilometros;

        public MillasKilometros()
        {
        }

        public MillasKilometros(double Millas, double Kilometros)
        {
            this.Millas = Millas;
            this.Kilometros = Kilometros;
        }

        public override void Calcular()
        {
            Kilometros = Millas * 1.60934;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{Millas} millas equivalen a {Kilometros} kms");
        }
    }
}
