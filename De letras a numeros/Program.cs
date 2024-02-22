try
{
    Console.Write("Ingrese un numero del 1 al 5 en letras: ");
    string numero = Console.ReadLine().ToLower();
    switch (numero)
    {
        case "cinco":
            Console.WriteLine();
            Console.WriteLine(numero + ": 5");
            break;
        case "cuatro":
            Console.WriteLine();
            Console.WriteLine(numero + ": 4");
            break;
        case "tres":
            Console.WriteLine();
            Console.WriteLine(numero + ": 3");
            break;
        case "dos":
            Console.WriteLine();
            Console.WriteLine(numero + ": 2");
            break;
        case "uno":
            Console.WriteLine();
            Console.WriteLine(numero + ": 1");
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("El dato ingresado no es valido");
            break;
    }
}
catch(Exception error)
{
    Console.WriteLine();
    Console.WriteLine("Ha ocurrido un error " + error);
}

