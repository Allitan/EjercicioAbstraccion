
using EjercicioAbstraccion;

int opcion;
double km;

KilometrosMetros kilometrosMetros = new KilometrosMetros();
MillasKilometros millasKilometros = new MillasKilometros();
KilometrosMillas kilometrosMillas = new KilometrosMillas();


Console.WriteLine("***************************************");
Console.WriteLine("**************** MENU *****************");
Console.WriteLine("INGRESE LA OPERACION QUE DESEA REALIZAR");
Console.WriteLine("**** 1. PASAR KILOMETROS A METROS *****");
Console.WriteLine("**** 2. PASAR MILLAS A KILOMETROS *****");
Console.WriteLine("**** 3. PASAR KILOMETROS A MILLAS *****");
Console.WriteLine("**** 4. SALIR *************************");
opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
       case 1:
        Console.WriteLine("Ingrese la cantidad de kilometros: ");
        kilometrosMetros.Kilometros = Convert.ToInt32(Console.ReadLine());
        kilometrosMetros.Calcular();
        kilometrosMetros.Imprimir();
        break;

        case 2:
        Console.WriteLine("Ingrese la cantidad de millas: ");
        millasKilometros.Millas = Convert.ToInt32(Console.ReadLine());
        millasKilometros.Calcular();
        millasKilometros.Imprimir();
        break;

        case 3:
        Console.WriteLine("Ingrese la cantidad de kilometros: ");
        kilometrosMillas.Kilometros = Convert.ToInt32(Console.ReadLine());
        kilometrosMillas.Calcular();
        kilometrosMillas.Imprimir();
        break;

        case 4:
        Console.WriteLine("Saliendo...");
        return;

        default:
        Console.WriteLine("Opción no válida.");
        break;
}

