using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using clase03._1.Clases;

namespace clase03._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario ObjUsuario = new Usuario("0953469608", "Danny", "Oleas", "dop@Gmail.com", "1232456789");
            Console.WriteLine("Cedula: " + ObjUsuario.cedula);
            Console.WriteLine("Nombre: " + ObjUsuario.nombre);
            Console.WriteLine("Apellido: " + ObjUsuario.apellido);
            Console.WriteLine("Tarjeta: " + ObjUsuario.getTarjetaCredito2());
            //ObjUsuario.setTarjetaCredito("1234567890");
            Console.WriteLine("Tarjeta: " + ObjUsuario.getTarjetaCredito2());
            Console.ReadLine();


            instanciarObjeto();

        }

        private static void instanciarObjeto()
        {
            Console.Clear();
            Console.WriteLine("INGRESE UN NUEVO USUARIO");
            Console.WriteLine();
            Console.Write("Ingrese la cédula: ");
            string cedula = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el mail: ");
            string mail = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese su tarjeta de crédito: ");
            string tarjetaCredito = Console.ReadLine();
            Console.WriteLine();

            Usuario objetoUsuario = new Usuario(cedula, nombre, apellido, mail, tarjetaCredito);
            Console.WriteLine("La tarjeta de crédito es: " + objetoUsuario.getTarjetaCredito2());

            Console.WriteLine("Ingrese la Nueva Tarjeta de Crédito: ");
            tarjetaCredito = Console.ReadLine();

            objetoUsuario.setTarjetaCredito(tarjetaCredito);
            Console.WriteLine("La nueva tarjeta de crédito es: " + objetoUsuario.getTarjetaCredito2());

        }
    }
}

