using EspacioCadeteria;

    // Cargar los datos iniciales desde los archivos CSV
    Cadeteria miCadeteria = CargadorCsv.CargarCadeteria("cadeterias.csv");
    List<Cadete> listaCadetes = CargadorCsv.CargarCadetes("cadetes.csv");

    bool continuar = true;

    while (continuar)
    {
        Console.WriteLine("------ Sistema de Cadetería ------");
        Console.WriteLine("1. Dar de alta un pedido");
        Console.WriteLine("2. Asignar pedido a cadete");
        Console.WriteLine("3. Cambiar el estado de un pedido");
        Console.WriteLine("4. Reasignar un pedido a otro cadete");
        Console.WriteLine("5. Mostrar informe al final de la jornada");
        Console.WriteLine("6. Salir");
        Console.Write("Elija una opción: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                DarDeAltaPedido(miCadeteria, listaCadetes);
                break;
            case "2":
                AsignarPedidoACadete(miCadeteria, listaCadetes);
                break;
            case "3":
                CambiarEstadoPedido(miCadeteria);
                break;
            case "4":
                ReasignarPedido(miCadeteria);
                break;
            case "5":
                //MostrarInforme(listaCadetes);
                break;
            case "6":
                continuar = false;
                break;
            default:
                Console.WriteLine("Opción no válida, intente de nuevo.");
                break;
        }
    }


