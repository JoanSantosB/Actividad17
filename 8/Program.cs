bool correcto = false;
do
{
    Console.Write("Ingrese un número: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        if (numero > 0)
        {
            bool exacta = false;
            for (int i = 1; i <= numero; i++)
            {
                if (i * i == numero)
                {
                    exacta = true;
                    break;
                }
            }
            if(exacta)
            {
                Console.WriteLine($"El número {numero} tiene raíz cuadrada exacta");
                correcto = true;
            }
            else
            {
                Console.WriteLine($"El número {numero} no tiene raíz cuadrada exacta");
                correcto = true;
            }
        }
        else
        {
            Console.WriteLine("Error debe ingresar un número positivo");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
    }
} while (!correcto);