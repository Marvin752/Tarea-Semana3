try
{
    Console.Write("Escriba un numero del 1 al 7: ");
    string numero = Console.ReadLine();
    switch (numero)
    {
        case "1":
            Console.WriteLine();
            Console.WriteLine("Lunes");
            break;
        case "2":
            Console.WriteLine();
            Console.WriteLine("Martes");
            break;
        case "3":
            Console.WriteLine();
            Console.WriteLine("Miercoles");
            break;
        case "4":
            Console.WriteLine();
            Console.WriteLine("Jueves");
            break;
        case "5":
            Console.WriteLine();
            Console.WriteLine("Viernes");
            break;
        case "6":
            Console.WriteLine();
            Console.WriteLine("Sabado");
            break;
        case "7":
            Console.WriteLine();
            Console.WriteLine("Domingo");
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("El dato ingresado no es valido");
            break;
    }
}
catch (Exception error)
{
    Console.WriteLine();
    Console.WriteLine("Ha ocurrido un error " + error);
}

