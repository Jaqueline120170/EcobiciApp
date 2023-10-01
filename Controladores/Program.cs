using EcobiciApp.Servicios;

namespace EcobiciApp.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            mi.mensajeHola();

            bool cerrarMenu = false;

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
                        break;

                    case 2:
                        Console.WriteLine("libera una bici");
                        break;
                }
            }
            
        }
    }
}
