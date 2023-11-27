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
            idCliente = Convert.ToInt64(Console.ReadLine());
            
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

        public void modificarCliente(List<ClienteDto> listaAntigua)
        {
            Console.WriteLine("Inserte DNI");
            string DNIIntroducido = Console.ReadLine();

            foreach (ClienteDto cliente in listaAntigua)
            {
                if (DNIIntroducido.Equals(cliente.DniCliente)){

                    Console.WriteLine("Quiere cambiar el Nombre s/n");
                    string respuesta1=Console.ReadLine();
                    if(respuesta1 == "s")
                    {
                        Console.WriteLine("Introduzca un nombre");
                        cliente.NombreCliente = Console.ReadLine();
                    }

                    Console.WriteLine("Quiere cambiar el Apellido s/n");
                    string respuesta2 = Console.ReadLine();
                    if (respuesta2 == "s")
                    {
                        Console.WriteLine("Introduzca un Apèllido");
                        cliente.ApellidosCliente = Console.ReadLine();
                    }

                    Console.WriteLine("Quiere cambiar el Fecha de nacimiento s/n");
                    string respuesta3 = Console.ReadLine();
                    if (respuesta3 == "s")
                    {
                        Console.WriteLine("Introduzca un Fecha de nacimiento");
                        cliente.FchaNacimientoCliente = Console.ReadLine();
                    }

                    Console.WriteLine("Quiere cambiar el email s/n");
                    string respuesta4 = Console.ReadLine();
                    if (respuesta4 == "s")
                    {
                        Console.WriteLine("Introduzca un email");
                        cliente.EmailCliente = Console.ReadLine();
                    }

                    Console.WriteLine("Quiere cambiar el telefono s/n");
                    string respuesta5 = Console.ReadLine();
                    if (respuesta5 == "s")
                    {
                        Console.WriteLine("Introduzca un telefono");
                        cliente.TlfCliente = Int32.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Quiere cambiar el Fecha de alta s/n");
                    string respuesta6 = Console.ReadLine();
                    if (respuesta6 == "s")
                    {
                        Console.WriteLine("Introduzca un Fecha de alta");
                        cliente.FchaAltaCliente = Console.ReadLine();
                    }

                    Console.WriteLine(cliente.ToString());

                }

            }
            
        }
    }
}
