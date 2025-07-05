using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE
{
    public class FIRMA_ELECTRONICA//NOMBRE DE LA CLASE
    {
        //ATRIBUTOS DE LA CLASE

        //SIEMPRE VA EL NIVEL DE ACCESO - TIPO DE DATO - NOMBRE DEL ATRIBUTO
        public string nombre;
        public string correo;
        public string tipofirma;
        public string vigencia;
        public int identificación;
        public string tipopago;
        public string clave;
        public string almacenmientodescarga;
       

        public FIRMA_ELECTRONICA(string nombre, string correo, string tipofirma, string vigencia, int identificación, string tipopago, string clave, string almacenamientodescarga)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.tipofirma = tipofirma;
            this.vigencia = vigencia;
            this.identificación = identificación;
            this.tipopago = tipopago;
            this.clave = clave;
            this.almacenmientodescarga = almacenamientodescarga;
           
        }

        //COMPORTAMIENTOS DE LA CLASE

        //SIEMPRE VA EL NIVEL DE ACCESO - TIPO DE DATO - NOMBRE DEL COMPORTAMIENTO
        public Boolean firmacreada()
        {
            Console.WriteLine("Se creó firma");
            return true;

        }




    }
}

   

