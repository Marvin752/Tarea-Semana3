try
{
    int pipi, num2;
    string num1;
    Console.Write("Ingrese un numero entero: ");
    num1 = Console.ReadLine();
    while (!int.TryParse(num1, out num2))
    {
        Console.WriteLine("");
        Console.WriteLine("El numero que ingreso no tiene el formato correcto");
        Console.WriteLine("");
        Console.Write("Ingrese el numero nuevamente: ");
        num1 = Console.ReadLine();
    }
    pipi = num2 % 2;
    if (num2 == 0)
    {
        Console.WriteLine("");
        Console.WriteLine("El numero 0 no es par ni impar");
    }
    else
    {
        if (pipi == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("El numero es impar");
        }
    }
}
catch (Exception error)
{
    Console.WriteLine("");
    Console.WriteLine("Ha ocurrido un error " +  error);
}
