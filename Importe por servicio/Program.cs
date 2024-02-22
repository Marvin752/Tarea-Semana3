try
{
    Console.WriteLine("Bienvenido a su taller de confianza ¿Que servicio desea recibir hoy?");
    Console.WriteLine();
    Console.WriteLine("1) Lavado de auto");
    Console.WriteLine("2) Cambio de aceite");
    Console.WriteLine("3) Revisión mecánica");
    Console.WriteLine();
    Console.Write("> ");
    string numero = Console.ReadLine();
    switch (numero)
    {
        case "1":
            Console.WriteLine();
            Console.WriteLine("Por lavado de su auto seran Q40");
            break;
        case "2":
            Console.WriteLine();
            Console.WriteLine("Por el cambio de aceite seran Q200");
            break;
        case "3":
            Console.WriteLine();
            Console.WriteLine("Por la revisión mecánica seran Q500");
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