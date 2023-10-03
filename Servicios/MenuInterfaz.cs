using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcobiciApp.Servicios
{
    /// <summary>
    /// Interfaz que nos indicará la relación que hay entre los métodos y la funcionalidad del menú
    /// 30092023 - jrt
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra la entrada o mensaje de bienvenida a la aplicación
        /// 30092023 - jrt
        /// </summary>
        public void mensajeHola();

        /// <summary>
        /// Método que muestra el menú de opciones y recoje la opción seleccionada por el usuario
        /// 30092023 - jrt
        /// </summary>
        /// <returns></returns>

        public int opcionesMenu();
    }
}
