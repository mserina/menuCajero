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
            bool cerrarMenu = false;
            int opcionSeleccionada;

            foreach (ClienteDto cliente in listaAntigua)
            {
                if (DNIIntroducido.Equals(cliente.DniCliente)){

                    while (!cerrarMenu)
                    {
                        opcionSeleccionada = mostrarMenu();
                        switch(opcionSeleccionada)
                        {
                            case 0:
                                Console.WriteLine("Quiere cambiar el Nombre s/n");
                                string respuesta1 = Console.ReadLine();
                                if (respuesta1 == "s")
                                {
                                    Console.WriteLine("Introduzca un nombre");
                                    cliente.NombreCliente = Console.ReadLine();
                                }
                                break;
                            case 1:
                                Console.WriteLine("Quiere cambiar el Apellido s/n");
                                string respuesta2 = Console.ReadLine();
                                if (respuesta2 == "s")
                                {
                                    Console.WriteLine("Introduzca un Apèllido");
                                    cliente.ApellidosCliente = Console.ReadLine();
                                }
                                break;
                            case 2:
                                Console.WriteLine("Quiere cambiar el Fecha de nacimiento s/n");
                                string respuesta3 = Console.ReadLine();
                                if (respuesta3 == "s")
                                {
                                    Console.WriteLine("Introduzca un Fecha de nacimiento");
                                    cliente.FchaNacimientoCliente = Console.ReadLine();
                                }
                                break;
                            case 3:
                                Console.WriteLine("Quiere cambiar el email s/n");
                                string respuesta4 = Console.ReadLine();
                                if (respuesta4 == "s")
                                {
                                    Console.WriteLine("Introduzca un email");
                                    cliente.EmailCliente = Console.ReadLine();
                                }
                                break;

                            case 4:
                                Console.WriteLine("Quiere cambiar el telefono s/n");
                                string respuesta5 = Console.ReadLine();
                                if (respuesta5 == "s")
                                {
                                    Console.WriteLine("Introduzca un telefono");
                                    cliente.TlfCliente = Int32.Parse(Console.ReadLine());
                                }
                                break;
                            case 5:
                                Console.WriteLine("Quiere cambiar el Fecha de alta s/n");
                                string respuesta6 = Console.ReadLine();
                                if (respuesta6 == "s")
                                {
                                    Console.WriteLine("Introduzca un Fecha de alta");
                                    cliente.FchaAltaCliente = Console.ReadLine();
                                }
                                break;

                                case 6:
                                    Console.WriteLine(cliente.ToString());
                                break;

                                case 7:
                                    Console.WriteLine("Saliendo");
                                    cerrarMenu = true;
                                break;

                                
                                   
                        }
                    }     

                }
                else 
                {
                    Console.WriteLine("No existe ningun cliente con ese DNI");
                    return;
                }

            }
            
        }

        private int mostrarMenu()
        {
            int opcionSelecionada;
            Console.WriteLine("0. Modificar Nombre");
            Console.WriteLine("1. Modificar Apellido");
            Console.WriteLine("2. Modificar Fecha de nacimiento");
            Console.WriteLine("3. Modificar email");
            Console.WriteLine("4. Modificar telefono");
            Console.WriteLine("5. Modificar Fecha de alta");
            Console.WriteLine("6. Mostrar cambios");
            Console.WriteLine("7. Salir");
            opcionSelecionada = Console.ReadKey(true).KeyChar - ('0');
            return opcionSelecionada;



        }

        public void borrarClientes(List<ClienteDto> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string DNIIntroducido = mi.pedirDNI();

            //OBBJETO ESPECIFICO //se elimina por referncia de memoria no por campos
            ClienteDto clienteABorrar = new ClienteDto();
            foreach(ClienteDto cliente in listaAntigua)
            {
                clienteABorrar = cliente;
                break;
            }
            listaAntigua.Remove(clienteABorrar);



            /*
            //Posicion 
            int it;
            bool borrar = false;
            for (it = 0; it < listaAntigua.Count; it++)
            {
                if (listaAntigua[it].DniCliente.Equals(DNIIntroducido))
                {
                    borrar = true;
                    break;
                }
            }
            if (borrar)
            {
                listaAntigua.RemoveAt(it);
            }
            else
            {
                Console.WriteLine("No existe el cliente");
            }
            */



        }

    }
}
