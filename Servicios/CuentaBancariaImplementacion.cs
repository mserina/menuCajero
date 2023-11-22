using menuCajero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuCajero.Servicios
{
    internal class CuentaBancariaImplementacion : CuentaBancariaInterfaz
    {

        public void darAltaCuenta(List<CuentaDto> listaCuentaAntigua){
                CuentaDto cuentaDto = CuentaNuev();
                listaCuentaAntigua.Add(cuentaDto);
            }
        private CuentaDto CuentaNuev()
        {
            CuentaDto nuevaCuenta = new CuentaDto();

            Console.WriteLine("Introduzca id de la cuenta");
            nuevaCuenta.Id = Convert.ToInt64(Console.ReadLine());
           
            Console.WriteLine("Introduzca el isban");
            nuevaCuenta.Isban = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Introduzca fecha de alta");
            nuevaCuenta.FechaDeAlta = Console.ReadLine();

            Console.WriteLine("Introduzca DNI del cliente");
            nuevaCuenta.DniUsuario = Console.ReadLine();


            return nuevaCuenta;
 
         
        }
    }

}
