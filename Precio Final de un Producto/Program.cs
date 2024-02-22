try
{
    Console.WriteLine("Bienvenido a Tiendas el Plomero");
    Console.Write("Ingrese el precio del producto que desea comprar Q");
    string precio = Console.ReadLine();
    decimal preciop;
    while (!decimal.TryParse(precio, out preciop))
    {
        Console.WriteLine("El precio fue ingresado de forma incorrecta");
        Console.Write("Ingrese de nuevo el precio del producto Q ");
        precio = Console.ReadLine();
    }
    if (preciop > 100)
    {
        decimal descu = preciop * 0.25m;
        preciop = preciop - descu;
        Console.WriteLine("El precio final es de Q" + preciop.ToString("0.00"));
    }
    else
    {
        Console.WriteLine("El precio final es de Q" + preciop.ToString("0.00"));
    }
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error " + error);
}