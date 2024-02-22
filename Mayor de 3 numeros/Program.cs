try
{
    string num1, num2, num3;
    float number1, number2, number3;
    Console.Write("Ingrese un numero a comparar: ");
    num1 = Console.ReadLine();
    while (!float.TryParse(num1, out number1))
    {
        Console.WriteLine("Lo que ingreso no es un numero");
        Console.Write("Ingrese de nuevo un numero a comparar: ");
        num1 = Console.ReadLine();
    }
    Console.Write("Ingrese el segundo numero: ");
    num2 = Console.ReadLine();
    while (!float.TryParse(num2, out number2))
    {
        Console.WriteLine("Lo que ingreso no es un numero");
        Console.Write("Ingrese de nuevo un numero a comparar: ");
        num2 = Console.ReadLine();
    }
    Console.Write("Ingrese el tercer numero: ");
    num3 = Console.ReadLine();
    while (!float.TryParse(num3, out number3))
    {
        Console.WriteLine("Lo que ingreso no es un numero");
        Console.Write("Ingrese de nuevo un numero a comparar: ");
        num3 = Console.ReadLine();
    }
    if (number1 == number2 && number2 == number3)
    {
        Console.WriteLine("Los 3 numeros son iguales");
    }
    else
    {
        float Max = Math.Max(number1, Math.Max(number2, number3));
        Console.WriteLine("El nuemro maximo es: " + Max);
    }
}
catch (Exception error)
{
    Console.WriteLine("Ha ocurrido un error " + error);
}