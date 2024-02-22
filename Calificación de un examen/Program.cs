try
{
    int nota1;
    Console.Write("Hola! Por favor ingrese su calificación: ");
    string nota = Console.ReadLine();
    if (int.TryParse(nota, out nota1))
    {
        Convert.ToInt32(nota1);
        switch (nota1)
        {
            case >= 85 and <= 100:
                Console.WriteLine();
                Console.WriteLine("Felicidades! Usted tiene una mente brillante siga asi!");
                break;
            case >= 75 and <= 84:
                Console.WriteLine();
                Console.WriteLine("Seguro te esforzaste mucho este semestre, obtuviste una nota notable y eso es de admirar, sigue esfozandote por tus sueños");
                break;
            case >= 71 and <= 74:
                Console.WriteLine();
                Console.WriteLine("Ambos sabemos que no es la mejor nota del mundo, pero superamos por poco al semestre, felicidades y trata de mejorar");
                break;
            case 70:
                Console.WriteLine();
                Console.WriteLine("Pasamos por los pelos, peleamos y recuperamos el semestre, pero que no se vuelva a repetir ¿eh?");
                break;
            case >= 60 and <= 69:
                Console.WriteLine();
                Console.WriteLine("Bien, parece que el semestre fue mas fuerte que nosotros, ni modo amigo, nos vemos en recuperaciones :3");
                break;
            case >= 0 and <= 59:
                Console.WriteLine();
                Console.WriteLine("No voy a comentar nada ok?...");
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("A donde tan rapido campeon? La nota ingresada no es valida, regresa y coloca una valida");
                break;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Por favor ingresa un numero entero o sin letras");
    }
}
catch (Exception error)
{
    Console.WriteLine();
    Console.WriteLine("Ha ocurrido un error " + error);
}