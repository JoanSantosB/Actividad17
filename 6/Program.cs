bool correcto = false;
do
{
    Console.Write("Ingrese una fecha: ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
    {
        Console.WriteLine($"Fecha ingresada: {fecha.ToShortDateString()}");
        correcto = true;
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese una fecha válida.");
    }
} while (!correcto);