using menuCajero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuCajero.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        //darAltaCliente
        //public void darAltaCliente(List<ClienteDto> listaAntigua){
        //          creo un cliente (crearNuevoCliente) <--metodo
        //          añado a listaAntigua el cliente
        //}
        //private ClienteDto crearNuevoCliente()

        public void darAltaCliente(List <ClienteDto> listaAntigua)
        {
            ClienteDto nuevoCliente = crearNuevoCliente();
            listaAntigua.Add(nuevoCliente);
        }


        private ClienteDto crearNuevoCliente()
        {
            long idCliente;
            string nombreCliente;
            string apellidosCliente;
            string dniCliente;
            string fchaNacimientoCliente;
            string emailCliente;
            int tlfCliente;
            string fchaAltCliente;

            Console.WriteLine("Inserta id");
            idCliente = Convert.ToInt64(Console.ReadKey());
            
            Console.WriteLine("Dame nombre");
            nombreCliente = Console.ReadLine();

            Console.WriteLine("Dame apellido");
            apellidosCliente = Console.ReadLine();

            Console.WriteLine("Dame dni");
            dniCliente = Console.ReadLine();

            Console.WriteLine("Dame fecha de nacimiento");
            fchaNacimientoCliente = Console.ReadLine();

            Console.WriteLine("Dame email");
            emailCliente = Console.ReadLine();

            Console.WriteLine("Dame telefono");
            tlfCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame fecha de alta");
            fchaAltCliente = Console.ReadLine();



            ClienteDto clienteNuevo = new ClienteDto(idCliente, nombreCliente, apellidosCliente, dniCliente, fchaNacimientoCliente, emailCliente, tlfCliente, fchaAltCliente);
            return clienteNuevo;
        }

    }
}
