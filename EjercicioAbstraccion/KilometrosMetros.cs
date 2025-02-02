

namespace EjercicioAbstraccion
{
    public class KilometrosMetros : FormulaMatematica
    {
        public double Kilometros, Metros;

        public KilometrosMetros()
        {
        }

        public KilometrosMetros(double Kilometros, double Metros)
        {
            this.Kilometros = Kilometros;
            this.Metros = Metros;
        }

        public override void Calcular()
        {
            Metros = Kilometros * 1000;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{Kilometros} Kms equivalen a {Metros} metros");
        }
    }
}
