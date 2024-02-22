try
{
    Console.WriteLine("Bievenido, por favor crea un usuario y una contraseña");
    Console.Write("Usuario: ");
    String usu = Console.ReadLine();
    Console.Write("Contraseña: ");
    String cont = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("¿Estas satisfecho con tu usuario y contraseña?");
    int deci;
    Console.WriteLine("1) Si");
    Console.WriteLine("2) Cambiar usuario");
    Console.WriteLine("3) Cambiar contraseña");
    Console.WriteLine("");
    Console.Write("> ");
    deci = Convert.ToInt32(Console.ReadLine());
    while (deci != 1)
    {
        if (deci == 2)
        {
            Console.WriteLine("");
            Console.Write("Ingrese su usuario nuevamente: ");
            usu = Console.ReadLine();
        }
        else if (deci == 3)
        {
            Console.WriteLine("");
            Console.Write("Ingrese su contraseña nuevamente: ");
            cont = Console.ReadLine();
        }
        Console.WriteLine("");
        Console.WriteLine("¿Estas satisfecho con tu usuario y contraseña?");
        Console.WriteLine("1) Si");
        Console.WriteLine("2) Cambiar usuario");
        Console.WriteLine("3) Cambiar contraseña");
        Console.WriteLine("");
        Console.Write("> ");
        deci = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("");
    Console.WriteLine("Se guardardon correctamente los datos");
    Console.WriteLine("");
    Console.Write("Ingrese por favor su usuario: ");
    string usu1 = Console.ReadLine();
    Console.Write("Ingrese por favor su contraseña: ");
    string cont1 = Console.ReadLine();
    while (usu1 != usu || cont1 != cont)
    {
        Console.WriteLine("");
        Console.WriteLine("La contraseña o el usuario son incorrectos");
        Console.Write("Usuario: ");
        usu1 = Console.ReadLine();
        Console.Write("Contraseña: ");
        cont1 = Console.ReadLine();
    }
    Console.WriteLine("");
    Console.WriteLine("La sesión inicio correctamente");
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error " + error); 
}