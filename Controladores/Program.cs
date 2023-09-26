using menuCajero.Servicios;

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
            //Llamada al metodo que imprime el mensaje por consola

            MenuInterfaz mi = new MenuImplementacion();
            mi.mensajeBienvenida();

            //variable que conrola la  entrada y salida del bucle 
            bool cerrarMenu = false;
            //contener la opcion del usuario
            int opcionSelecionada;

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
                        Console.WriteLine("[INFO] - Se ejecuta caso 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta caso 3");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5");
                        break;
                    default:
                        Console.WriteLine("[INFO] - No existe esa opcion");
                        break;
                }

            }

        }
    }
}