using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuCajero.Servicios
{
    /// <summary>
    /// Implementacion de las acciones del menu
    /// 200923 - msm
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido al banco de CSI1";

            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("######################################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Dar cuenta de alta");
            Console.WriteLine("3. Sacar dinero");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("#####################################");
            Console.WriteLine("Seleccione opcion");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');

            return opcionIntroducida;


        }

        public void mostrarMenuYSeleccionada()
        {
            throw new NotImplementedException();
        }
    }   
}
