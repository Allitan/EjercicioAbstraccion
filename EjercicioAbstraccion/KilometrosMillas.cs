

namespace EjercicioAbstraccion
{
    public class KilometrosMillas : FormulaMatematica
    {
        public double Kilometros, Millas;

        public KilometrosMillas()
        {

        }

        public KilometrosMillas(double kilometros, double millas)
        {
            this.Kilometros = kilometros;
            this.Millas = millas;
        }

        public override void Calcular()
        {
            Millas = Kilometros / 1.60934;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{Kilometros} kms equivalen a {Millas} millas");
        }
    }
}
