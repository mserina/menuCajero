﻿using menuCajero.Servicios;
using menuCajero.Dtos;

namespace menuCajero{
    /// <summary>
    /// Clase principal de la aplicacion
    /// </summary>
    class Program
    {
        /// <summary>
        ///  Metodo de entrada a la aplicacion 
        ///  contiene el procedimiento de nuestra aplicacion
        ///  200923 - msm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentaDto> listaCuenta = new List<CuentaDto>();


            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            CuentaBancariaInterfaz cb = new CuentaBancariaImplementacion();

            //variable que conrola la  entrada y salida del bucle 
            bool cerrarMenu = false;
            //contener la opcion del usuario
            int opcionSelecionada;
            string respuestaModificacion;

            //desde la primera vuelta debe cumplirse la condicion
            while (!cerrarMenu)
            {
                opcionSelecionada = mi.mostrarMenuYSeleccion();

                switch (opcionSelecionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu |= true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - ALTA NUEVO CLIENTE");
                        ci.darAltaCliente(listaClientes);
                        
                        
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - CREAR NUEVA CUENTA");
                        cb.darAltaCuenta(listaCuenta);
                        foreach (CuentaDto cuentaDto in listaCuenta)
                        {
                            Console.WriteLine(cuentaDto.ToString());
                        }
                       
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - MODIFICAR CLIENTE");
                        do
                        {
                            ci.modificarCliente(listaClientes);
                            Console.WriteLine("Quieres seguir modificando los datos s/n");
                            respuestaModificacion = Console.ReadLine();
                        } while (respuestaModificacion == "s");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - ELIMINAR UN CLIENTE");
                        ci.borrarClientes(listaClientes);
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5");
                        break;
                    case 6:
                        Console.WriteLine("[INFO] - Se ejecuta caso 6");
                        foreach(ClienteDto clienteDto in listaClientes)
                        {
                            Console.WriteLine(clienteDto.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("[INFO] - No existe esa opcion");
                        break;
                }

            }

        }
    }
}