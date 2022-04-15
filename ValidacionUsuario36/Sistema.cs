using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionUsuario36
{
    public class Sistema
    {
       
            public void MenuPrincipal()
            {
                Validador.Bienvenida();


                DateTime fecha = Validador.ValidarFechaIngresada("\n Ingrese una fecha");

                Console.Clear();
                Console.WriteLine("\n La fecha es *" + fecha.ToLongDateString() + "*.");

                Validador.Despedida();

            }

            public void Iniciar()
            {
                MenuPrincipal();
            }
     }
}
