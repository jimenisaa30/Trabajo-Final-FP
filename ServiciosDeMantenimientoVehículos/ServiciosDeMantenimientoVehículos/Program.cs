using Microsoft.VisualBasic;
using System;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;
namespace Serviciosdemantenimientovehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Registrar un nuevo vehículo(marca, modelo, placa, año)-matriz del vehículo
            //2.Ver lista de vehículos registrados-mostrar matriz
            //3.Editar información de un vehículo(buscar por número de placa)- Modificar la matriz
            //4.Asignar vehículo a un cliente- conectar matriz con cliente
            //5.Ver vehículos de un cliente específico
            //6.Salir de Gestión de vehículos(volver al Menú principal)-salir de la función

            //1
            string[,] ListaVehiculos = new string[20,4];//matriz de 20 vehiculos(filas) y 4 columnas(ma,mo,p,a)
            string[,] ListaVehiculoCliente = new string[15,4]; //matriz de vehículo por cliente se conecta la matriz de clientes a la de los vehículos
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
                    AñoVehiculoIngresado= Console.ReadLine();
                    Console.WriteLine("¿Desea seguir ingresando vehículos?");
                    Console.WriteLine("Ingrese 1 en el caso de que sí");
                    ContinuarIngresando = Int32.Parse(Console.ReadLine());
                    if (ContinuarIngresando == 1 && i == ListaVehiculos.GetLength(0)-1)
                    {
                        Console.WriteLine("No se pueden ingresar más vehículos");
                    }
                    else if (ContinuarIngresando == 1)
                    {

                    }
                    else
                    {
                        break;
                    }

                }
                while (ContinuarIngresando == 1);
            }
            //3- Modificar la información de los vehículos
        }
    }
}