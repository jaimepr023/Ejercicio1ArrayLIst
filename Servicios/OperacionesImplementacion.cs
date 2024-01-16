﻿using System;
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
            Console.WriteLine("¿Quieres volver a realizarlo todo? (s/n)");
            char afirmacion = Convert.ToChar(Console.ReadLine());
                return afirmacion;
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

        public string pedirApellido()
        {

            string apellido = Console.ReadLine();
            return apellido;
        }

        public string pedirNombre()
        {
            Console.WriteLine("Dame tu nombre ");
            string nombre = Console.ReadLine();
            return nombre;
        }

        public void codigPostal()
        {
            int[] codigo = new int[] { 41001, 41002, 41003, 41004, 41005, 41005, 41006, 41007, 41008, 41009, 41010, 41011, 41012, 41013, 41014, 41015, 41016, 41017, 41018, 41019, 41020, 41092 };
            Console.WriteLine("Dime el codigo postal de su municipio: ");
            int CodigP = Int32.Parse(Console.ReadLine());

          
                if (codigo.Contains(CodigP))
                {
                    Console.WriteLine("El codigo postal de su municipio se encuentra en sevilla.");
                }
                else
                {
                    Console.WriteLine("El codigo postal de su municipio no se encuentra en sevilla.");
                }
        }

        public string concatena(string apellido1, string apellido2, string nombre)
        {
           string nombreCompleto = String.Concat(apellido1 , " " , apellido2, ",", nombre);
            return nombreCompleto;
        }

        public void separar(string apellido1, string apellido2, string nombre)
        {
           string nombreCompleto = concatena(apellido1, apellido2, nombre);
            Console.WriteLine("El nombre completo es: " + nombreCompleto);

            string[] separado = nombreCompleto.Split(",");

            string apellidos = separado[0];

            Console.WriteLine("LOs apellidos son: "+apellidos);
        }
    }
}
