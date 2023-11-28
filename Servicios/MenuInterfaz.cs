using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuCajero.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a toda las acciones que se pueden hacer desde el menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el mensaje de bienvenida
        /// 250923 - msm
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el menu y recoge la seleccion del usuario
        /// 250923 - msm
        /// </summary>
        /// <returns>un entero con la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();
        void mostrarMenuYSeleccionada();

        public string pedirDNI();
    }
}
