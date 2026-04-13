bool correcto = false;
do
{
    Console.Write("Ingrese un salario: ");
    if(double.TryParse(Console.ReadLine(),out double salario))
    {
        if (salario >= 0)
        {
            Console.WriteLine($"Salario ingresado: {salario:F2}");
            correcto = true;
        }
        else
        {
            Console.WriteLine("Error el salario debe ser un número positivo");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un salario válido.");
    }
}while(!correcto);