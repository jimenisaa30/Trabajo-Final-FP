using System;
namespace TrabajoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionesDelMenu;
            Console.WriteLine("Ingrese la opción que quiera hacer");
            Console.WriteLine("1 para ingresar vehículo");
            Console.WriteLine("2 para ingresar el información del cliente");
            Console.WriteLine("3 para modificar información del cliente");
            Console.WriteLine("4 para ver la lista de clientes");
            Console.WriteLine("5 para ingresar el servicio que se le desea hacer al vehículo");
            Console.WriteLine("6 Si desea ver los servicios que tiene ingresados su vehículo");
            Console.WriteLine("7 Si desea ver el resumen de los servicios de mantenimiento");
            Console.WriteLine("8 si desea ver la lista de vehículos");
            Console.WriteLine("9 Si desea modificar la información del vehículo");
            opcionesDelMenu = Int32.Parse(Console.ReadLine());
            switch (opcionesDelMenu)
                {
                    case 1:
                    //Llama la función Gestión Vehículos
                    break;
                    case 2:
                    //Llama la función IngresarClientes
                    break;
                    case 3:
                    //Llama la función ModificarCliente
                    break;
                    case 4:
                    //Llama la función de MostrarListaClientes
                    break;
                    case 5:
                    //Llama la función de ServiciosMantenimiento
                    break;
                    default:
                    break;

                }
        }
        static void GestionVehiculos()
        {
            //1.Registrar un nuevo vehículo(marca, modelo, placa, año)-matriz del vehículo
            //2.Ver lista de vehículos registrados-mostrar matriz
            //3.Editar información de un vehículo(buscar por número de placa)- Modificar la matriz
            //4.Asignar vehículo a un cliente- conectar matriz con cliente
            //5.Ver vehículos de un cliente específico
            //6.Salir de Gestión de vehículos(volver al Menú principal)-salir de la función

            //1
            string[,] ListaVehiculos = new string[20, 4];//matriz de 20 vehiculos(filas) y 4 columnas(ma,mo,p,a)
            string[,] ListaVehiculoCliente = new string[15, 4]; //matriz de vehículo por cliente se conecta la matriz de clientes a la de los vehículos
            string MarcaIngresada; //Marca de vehículo ingresada por el usuario
            string ModeloIngresado; //Modelo de vehículo ingresado por el usuario
            string PlacaIngresada; //Placa de vehículo ingresado por el usuario
            string AñoVehiculoIngresado; //Año del vehículo ingresado por el usuario
            int ContinuarIngresando = 0; //Variable para seguir ingresando vehículos
            for (int i = 0; i < ListaVehiculos.Length; i++) //Definir el máximo de vehículos que se pueden ingresar
            {
                do
                {
                    Console.WriteLine("Ingrese la placa del vehículo");
                    PlacaIngresada = Console.ReadLine();
                    Console.WriteLine("Ingrese la marca del vehículo");
                    MarcaIngresada = Console.ReadLine();
                    Console.WriteLine("Ingrese el modelo del vehículo");
                    ModeloIngresado = Console.ReadLine();
                    Console.WriteLine("Ingrese el año del vehículo");
                    AñoVehiculoIngresado = Console.ReadLine();
                    Console.WriteLine("¿Desea seguir ingresando vehículos?");
                    Console.WriteLine("Ingrese 1 en el caso de que sí");
                    ContinuarIngresando = Int32.Parse(Console.ReadLine());
                    if (ContinuarIngresando == 1 && i == ListaVehiculos.GetLength(0) - 1)
                    {
                        Console.WriteLine("No se pueden ingresar más vehículos");
                        Console.Clear();
                    }
                    else if (ContinuarIngresando == 1)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        break;
                        Console.Clear();
                    }

                }
                while (ContinuarIngresando == 1);
            }
            //3- Modificar la información de los vehículos
        }
        static string[,] IngresarClientes()
        {
            string[,] infoGestionClientes = new string[15, 3]; //tres columnas - una representando los telefonos, los nombres y los clientes
            //15 filas, ya que representan cada cliente
            string NombreCliente; //Todas las variables son tipo string, para que puedan ser colocadas en una matriz, y los tipos de variables no choquen
            string CedulaCliente;
            string TelefonoCliente;
            int Continuar = 0; //En el caso de que se quiera seguir agregando clientes
            for (int i = 0; i < infoGestionClientes.GetLength(0); i++)
            {
                //Verificar si la matriz esta llena, si lo esta preguntar mostrar o editar

                //Llenando la matriz con cada uno de los datos
                Console.WriteLine($"Ingrese el nombre del usuario {i + 1}");
                NombreCliente = Console.ReadLine();
                infoGestionClientes[i, 0] = NombreCliente; //Se llena el nombre en la matriz, ingresada por el usuario


                Console.WriteLine($"Ingrese su número de cédula para el usuario {i + 1}");
                CedulaCliente = (Console.ReadLine());
                infoGestionClientes[i, 1] = CedulaCliente; //Se llena la cedula, ingresada por el usuario
                Console.WriteLine($"Ingrese su número telefónico para el usuario {i + 1}");
                TelefonoCliente = Console.ReadLine();
                infoGestionClientes[i, 2] = TelefonoCliente; //Se llena el telefono, ingresado por el usuario
                Console.WriteLine("¿Desea ingresar otro cliente? En tal caso ingrese 1");
                Console.WriteLine("En el caso de que no, ingrese 2");
                Continuar = Int32.Parse(Console.ReadLine());
                if (Continuar == 1 && i == infoGestionClientes.GetLength(0)-1) //En ek caso de que el cliente quiera continuar ingresando clientes, pero la matriz ya ha llegado a su máximo
                {
                    //Le avisará al cliente que ya ha llegado a su máximo de clientes
                    Console.WriteLine("Llegó al número máximo de clientes");
                    Console.WriteLine("¿Desea visualizar la lista? Para verla presione 3");
                    Continuar = Int32.Parse(Console.ReadLine());

                    if (Continuar == 3)//VERIFICAR INFO (FUNCIONALIDAD)
                    {
                        MostrarListaClientes1(infoGestionClientes);
                    }
                    return infoGestionClientes;
                }
                else if (Continuar == 1)
                {
                    //Si ingresa el numero 1, se cumple la condición y el for continua su proceso para llenar la matriz
                }
                else
                {
                    //En el caso de que ingrese el numero 2, el ciclo for se rompe, y la matriz se llena
                    //Poniendo de todas formas el for para que haya un máximo de clientes
                    //
                    return infoGestionClientes;
                }
            }
            return infoGestionClientes;
        }
        static string[,] ModificarCliente(string[,] InfoGestionClientes)
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

                    for (int i = 0; i < InfoGestionClientes.GetLength(0); i++)
                    {
                        if (CedulaPorBuscar == InfoGestionClientes[i, 1])
                        {
                            continuarModificacion = "x";
                            Console.WriteLine("Ingrese c para cédula, n para nombre y t para telefono");
                            ColumnaParaCambiar = (Console.ReadLine().First());
                            PosicionPorModificar = i; //Posicion a guardar
                            while (ColumnaParaCambiar == 'c' || ColumnaParaCambiar == 'n' || ColumnaParaCambiar == 't')
                            {
                                switch (ColumnaParaCambiar)
                                {
                                    case 'n': //Caso de que quiera modificar el nombre
                                        Console.Clear();
                                        Console.WriteLine("Ingrese el nuevo nombre");
                                        NuevosDatos = Console.ReadLine();
                                        InfoGestionClientes[PosicionPorModificar, 0] = NuevosDatos;
                                        Console.WriteLine("¿Desea mostrar la lista de clientes?");
                                        Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
                                        Console.WriteLine("Ingrese 1 si desea volver al menú principal");
                                        mostrarListaClientes = Int32.Parse(Console.ReadLine());
                                        if (mostrarListaClientes == 2)
                                        {
                                            for (int j = 0; j < InfoGestionClientes.GetLength(0); j++)
                                            {
                                                for (int a = 0; a < InfoGestionClientes.GetLength(1); a++)
                                                {
                                                    Console.WriteLine(InfoGestionClientes[i, j]);
                                                }
                                            }
                                            return InfoGestionClientes;
                                        }
                                        else
                                        {
                                            return InfoGestionClientes;
                                        }
                                    case 'c': //Caso de que quiera modificar la cédula
                                        Console.Clear();
                                        Console.WriteLine("Ingrese la nueva cédula");
                                        NuevosDatos = Console.ReadLine();
                                        InfoGestionClientes[PosicionPorModificar, 1] = NuevosDatos;
                                        Console.WriteLine("¿Desea mostrar la lista de clientes?");
                                        Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
                                        Console.WriteLine("Ingrese 1 si desea volver al menú principal");
                                        mostrarListaClientes = Int32.Parse(Console.ReadLine());
                                        if (mostrarListaClientes == 2)
                                        {
                                            for (int j = 0; j < InfoGestionClientes.GetLength(0); j++)
                                            {
                                                for (int a = 0; a < InfoGestionClientes.GetLength(1); a++)
                                                {
                                                    Console.WriteLine(InfoGestionClientes[i, j]);
                                                }
                                            }
                                            return InfoGestionClientes;
                                        }
                                        else
                                        {
                                            return InfoGestionClientes;
                                        }
                                    case 't': //Caso de que quiera modificar el teléfono
                                        Console.Clear();
                                        Console.WriteLine("Ingrese el nuevo telefono");
                                        NuevosDatos = Console.ReadLine();
                                        InfoGestionClientes[PosicionPorModificar, 2] = NuevosDatos;
                                        Console.WriteLine("¿Desea mostrar la lista de clientes?");
                                        Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
                                        Console.WriteLine("Ingrese 1 si desea volver al menú principal");
                                        mostrarListaClientes = Int32.Parse(Console.ReadLine());
                                        if (mostrarListaClientes == 2)
                                        {
                                            for (int j = 0; j < InfoGestionClientes.GetLength(0); j++)
                                            {
                                                for (int a = 0; a < InfoGestionClientes.GetLength(1); a++)
                                                {
                                                    Console.WriteLine(InfoGestionClientes[i, j]);
                                                }
                                            }
                                            return InfoGestionClientes;
                                        }
                                        else
                                        {
                                            return InfoGestionClientes;
                                        }
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
                //Lamar la función de mostrar clientes
            }
            return InfoGestionClientes;
        }
        static string[,] MostrarListaClientes1(string[,] InfoGestionClientes)//AÑADIR OPCIÓN PARA MODOFICAR LISTA
        {
            int MostrarListaClientes = 0;
            Console.WriteLine("¿Desea mostrar la lista de clientes?");
            Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
            Console.WriteLine("Ingrese 4 si desea volver al menú principal");
            MostrarListaClientes = Int32.Parse(Console.ReadLine());
            if (MostrarListaClientes == 2)
            {
                for (int i = 0; i < InfoGestionClientes.GetLength(0); i++)
                {
                    for (int j = 0; j < InfoGestionClientes.GetLength(1); j++)
                    {
                        Console.WriteLine(InfoGestionClientes[i, j]);
                    }
                }
            }
            else if (MostrarListaClientes == 4)
            {
                //Llamar la función del menú principal
                return InfoGestionClientes;
            }
            else
            {
                return InfoGestionClientes;
            }
            return InfoGestionClientes;
        }
        static void ServiciosMantenimiento()
        {

            string[,] servicios = new string[5, 4]; //Matriz de servicios
            int contador = 0;
            bool salir = false;

            while (salir  = false)
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
        static void HistorialServicios()
        {
            //Llamar la matriz de registro de vehiculos para encontrar el vehículo
        }
        static void ResumenServiciosGeneral()
        {
            string[,] servicios = new string[5, 4]; //Matriz de servicios
            int contador = 0;
            bool salir = false;

            Console.WriteLine("\n=== RESUMEN GENERAL DE REGISTRO DE SERVICIOS ===");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Vehículo: {servicios[i, 0]} | Servicio: {servicios[i, 1]} | Fecha: {servicios[i, 2]} | Costo: ${servicios[i, 3]}");
            }

        }
    }
}
