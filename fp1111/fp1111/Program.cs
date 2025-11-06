namespace Menú_Principal__Código_final_
{
    internal class Program
    {
        static string[,] InfoRegistrarVehiculo = new string[20, 4];//Matriz de Vehiculos
        static string[,] InfoGestionClientes = new string[15, 3];
        static string[,] ListaVehiculoCliente = new string[15, 4];

        static string[,] servicios = new string[5, 4]; //Matriz de servicios
        static int contador = 0;
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            bool salir = false;

            while (salir == false)
            {
                Console.WriteLine("Selecciona la opción que requieras");
                Console.WriteLine("1. Gestión de vehiculos");
                Console.WriteLine("2. Gestion de clientes");
                Console.WriteLine("3. Gestion de servicios de mantenimiento");
                Console.WriteLine("4. Salir del programa");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        GestionVehiculos();
                        break;
                    case 2:
                        Console.Clear();
                        GestionClientes();
                        break;
                    case 3:
                        Console.Clear();
                        GestionMantenimiento();
                        break;
                    case 4:
                        salir = true;
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        static void GestionVehiculos()//Módulo menú para gestión de vehículos
        {
            bool salir = false;

            while (salir == false)
            {
                Console.WriteLine("Seleccione la opcion que requiera para gestionar los vehículos");
                Console.WriteLine("1. Registrar un vehículo");
                Console.WriteLine("2. Ver lista de vehiculos registrados");
                Console.WriteLine("3. Editar información de vehiculos");
                Console.WriteLine("4. Asignar vehículo a un cliente");
                Console.WriteLine("5. Ver vehículos de un cliente");
                Console.WriteLine("6. Volver al menú principal");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        RegistrarVehiculo();
                        break;

                    case 2:
                        Console.Clear();
                        VerVehiculoRegistrado(InfoRegistrarVehiculo);
                        break;

                    case 3:
                        Console.Clear();
                        EditarInfoVehiculos(InfoRegistrarVehiculo);
                        break;

                    case 4:
                        Console.Clear();
                        //COMPLETAR
                        break;

                    case 5:
                        Console.Clear();
                        //COMPLETAR
                        break;

                    case 6:
                        Console.Clear();
                        MenuPrincipal();
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo");
                        break;
                }
            }
        }
        static void RegistrarVehiculo()
        {
            string continuar = "s";
            int i = 0;

            while (continuar == "s" && i < InfoRegistrarVehiculo.GetLength(0))
            {
                Console.WriteLine($"Ingrese la placa del vehículo {i + 1}: ");
                InfoRegistrarVehiculo[i, 0] = Console.ReadLine();

                Console.WriteLine("Ingrese la marca del vehículo: ");
                InfoRegistrarVehiculo[i, 1] = Console.ReadLine();

                Console.WriteLine("Ingrese el modelo del vehículo: ");
                InfoRegistrarVehiculo[i, 2] = Console.ReadLine();

                Console.WriteLine("Ingrese el año del vehículo: ");
                InfoRegistrarVehiculo[i, 3] = Console.ReadLine();

                Console.WriteLine("¿Desea registrar otro vehiculo? s: Sí - n: No");
                continuar = Console.ReadLine().ToLower();
                i++;
            }

            GestionVehiculos();

        }

        static void VerVehiculoRegistrado(string[,] vehiculos)
        {
            Console.WriteLine("=== Lista de Vehículos ===");
            for (int i = 0; i < vehiculos.GetLength(0); i++)
            {
                if (vehiculos[i, 0] != null)
                {
                    Console.WriteLine($"Placa: {vehiculos[i, 0]}, Marca {vehiculos[i, 1]}, Modelo {vehiculos[i, 2]}, Año {vehiculos[i, 3]} ");
                }
            }

            GestionVehiculos();
        }


        static void EditarInfoVehiculos(string[,] vehiculos)
        {
            Console.WriteLine("Ingrese la placa del vehículo que desea modificar:");
            string placa = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < vehiculos.GetLength(0); i++)
            {
                if (vehiculos[i, 1] == placa)
                {
                    encontrado = true;
                    Console.WriteLine("Cliente encontrado:");
                    Console.WriteLine($"Marca: {vehiculos[i, 0]}, Modelo: {vehiculos[i, 1]}, Placa: {vehiculos[i, 2]}, Año {vehiculos[i, 3]}");
                    Console.WriteLine("¿Qué desea modificar? m: Marca - o: Modelo - p: Placa - a: Año");
                    char opcion = Console.ReadLine().ToLower().First();

                    switch (opcion)
                    {
                        case 'm':
                            Console.Write("Nueva marca: ");
                            vehiculos[i, 0] = Console.ReadLine();
                            break;
                        case 'o':
                            Console.Write("Nuevo modelo : ");
                            vehiculos[i, 1] = Console.ReadLine();
                            break;
                        case 'p':
                            Console.Write("Nueva placa: ");
                            vehiculos[i, 2] = Console.ReadLine();
                            break;
                        case 'a':
                            Console.Write("Nuevo año: ");
                            vehiculos[i, 3] = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Opción no válida, intente de nuevo");
                            break;
                    }
                    Console.WriteLine("Vehiculo  modificado con éxito.");
                    break;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("No se encontró un vehiculo con esa placa");
            }

            GestionVehiculos();
        }

        static void AsignarVehiculo()
        {

        }

        static void VerVehiculosClientes()
        {

        }

        //Hasta acá es gestión de vehículos--------------------------------------------------------------------------------------------

        static void GestionClientes()
        {
            bool salir = false;

            while (salir == false)
            {
                Console.WriteLine("Selecciona la opción que requieras para gestionar la información de los clientes");
                Console.WriteLine("1. Ingresar clientes");
                Console.WriteLine("2. Mostrar lista clientes");
                Console.WriteLine("3. Modificar informacion de los clientes");
                Console.WriteLine("4. Volver al menú principal");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        IngresarClientes();
                        break;
                    case 2:
                        Console.Clear();
                        MostrarListaClientes1(InfoGestionClientes);
                        break;
                    case 3:
                        Console.Clear();
                        ModificarCliente(InfoGestionClientes);
                        break;
                    case 4:
                        Console.Clear();
                        MenuPrincipal();
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        static string[,] IngresarClientes()
        {

            //15 filas, ya que representan cada cliente
            string NombreCliente; //Todas las variables son tipo string, para que puedan ser colocadas en una matriz, y los tipos de variables no choquen
            string CedulaCliente;
            string TelefonoCliente;
            int Continuar = 0; //En el caso de que se quiera seguir agregando clientes
            for (int i = 0; i < InfoGestionClientes.GetLength(0); i++)
            {
                //Verificar si la matriz esta llena, si lo esta preguntar mostrar o editar

                //Llenando la matriz con cada uno de los datos
                Console.WriteLine($"Ingrese el nombre del usuario {i + 1}");
                NombreCliente = Console.ReadLine();
                InfoGestionClientes[i, 0] = NombreCliente; //Se llena el nombre en la matriz, ingresada por el usuario
                Console.WriteLine($"Ingrese su número de cédula para el usuario {i + 1}");
                CedulaCliente = (Console.ReadLine());
                InfoGestionClientes[i, 1] = CedulaCliente; //Se llena la cedula, ingresada por el usuario
                Console.WriteLine($"Ingrese su número telefónico para el usuario {i + 1}");
                TelefonoCliente = Console.ReadLine();
                InfoGestionClientes[i, 2] = TelefonoCliente; //Se llena el telefono, ingresado por el usuario
                Console.WriteLine("¿Desea ingresar otro cliente? En tal caso ingrese 1");
                Console.WriteLine("En el caso de que no, ingrese 2");
                Continuar = Int32.Parse(Console.ReadLine());
                Console.Clear();
                if (Continuar == 1 && i == InfoGestionClientes.GetLength(0) - 1) //En elcaso de que el cliente quiera continuar ingresando clientes, pero la matriz ya ha llegado a su máximo
                {
                    //Le avisará al cliente que ya ha llegado a su máximo de clientes
                    Console.WriteLine("Llegó al número máximo de clientes");
                    GestionClientes();

                    if (Continuar == 3)//VERIFICAR INFO (FUNCIONALIDAD)
                    {
                        MostrarListaClientes1(InfoGestionClientes);
                    }
                    return InfoGestionClientes;
                }
                else if (Continuar == 1)
                {
                    //Si ingresa el numero 1, se cumple la condición y el for continua su proceso para llenar la matriz
                }
                else
                {
                    //En el caso de que ingrese el numero 2, el ciclo for se rompe, y la matriz se llena
                    //Poniendo de todas formas el for para que haya un máximo de clientes
                    return InfoGestionClientes;
                }
            }
            return InfoGestionClientes;
        }
        static string[,] ModificarCliente(string[,] clientes)
        {
            int modificarInformacion = 0; //La variable para saber si deseo modificar información
            int mostrarListaClientes = 0;
            Console.WriteLine("¿Desea modificar información? En el caso de que sí ingrese 3");
            Console.WriteLine("En caso de que no, ingrese 1");
            modificarInformacion = Int32.Parse(Console.ReadLine());
            string continuarModificacion = ""; //Variable para saber si se desea continuar con la modificación, es la que se usa para el while !="X"
            if (modificarInformacion == 3) // Si la condición se cumple, se empieza el proceso de modificar información
            {
                do
                {
                    string CedulaPorBuscar; //Variable para saber buscar en la matriz la posición que se busca modificar
                    int PosicionPorModificar = 0; //Variable para igualar 
                    char ColumnaParaCambiar; //Variable para saber la columna se desea modificar ya sabiendo la posición
                    string NuevosDatos; //Variable para ingresar los nuevos datos
                    Console.WriteLine("Ingrese la cédula del usuario que desea modificar");
                    CedulaPorBuscar = Console.ReadLine();

                    //Este ciclo lo que hace es que continua hasta que la persona ingrese x, es decir quiera salir del programa
                    //ó en el caso de que ingrese la cédula correcta, igualamos la x para que se rompa el ciclo de igual manera, y pase a la parte del switch

                    for (int i = 0; i < clientes.GetLength(0); i++)
                    {
                        if (CedulaPorBuscar == clientes[i, 1])
                        {
                            continuarModificacion = "x";
                            Console.WriteLine("Ingrese c para cédula, n para nombre y t para telefono");
                            ColumnaParaCambiar = (Console.ReadLine().First());
                            PosicionPorModificar = i; //Posicion a guardar
                            while (ColumnaParaCambiar != 'c' || ColumnaParaCambiar != 'n' || ColumnaParaCambiar != 't')
                            {
                                switch (ColumnaParaCambiar)
                                {
                                    case 'n': //Caso de que quiera modificar el nombre
                                        Console.Clear();
                                        Console.WriteLine("Ingrese el nuevo nombre");
                                        NuevosDatos = Console.ReadLine();
                                        clientes[PosicionPorModificar, 0] = NuevosDatos;
                                        GestionClientes();
                                        break;
                                    case 'c': //Caso de que quiera modificar la cédula
                                        Console.Clear();
                                        Console.WriteLine("Ingrese la nueva cédula");
                                        NuevosDatos = Console.ReadLine();
                                        clientes[PosicionPorModificar, 1] = NuevosDatos;
                                        GestionClientes();
                                        break;
                                    case 't': //Caso de que quiera modificar el teléfono
                                        Console.Clear();
                                        Console.WriteLine("Ingrese el nuevo telefono");
                                        NuevosDatos = Console.ReadLine();
                                        clientes[PosicionPorModificar, 2] = NuevosDatos;
                                        GestionClientes();
                                        break;
                                    default:
                                        Console.WriteLine("Se ingresó una letra no válida, vuelva a ingresar otra letra");
                                        ColumnaParaCambiar = Convert.ToChar(Console.ReadLine());
                                        Console.Clear();
                                        break;
                                }
                            }
                            break;
                        }
                        else //En el caso de que se haya buscado el nombre en la matriz y no se encuentre en el sistema
                        {
                            Console.WriteLine("La cédula que ingresó no se encuentra en el sistema");
                            Console.WriteLine("Ingrese a para ingresar la cédula nuevamente o presione x para salir");
                            continuarModificacion = Console.ReadLine();
                            if (continuarModificacion == "a")
                                Console.Clear();
                            break;
                            //Si la persona ingresa la x
                            //se saldrá del else
                            //el ciclo se repetirá
                            //y le dirá a la persona que ingrese otra vez la cédula y la volverá a buscar
                        }
                    }
                }
                while (continuarModificacion != "x");
            }
            else
            {
                MenuPrincipal();
            }
            return clientes;
        }
        static string[,] MostrarListaClientes1(string[,] clientes)
        {
            int MostrarListaClientes = 0;
            Console.WriteLine("¿Desea mostrar la lista de clientes?");
            Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
            Console.WriteLine("Ingrese 4 si desea volver al menú principal");
            MostrarListaClientes = Int32.Parse(Console.ReadLine());
            if (MostrarListaClientes == 2)
            {
                for (int i = 0; i < clientes.GetLength(0); i++)
                {
                    for (int j = 0; j < clientes.GetLength(1); j++)
                    {
                        Console.Write(clientes[i, j] + "|");
                    }
                }
            }
            else if (MostrarListaClientes == 4)
            {
                //Llamar la función del menú principal
                MenuPrincipal();
            }
            return clientes;
        }

        static void GestionMantenimiento() //Módulo menú para gestión de mantenimiento
        {
            bool salir = false;

            while (salir == false)
            {
                Console.WriteLine("Selecciona la opción que requieras para gestionar los mantenimientos de un vehículo");
                Console.WriteLine("1. Registrar servicio");
                Console.WriteLine("2. Historial de servicios");
                Console.WriteLine("3. Resumen general de servicios");
                Console.WriteLine("4. Volver al menú principal");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        RegistrarServicio(InfoRegistrarVehiculo);
                        break;
                    case 2:
                        Console.Clear();
                        HistorialServicios();
                        break;
                    case 3:
                        Console.Clear();
                        ResumenServiciosGeneral();
                        break;
                    case 4:
                        Console.Clear();
                        MenuPrincipal();
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo");
                        break;
                }
            }
        }

        static void RegistrarServicio(string[,] vehiculos)
        {

            bool salir = false;

            while (salir == false)
            {
                Console.WriteLine("Selecciona la opcion que requieras para registrar el vehículo");
                Console.WriteLine("1. Seleccionar vehículo");
                Console.WriteLine("2. Ingresar tipo de servicio");
                Console.WriteLine("3. Ingresar fecha y costo");
                Console.WriteLine("4. Volver al menú de mantenimiento");


                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (contador < servicios.GetLength(0))
                        {
                            Console.Write("Ingrese la placa del vehículo para seleccionarlo");
                            string placa = Console.ReadLine().ToUpper();

                            bool encontrado = false;

                            for (int i = 0; i < InfoRegistrarVehiculo.GetLength(0); i++)
                            {
                                if (InfoRegistrarVehiculo[i, 0].ToUpper() == placa)
                                {
                                    servicios[contador, 0] = placa;
                                    Console.WriteLine($"Vehículo con placa {placa} encontrado y seleccionado.");
                                    encontrado = true;
                                    break;
                                }
                            }

                            if (encontrado == false)
                            {
                                Console.WriteLine("No existe un vehículo con esa placa. Regístrelo primero en el sistema.");
                                RegistrarVehiculo();
                            }
                        }
                        break;

                    case 2:
                        if (contador < 5)
                        {
                            if (servicios[contador, 0] == null)
                            {
                                Console.WriteLine("Primero debe ingresar un vehículo.");
                            }
                            else
                            {
                                Console.Write("Ingrese el tipo de servicio (ej. cambio de aceite, alineación): ");
                                servicios[contador, 1] = Console.ReadLine();
                                Console.WriteLine("Servicio registrado.");
                            }
                        }
                        break;

                    case 3:
                        if (contador < 5)
                        {
                            if (servicios[contador, 0] == null || servicios[contador, 1] == null)
                            {
                                Console.WriteLine("Debe ingresar primero el vehículo y el servicio.");
                            }
                            else
                            {
                                Console.Write("Ingrese la fecha (dd/mm/aaaa): ");
                                servicios[contador, 2] = Console.ReadLine();

                                Console.Write("Ingrese el costo: ");
                                servicios[contador, 3] = Console.ReadLine();

                                Console.WriteLine("Registro completo guardado exitosamente.");
                                contador++;
                            }
                        }
                        break;

                    case 4:
                        Console.Clear();
                        GestionMantenimiento();
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }

                if (salir == false)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            }


        }
        static void HistorialServicios()
        {
            Console.Write("Ingrese la placa del vehículo para ver su historial: ");
            string placaBuscada = Console.ReadLine().ToUpper();

            bool encontrado = false;

            Console.WriteLine($"Historial de servicios del vehículo {placaBuscada}");

            for (int i = 0; i < servicios.GetLength(0); i++)
            {
                if (servicios[i, 0].ToUpper() == placaBuscada)
                {
                    encontrado = true;
                    Console.WriteLine($"Servicio: {servicios[i, 1]}");
                    Console.WriteLine($"Fecha: {servicios[i, 2]}");
                    Console.WriteLine($"Costo: {servicios[i, 3]}");
                }
            }

            GestionMantenimiento();
        }

        static void ResumenServiciosGeneral()
        {
            Console.WriteLine("Resumen general de servicios");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Vehículo: {servicios[i, 0]} | Servicio: {servicios[i, 1]} | Fecha: {servicios[i, 2]} | Costo: ${servicios[i, 3]}");
            }

            GestionMantenimiento();
        }
    }
}