using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creacion_clases_y_.Clases
{

    public class Vehiculo //NOMBRE DE LA CLASE
    {
        //ATRIBUTOS DE LA CLASE

        //SIEMPRE VA EL NIVEL DE ACCESO - TIPO DE DATO - NOMBRE DEL ATRIBUTO
        public string placa;
        public string modelo;
        public int cilindraje;
        public string propietario;
        public string marca;

        public Vehiculo(string placa, string modelo, int cilindraje, string propietario, string marca)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.cilindraje = cilindraje;
            this.propietario = propietario;
            this.marca = marca;
        }

        //COMPORTAMIENTOS DE LA CLASE

        //SIEMPRE VA EL NIVEL DE ACCESO - TIPO DE DATO - NOMBRE DEL COMPORTAMIENTO
        public Boolean encender()
        {
            Console.WriteLine("Se encendió el Vehículo");
            return true;

        }




    }
}