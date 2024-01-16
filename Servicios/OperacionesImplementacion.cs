using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio1ArrayList.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        public char afirmacion()
        {
            Console.WriteLine("¿Quieres volver a realizarlo todo? (s/n)")
            char afirmacion = Convert.ToChar(Console.ReadLine());
                return afirmacion;
        }

        public string pedirApellido()
        {
      
            string apellido = Console.ReadLine();
            return apellido;
        }

     

        public void pedirDNI()
        {
            char[] letras = new char[] { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
           
            Console.WriteLine("Dame el dni(Numero)");
            int dniNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame el dni(Letra)");
            char letra = Convert.ToChar(Console.ReadLine());

            int resto = dniNum % 23;
            if (letras[resto] == letra)
            {
                Console.WriteLine("El DNI es valido");
            }else
            {
                Console.WriteLine("El DNI no es valido");
            }
           
        }

        public string pedirNombre()
        {
            Console.WriteLine("Dame tu nombre ");
            string nombre = Console.ReadLine();
            return nombre;
        }
    }
}
