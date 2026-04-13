bool correcto = false;
do
{
    Console.Write("Ingrese un número: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {

        correcto = true;
        if(numero%2==0)
        {
            Console.WriteLine($"El número {numero} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
    }
} while (!correcto);