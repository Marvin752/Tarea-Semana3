try
{
    Console.WriteLine("¿A que tipo de figura le desea medir el area?");
    Console.WriteLine("");
    Console.WriteLine("1) Triangulo");
    Console.WriteLine("2) Cuadrado");
    Console.WriteLine("3) Circulo");
    Console.WriteLine("");
    Console.Write("> ");
    int deci = Convert.ToInt32(Console.ReadLine());
    if (deci == 1)
    {
        Console.WriteLine("");
        Console.Write("Ingrese la base del triangulo: ");
        decimal baset = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese la altura del triangulo: ");
        decimal altut = Convert.ToDecimal(Console.ReadLine());
        decimal areat = (baset * altut) / 2;
        Console.WriteLine("");
        Console.WriteLine("El area del triagunlo es: " + areat);
    }
    else if (deci == 2)
    {
        Console.WriteLine("");
        Console.Write("Ingrese la medida de un lado del cuadrado: ");
        decimal ladoc = Convert.ToDecimal(Console.ReadLine());
        decimal areac = ladoc * ladoc;
        Console.WriteLine("");
        Console.WriteLine("El area del cuadrado es de: " + areac);
    }
    else if (deci == 3)
        {
            Console.WriteLine("");
            Console.Write("Ingrese el radio del circulo: ");
            double radc = Convert.ToDouble(Console.ReadLine());
            double areaci = (Math.Pow(radc, 2)) * 3.1416d;
            Console.WriteLine("");
            Console.WriteLine("El area del ciruclo es de: " + areaci);
        }else
    {
        Console.WriteLine("");
        Console.WriteLine("La opcion ingresada no corresponde a ninguna figura :3");
    }
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error " + error);
}