try
{
    int edad1;
    decimal cant1;
    Console.WriteLine("Bienvenido al banco, para analizar su prestamo por favor ingrese los siguentes datos: ");
    Console.WriteLine("");
    Console.Write("Ingrese su edad: ");
    String edad = Console.ReadLine();
    while (!int.TryParse(edad, out edad1))
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese su edad correctamente");
        Console.WriteLine("");
        Console.Write("Ingrese su edad: ");
        edad = Console.ReadLine();
    }
    Console.Write("Ingrese la cantidad del prestamo: Q");
    String cant = Console.ReadLine();
    while (!decimal.TryParse(cant, out cant1))
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese la cantidad solicitada correctamente");
        Console.WriteLine("");
        Console.Write("Ingrese la cantidad: Q");
        cant = Console.ReadLine();
    }
    if(cant1 < 5000 || edad1 > 60)
    {
        Console.WriteLine("");
        Console.WriteLine("El prestamo fue aprovado");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("El prestamo fue denegado");
    }
}
catch (Exception error)
{
    Console.WriteLine("Ha ocurrido un error " + error);
}