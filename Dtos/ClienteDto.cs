using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuCajero.Dtos
{
    /// <summary>
    /// Clase que se almacena los campos y metodos de un cliente
    /// 22112023 - msms
    /// </summary>
    internal class ClienteDto
    {
        //ATRIBUTOSS (CARACTERISTICAS)
        //Son private por defecto 

        long idCliente; //PrimaryKey

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string dniCliente = "aaaaa"; //UNIVOCO

        string fchaNacimientoCliente = "9999/12/31";

        string emailCliente = "aaaaa";

        int tlfCliente = 1111111;

        string fchaAltaCliente = "9999/12/31";

        string fchaBajaCliente = "9999/12/31";

        //GETTERS Y SETTERS ( (metodo de acceso get-lectura; set-escritura) (señalar todo los campos y en acciones rapidas encapsular (segunda opcion) )

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchaNacimientoCliente { get => fchaNacimientoCliente; set => fchaNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchaAltaCliente { get => fchaAltaCliente; set => fchaAltaCliente = value; }




        //CONTRUCTORES (metodos que crean objetos -new) (

        public ClienteDto(long idCliente,string nombreCliente, string apellidosCliente, string dniCliente, string fchaNacimientoCliente, string emailCliente, int tlfCliente, string fchaAltaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchaNacimientoCliente = fchaNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchaAltaCliente = fchaAltaCliente;
        }

        public ClienteDto() { 
        }



        //TO STRING (
        override
        public string ToString()
        {
            string clienteString = "Nombre" + this.nombreCliente
            + " Apellidos: " + this.apellidosCliente +
            " DNI: " + this.dniCliente +
            " Fecha Nacimiento: " + this.fchaNacimientoCliente +
            " Email: " + this.emailCliente +
            "Tlf" + this.tlfCliente +
            "Fecha Alta" + this.FchaAltaCliente +
            "Fecha Baja" + this.fchaBajaCliente;

            return clienteString;
        }

    }
}
