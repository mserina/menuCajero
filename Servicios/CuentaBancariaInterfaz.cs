using menuCajero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuCajero.Servicios
{
    internal interface CuentaBancariaInterfaz
    {
        /// <summary>
        /// Metodo que da de alta las cuentas
        /// msm - 22112023
        /// </summary>
        public void darAltaCuenta(List<CuentaDto> listaCuentaAntigua);

    } 
}

