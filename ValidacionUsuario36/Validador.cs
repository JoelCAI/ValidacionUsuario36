﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionUsuario36
{
    public class Validador
    {
        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static DateTime ValidarFechaIngresada(string mensaje)
        {
            bool ingresoCorrecto;
            DateTime fechaValida;

            do
            {

                Console.Clear();
                Console.WriteLine("\n Ingrese un formato válido.");
                Console.WriteLine("\n El formato correcto es *dd/mm/aaaa*.");
                Console.WriteLine("\n También puede ser *dd/mm/aaaa hh:mm:ss*.");
                Console.WriteLine(mensaje);
                string ingresoNacimiento = Console.ReadLine();

                ingresoCorrecto = DateTime.TryParse(ingresoNacimiento, out fechaValida);

                if (!ingresoCorrecto)
                {
                    continue;
                }


            } while (!ingresoCorrecto);

            Console.Clear();
            Console.WriteLine("\n Usted ingreso una fecha correcta que es *" + fechaValida + "*.");
            return fechaValida;
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa, presione cualquier tecla para Iniciar");
            Console.ReadKey();
        }
    }
}
