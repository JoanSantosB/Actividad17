bool correcto = false;
do
{
    Console.Write("Ingrese su año de nacimiento: ");
    if (int.TryParse(Console.ReadLine(), out int year))
    {
        if (year >= 1900 && year <= 2026)
        {
            Console.WriteLine($"Año correcto: {year}");
            correcto = true;
        }
        else
        {
            Console.WriteLine("El año no esta en el rango de 1900 a 2026");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
    }
} while (!correcto);