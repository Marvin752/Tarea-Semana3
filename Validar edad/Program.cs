try
{
    String edad;
    int edadtru;
    Console.WriteLine("\"Bienvenido a Sitio generico +18\"");
    Console.Write("Ingrese su edad en numros: ");
    edad = Console.ReadLine();
    while (!int.TryParse(edad, out edadtru))
    {
        Console.WriteLine("La edad ingresada no es valida");
        Console.Write("Ingrese su edad nuevamente: ");
        edad = Console.ReadLine();
    }
    if (edadtru >= 18)
    {
        Console.WriteLine("Entre señor bigotes");
    }
    else
    {
        Console.WriteLine("LLAMANDO A MAMÁ");
    }
}
catch (Exception error)
{
    Console.WriteLine("Ha ocurrido un error " + error);
}