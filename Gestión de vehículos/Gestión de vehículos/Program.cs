using System;

namespace Gestión_de_vehículos
{
    internal class Program
    {
        static string[,] InfoRegistrarVehiculo = new string[20, 4];
        static string[,] ListaVehiculoCliente = new string[15, 4];
        static void Main(string[] args)
        {
            GestionVehiculos();
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

                        break;

                    case 5:
                        Console.Clear();

                        break;

                    case 6:
                        Console.Clear();
                        //Volver al menú principal
                        Console.WriteLine("Esta función de encuentra en otro programa... será agregada próximamente");
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
                            Console.WriteLine("Opción inválida.");
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
        }

        static void AsignarVehiculo()
        {

        }

        static void VerVehiculosClientes()
        {

        }
        
    }
}
