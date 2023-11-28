using menuCajero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuCajero.Servicios
{
    internal interface ClienteInterfaz
    {
       
        /// <summary>
        /// Metodo que da de alta a los clientes
        /// msm - 22112023
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<ClienteDto> listaAntigua);

        /// <summary>
        /// Metodo que pregunta y permite modificar el valor de los campos de un cliente
        /// msm - 22112023
        /// </summary>
        /// <param name="listaAntigua"></param>

        public void modificarCliente(List<ClienteDto> listaAntigua);
        /// <summary>
        /// Borrar cliente 
        /// msm - 281123
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void borrarClientes(List<ClienteDto> listaAntigua);
    }
}
