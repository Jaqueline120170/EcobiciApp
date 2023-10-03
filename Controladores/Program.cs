using EcobiciApp.Servicios;

namespace EcobiciApp.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 30092023 - jrt
    /// </summary>
    class Program
    {
        /// <summary>
        /// Nos indica el método de entrada de la aplicación
        /// 30092023 -jrt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            mi.mensajeHola();

            /// Varible que controla la entrada y salida del bucle while
         
            bool cerrarMenu = false;
            /// Nos indicará la opción que seleccione el usuario

            /// Indica que desde la primer iteración debe cumplirse tal condición
            while (!cerrarMenu)
            {
                int numero = mi.opcionesMenu();
                switch(numero)
                {
                    case 0:
                        Console.WriteLine("Vuelve pronto");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Aqui te mostramos las tarifas:");
                        Console.WriteLine("Un día 2 eur");
                        Console.WriteLine("Un mes 23 eur");
                        Console.WriteLine("Un año 200 eur");
                        break;

                    case 2:
                        Console.WriteLine("libera una bici");
                        break;
                }
            }
            
        }
    }
}
