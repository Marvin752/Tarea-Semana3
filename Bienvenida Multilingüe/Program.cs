try
{
    Console.WriteLine("Select the language of your preference");
    Console.WriteLine();
    Console.WriteLine("1) Español");
    Console.WriteLine("2) Ingles");
    Console.WriteLine("3) Francés");
    Console.WriteLine();
    Console.Write("> ");
    string numero = Console.ReadLine();
    switch (numero)
    {
        case "1":
            Console.WriteLine();
            Console.WriteLine("Bienvenido a la empresa, esperamos que su desempeño sea de alta calidad, a su vez, queremos que se sienta como miembro de una gran familia.");
            Console.WriteLine("Recuerde que, con una sonrisa todo es posible :3");
            break;
        case "2":
            Console.WriteLine("Welcome to the company, we hope that your performance is of high quality, in turn, we want you to feel like a member of a big family.");
            Console.WriteLine("Remember that, with a smile anything is possible :3");
            break;
        case "3":
            Console.WriteLine();
            Console.WriteLine("Bienvenue dans l'entreprise, nous espérons que votre performance sera de haute qualité, à notre tour, nous voulons que vous vous sentiez comme un membre d'une grande famille.");
            Console.WriteLine("Rappelez-vous qu'avec le sourire, tout est possible :3");
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("The data entered is not valid");
            break;
    }
}
catch (Exception error)
{
    Console.WriteLine();
    Console.WriteLine("An error has occurred " + error);
}
