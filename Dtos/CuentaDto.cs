using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuCajero.Dtos
{
    internal class CuentaDto
    {

        //ATRIBUTOS 
        long id;

        int isban;

        string codigoSwitch = "CSI1SSXX";

        string fechaDeAlta;

        string fecha_de_baja = "9999/12/31";

        string dniUsuario;




        //GETTERS Y SETTERS
        public long Id { get => id; set => id = value; }
        public int Isban { get => isban; set => isban = value; }
        public string CodigoSwitch { get => codigoSwitch; set => codigoSwitch = value; }
        public string FechaDeAlta { get => fechaDeAlta; set => fechaDeAlta = value; }
        public string Fecha_de_baja { get => fecha_de_baja; set => fecha_de_baja = value; }
        public string DniUsuario { get => dniUsuario; set => dniUsuario = value; }


        //CONTRUCTORES
        public CuentaDto(long id, int isban, string codigoSwitch, string fechaDeAlta, string fecha_de_baja, string dniUsuario)
        {
            this.id = id;
            this.isban = isban;
            this.codigoSwitch = codigoSwitch;
            this.fechaDeAlta = fechaDeAlta;
            this.fecha_de_baja = fecha_de_baja;
            this.dniUsuario = dniUsuario;
        }

        public CuentaDto()
        {

        }

        //TO STRING

        override
        public string ToString()
        {
            string cuentaString =
                " id: " + this.id +
                " isban: " + this.isban +
                " codigoSwitch: " + this.codigoSwitch +
                " Fecha Alta: " + this.fechaDeAlta +
                " Fecha Baja: " + this.fecha_de_baja +
                " DNI Cliente: " + this.dniUsuario;

            return cuentaString;    

        }


    }
}
