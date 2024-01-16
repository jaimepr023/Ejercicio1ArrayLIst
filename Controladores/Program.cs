using Ejercicio1ArrayList.Servicios;

namespace Ejercicio1ArrayList
{
    class program
    {
        public static void Main(String[] args)
        {
            OperacionesInterfaz operaciones = new OperacionesImplementacion();
            char afirmacion;
            do
            {
                string nombre = operaciones.pedirNombre();

                Console.WriteLine("Dame tu primer apellido");
                string apellido1 = operaciones.pedirApellido();

                Console.WriteLine("Dame tu segundo apellido");
                string apellido2 = operaciones.pedirApellido();

                if (nombre != apellido1 | nombre != apellido2)
                {
                    operaciones.pedirDNI();
                    operaciones.codigPostal();
                    operaciones.concatena(apellido1, apellido2, nombre);

                }
                else
                {
                    Console.WriteLine("el nombre y los apellidos coinciden");
                }
                 afirmacion= operaciones.afirmacion();
            } while (afirmacion=='s');
           
        }
    }
}
