using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcobiciApp.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeHola()
        {
            Console.WriteLine("Bienvenido a Ecobici");
        }

        public int opcionesMenu()
        {
            int numero; 

            Console.WriteLine("Estás en la pagina principal de Ecobici. Seleccione la opcion para comenzar");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Ver tarifas");
            Console.WriteLine("2. Liberar una bici");
           
            numero = Console.ReadKey(true).KeyChar-('0');
            
            return numero;
        }
    }
}
