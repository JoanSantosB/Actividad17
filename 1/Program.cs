bool correcto = false;
do
{
    Console.Write("Ingrese se una edad:");
    if(int.TryParse(Console.ReadLine(), out int edad))
    {
        if(edad > 0 && edad <= 120)
        {
            Console.WriteLine($"La edad ingresada es: {edad}");
            correcto = true;
        }
        else
        {
            Console.WriteLine("La edad debe estar entre 0 y 120.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
    }
} while(!correcto);