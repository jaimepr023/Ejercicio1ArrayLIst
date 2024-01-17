using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1ArrayList.Servicios
{
    internal interface OperacionesInterfaz
    {
        public string pedirNombre();

        public string pedirApellido();

        public void pedirDNI();

        public char afirmacion();

        public void codigPostal();

        public string concatena(string apellido1,string apellido2, string nombre);

        public void separar(string apellido1, string apellido2, string nombre);

        public void calcularTam(string apellido1, string apellido2, string nombre);

        public void separarNombre(string nombre);

    }
}
