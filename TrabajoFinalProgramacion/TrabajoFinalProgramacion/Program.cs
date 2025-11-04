using System;
namespace TrabajoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IngresarClientes();
        }
        static void GestionVehiculo()
        {
          
        }
        static string[,] IngresarClientes()
        {
            string[,] InfoGestionClientes = new string[15, 3]; //tres columnas - una representando los telefonos, los nombres y los clientes
            //15 filas, ya que representan cada cliente
            string NombreCliente; //Todas las variables son tipo string, para que puedan ser colocadas en una matriz, y los tipos de variables no choquen
            string CedulaCliente;
            string TelefonoCliente;
            int Continuar = 0; //En el caso de que se quiera seguir agregando clientes
            for (int i = 0; i < InfoGestionClientes.GetLength(0); i++)
            {
                //Llenando la matriz con cada uno de los datos
                Console.WriteLine($"Ingrese el nombre del usuario {i + 1}");
                NombreCliente = Console.ReadLine();
                InfoGestionClientes[i, 0] = NombreCliente;


                Console.WriteLine($"Ingrese su número de cédula para el usuario {i + 1}");
                CedulaCliente = (Console.ReadLine());
                InfoGestionClientes[i, 1] = CedulaCliente;
                Console.WriteLine($"Ingrese su número telefónico para el usuario {i + 1}");
                TelefonoCliente = Console.ReadLine();
                InfoGestionClientes[i, 2] = TelefonoCliente;
                Console.WriteLine("¿Desea ingresar otro cliente? En tal caso ingrese 1");
                Console.WriteLine("En el caso de que no, ingrese 2");
                Continuar = Int32.Parse(Console.ReadLine());
                if (Continuar == 1 && i == InfoGestionClientes.GetLength(0)-1)
                {
                    Console.WriteLine("Llegó al número máximo de clientes");
                    return InfoGestionClientes;
                }
                else if (Continuar == 1)
                {
                    //Si ingresa el numero 1, se cumple la condición y el for continua su proceso
                }
                else
                {
                    //En el caso de que ingrese el numero 2, el ciclo for se rompe, y la matriz se llena, poniendo de todas formas el for para que haya un máximo de clientes
                    return InfoGestionClientes;
                }
            }
            return InfoGestionClientes;
        }
        static string[,] ModificarCliente(string[,] InfoGestionClientes)
        {
            int ModificarInformacion = 0; //La variable para saber si deseo modificar información
            int MostrarListaClientes = 0;
            Console.WriteLine("¿Desea modificar información? En el caso de que sí ingrese 3");
            Console.WriteLine("En caso de que no, ingrese 1");
            ModificarInformacion = Int32.Parse(Console.ReadLine());
            string ContinuarModificacion = ""; //Variable para saber si se desea continuar con la modificación, es la que se usa para el while !="X"
            if (ModificarInformacion == 3) // Si la condición se cumple, se empieza el proceso de modificar información
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
                            ContinuarModificacion = "x";
                            Console.WriteLine("Ingrese c para cédula, n para nombre y t para telefono");
                            ColumnaParaCambiar = (Console.ReadLine().First());
                            PosicionPorModificar = i; //Posicion a guardar
                            while (ColumnaParaCambiar == 'c' || ColumnaParaCambiar == 'n' || ColumnaParaCambiar == 't')
                            {
                                switch (ColumnaParaCambiar)
                                {
                                    case 'n':
                                        Console.WriteLine("Ingrese el nuevo nombre");
                                        NuevosDatos = Console.ReadLine();
                                        InfoGestionClientes[PosicionPorModificar, 0] = NuevosDatos;
                                        Console.WriteLine("¿Desea mostrar la lista de clientes?");
                                        Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
                                        Console.WriteLine("Ingrese 1 si desea volver al menú principal");
                                        MostrarListaClientes = Int32.Parse(Console.ReadLine());
                                        if (MostrarListaClientes == 2)
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
                                    case 'c':
                                        Console.WriteLine("Ingrese la nueva cédula");
                                        NuevosDatos = Console.ReadLine();
                                        InfoGestionClientes[PosicionPorModificar, 1] = NuevosDatos;
                                        Console.WriteLine("¿Desea mostrar la lista de clientes?");
                                        Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
                                        Console.WriteLine("Ingrese 1 si desea volver al menú principal");
                                        MostrarListaClientes = Int32.Parse(Console.ReadLine());
                                        if (MostrarListaClientes == 2)
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
                                    case 't':
                                        Console.WriteLine("Ingrese el nuevo telefono");
                                        NuevosDatos = Console.ReadLine();
                                        InfoGestionClientes[PosicionPorModificar, 2] = NuevosDatos;
                                        Console.WriteLine("¿Desea mostrar la lista de clientes?");
                                        Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
                                        Console.WriteLine("Ingrese 1 si desea volver al menú principal");
                                        MostrarListaClientes = Int32.Parse(Console.ReadLine());
                                        if (MostrarListaClientes == 2)
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
                                        break;
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("La cédula que ingresó no se encuentra en el sistema");
                            Console.WriteLine("Ingrese a para ingresar la cédula nuevamente o presione x para salir");
                            ContinuarModificacion = Console.ReadLine();
                            if (ContinuarModificacion == "a") ;
                            break;
                            //Si la persona ingresa la a
                            //se saldrá del else
                            //el ciclo se repetirá
                            //y le dirá a la persona que ingrese otra vez la cédula y la volverá a buscar
                        }
                    }
                }
                while (ContinuarModificacion != "x");
            }
            else
            {
                Console.WriteLine("¿Desea mostrar la lista de clientes?");
                Console.WriteLine("Ingrese 2 si desea mostrar la lista de clientes");
                Console.WriteLine("Ingrese 1 si desea volver al menú principal");
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
                else
                {
                    return InfoGestionClientes;
                }
            }
            return InfoGestionClientes;
        }
        static void GestionMantenimientoVehiculos() 
        {
            //Registrar vehículos
            //Ver lista de vehículos
            //Editar información del vehículo
            //Asignar vehículo a un cliente
            //Ver vehículo clientes
            //Crear una matriz donde una de las filas del cliente sea de las filas del vehículo, es decir la unión de ambos
        }
    }
}
