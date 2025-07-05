using CLASE;
using creacion_clases_y_.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creacion_clases_y_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menú de Opciones");
                Console.WriteLine("1.- Creacion de de Vehículo 1");
                Console.WriteLine("2.- Creacion de Firma electrónica 2");
                Console.WriteLine("3.- Creacionde objeto 3");
                Console.WriteLine("4.- Salir");

                Console.WriteLine();
                Console.Write("Ingrese una opción; ");
                string opcionn = Console.ReadLine();

                switch (opcionn)
                {
                    case "1":
                        crearobejtoVehiculo();
                        break;

                    case "2":
                        crearobejtoFirma();
                        break;

                    case "3":
                        break;

                    case "4":
                        Console.WriteLine("Gracias por usar el sistema");
                        return;
                        break;

                }




            }
        }

        private static void crearobejtoVehiculo()
        {
            Console.Clear();

            Console.WriteLine("CREACION DE VEHÍCULO");

            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine();
            Console.Write("Ingrese el modelo del vehículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ingrese el cilindraje del vehículo: ");
            int cilindraje = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el propietario del vehículo: ");
            string propietario = Console.ReadLine();
            Console.Write("Ingrese la marca del vehículo: ");
            string marca = Console.ReadLine();

            //INSTACIA
            Vehiculo objVehiculo = new Vehiculo(placa, modelo, cilindraje, propietario, marca);
            Console.WriteLine($"Felicidades!, acaba de ingresar  ingresar el vehículo {objVehiculo.placa}");
            objVehiculo.encender();
            Console.ReadLine();


        }

        private static void crearobejtoFirma()
        {
            Console.Clear();

            Console.WriteLine("CREACION DE FIRMA");

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su correo: ");
            string correo = Console.ReadLine();
            Console.Write("Ingrese tipo de firma natural o con ruc: ");
            string tipofirma = Console.ReadLine();
            Console.Write("Ingrese vigencia de la firma: ");
            string vigencia = Console.ReadLine();
            Console.Write("Ingrese número de cédula o ruc: ");
            int identificacion = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("Igrese tipo de pago: ");
            string tipopago = Console.ReadLine();
            Console.Write("Ingrese contraseña: ");
            string clave = Console.ReadLine();
            Console.Write("Eliga donde se guardará la firma: ");
            string almacenamientodescarga = Console.ReadLine();

            //INSTACIA
            FIRMA_ELECTRONICA objfirma = new FIRMA_ELECTRONICA(nombre, correo, tipofirma, vigencia, identificacion, tipopago, clave, almacenamientodescarga);
            Console.WriteLine($"Felicidades!, acaba de crear una firma electrónica {objfirma.nombre}");
            objfirma.firmacreada();
            Console.ReadLine();
        }
    }
}