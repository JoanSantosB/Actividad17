using System.Net;

bool correcto = false;
do
{
    Console.Write("Ingrese la cantidad de productos a comprar: ");
    if (int.TryParse(Console.ReadLine(), out int cantidad)&&cantidad>0)
    {
        correcto = true;
        for(int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese el producto {i}: ");
            if(double.TryParse(Console.ReadLine(),out double precio) && precio >= 0)
            {
                Console.WriteLine($"Producto: {i}--Precio: {precio:F2}");
            }
            else
            {
                Console.WriteLine("Error ingreseo un dato inválido");
                i--;
            }
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese una cantidad válida.");
    }
} while (!correcto);