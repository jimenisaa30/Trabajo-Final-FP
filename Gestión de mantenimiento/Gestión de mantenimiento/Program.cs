namespace Gestión_de_mantenimiento
{
    internal class Program
    {
        static string[,] servicios = new string[5, 4]; //Matriz de servicios
        static int contador = 0;
        static void Main(string[] args)
        {
            GestionMantenimiento();

        }

        static void GestionMantenimiento() //Módulo menú para gestión de mantenimiento
        {
            Console.WriteLine("Selecciona la opcion que requieras para gestionar los matenimientos de un vehículo");
            Console.WriteLine("1. Registrar servicio");
            Console.WriteLine("2. Historial de servicios");
            Console.WriteLine("3. Resumen general de servicios");
            Console.WriteLine("4. Volver al menú principal");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    RegistarServicio();
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
                    //Volver al menú principal
                    Console.WriteLine("Esta función de encuentra en otro programa... será agregaada próximamente");
                    break;

                default:
                    break;

            }
        }

        static void RegistarServicio()
        {
            

            bool salir = false;

            while (salir = false)
            {
                Console.WriteLine("Selecciona la opcion que requieras para registrar el vehículo");
                Console.WriteLine("1. Seleccionar vehículo");
                Console.WriteLine("2. Ingresar tipo de servicio");
                Console.WriteLine("3. Ingresar fecha y costo");
                Console.WriteLine("4. Salir");


                int opcion = int.Parse(Console.ReadLine());

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

                if (salir = false)
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

            Console.WriteLine("\n=== RESUMEN GENERAL DE REGISTRO DE SERVICIOS ===");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Vehículo: {servicios[i, 0]} | Servicio: {servicios[i, 1]} | Fecha: {servicios[i, 2]} | Costo: ${servicios[i, 3]}");
            }
           
        }
    }
}
