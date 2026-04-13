bool correcto = false;
do
{
    Console.Write("Ingrese un precio: ");
    if (double.TryParse(Console.ReadLine(), out double precio))
    {
        if (precio>0)
        {
            Console.WriteLine($"Este precio es correcto: {precio:F2}"); 
            correcto = true;
        }
        else
        {
            Console.WriteLine("El precio debe ser mayor que 0.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número decimal.");
    }
} while (!correcto);