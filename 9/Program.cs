bool correcto = false;
do
{
    Console.Write("Ingrese una nota: ");
    if (int.TryParse(Console.ReadLine(), out int nota))
    {
        if (nota >= 0 && nota <= 100)
        {
            correcto = true;
            if (nota < 60)
            {
                Console.WriteLine($"Nota {nota}--Reprobada");
            }
            else
            {
                Console.WriteLine($"Nota {nota}--Aprobada");
            }
        }
        else
        {
            Console.WriteLine("Error debe la nota debe estar en un rango de 0 a 100.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese una nota válida.");
    }
} while (!correcto);