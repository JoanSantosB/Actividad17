bool correcto = false;
do
{
    Console.Write("Ingrese una cantidad de estudiantes: ");
    if (int.TryParse(Console.ReadLine(), out int cantidad))
    {
        if (cantidad > 0)
        {
            Console.WriteLine($"Cantidad válida: {cantidad}");
            correcto = true;
        }
        else
        {
            Console.WriteLine("No se puede realizar esta opceración, debe ser una cantidad mayor que 0");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
    }
}while(!correcto);