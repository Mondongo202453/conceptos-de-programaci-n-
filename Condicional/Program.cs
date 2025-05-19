do{
    Console.WriteLine("Elija una opcion de habitacion. ");
    Console.WriteLine("1. Habitacion de los suegros");
    Console.WriteLine("2. Habitacion de la hermana");
    Console.WriteLine("3. Habitacion del hermano");
    Console.WriteLine("4. Habitacion de la novia");
    var habitacion = int.Parse(Console.ReadLine());

    if (habitacion == 1)
    {
        Console.WriteLine("Saludo con todo respeto");

        Console.WriteLine("Suegro me permite salir con su hija a dar un rose ");

        var permiso = int.Parse(Console.ReadLine());

        if (permiso == 1)
            Console.WriteLine("si, la trae a las 12, tome pa que compre proteccion");
        else
            Console.WriteLine("no, vallan a la habitacion");

    }
    else if (habitacion == 2)
    {
        Console.WriteLine("hola");
    }
    else if (habitacion == 3)
    {
        Console.WriteLine("Aqui no fue");
    }
    else
    {
        Console.WriteLine("Accion");
    }

} while (true);

