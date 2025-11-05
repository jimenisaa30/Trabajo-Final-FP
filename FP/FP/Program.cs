namespace Menú_Principal__Código_final_
{
    internal class Program
    {
        static string[,] InfoRegistrarVehiculo = new string[20, 4];//Matriz de Vehiculos
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

            while (salir==false)
            {
                Console.WriteLine("Selecciona la opción que requieras para gestionar los mantenimientos de un vehículo");
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
                        GestionMantenimiento();
                        break;
                    case 3:
                        Console.Clear();
                        
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

        static void GestionClientes(string[,] infoGestionClientes)
        {
            int MostrarListaClientes = 0;
            for (int i = 0; i < infoGestionClientes.GetLength(0); i++)
            {
                for (int j = 0; j < infoGestionClientes.GetLength(1); j++)
                {
                    Console.WriteLine(infoGestionClientes[i, j]);
                }
            }
            do
            {
                Console.WriteLine("Ingrese 2 si desea editar la lista");
                Console.WriteLine("Ingrese 4 si desea volver al menú principal");
                MostrarListaClientes = Int32.Parse(Console.ReadLine());
                switch (MostrarListaClientes)
                {
                    case 2:
                        ModificarCliente(infoGestionClientes);
                        break;
                    case 4:
                        Console.Clear();
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida");
                        break;
                }
            } while (true);
        }
        static void MostrarListaClientes1(string[,] infoGestionClientes)//AÑADIR OPCIÓN PARA MODOFICAR LISTA
        {
            string ModificarCliente;
            int MostrarListaClientes = 0;
            for (int i = 0; i < infoGestionClientes.GetLength(0); i++)
            {
                for (int j = 0; j < infoGestionClientes.GetLength(1); j++)
                {
                    Console.WriteLine(infoGestionClientes[i, j]);
                }
            }
            do
            {
                Console.WriteLine("Ingrese 2 si desea editar la lista");
                Console.WriteLine("Ingrese 4 si desea volver al menú principal");
                MostrarListaClientes = Int32.Parse(Console.ReadLine());
                switch (MostrarListaClientes)
                {
                    case 2:
                        ModificarCliente(infoGestionClientes);
                        break;
                    case 4:
                        Console.Clear();
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida");
                        break;
                }
            } while (true);
        }
        static void ServiciosMantenimiento()
        {

            string[,] servicios = new string[5, 4]; //Matriz de servicios
            int contador = 0;
            bool salir = false;

            while (salir = false)
            {
                Console.WriteLine("Selecciona la opción que requieras para registrar el vehículo");
                Console.WriteLine("1. Seleccionar vehículo");
                Console.WriteLine("2. Ingresar tipo de servicio");
                Console.WriteLine("3. Ingresar fecha y costo");
                Console.WriteLine("4. Salir");


                int opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Esta función de encuentra en otro programa... será agregada próximamente"); //Completar esta parte del código llamando la función desde gestión de vehículos
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
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
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
        static void ServiciosMantenimiento()
        {

            string[,] servicios = new string[5, 4]; //Matriz de servicios
            int contador = 0;
            bool salir = false;

            while (salir = false)
            {
                Console.WriteLine("Selecciona la opción que requieras para registrar el vehículo");
                Console.WriteLine("1. Seleccionar vehículo");
                Console.WriteLine("2. Ingresar tipo de servicio");
                Console.WriteLine("3. Ingresar fecha y costo");
                Console.WriteLine("4. Salir");


                int opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Esta función de encuentra en otro programa... será agregada próximamente"); //Completar esta parte del código llamando la función desde gestión de vehículos
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
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
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
                        Console. Clear();
                        MenuPrincipal();
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo");
                        break;
                }
            }
        }

        static void RegistrarServicio(string [,]vehiculos)
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
