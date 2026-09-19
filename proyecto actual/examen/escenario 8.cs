using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escenario_8
    {
        // ---------------
        // ESCENARIO 8
        // REINO HUMANO
        //-----------------

        public void HumanKingdom()
        {
            Console.WriteLine("");
            Console.WriteLine("al cruzar por el portal, el brillo te ciega un momento");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Llegas a un enorme castillo.");
            Console.WriteLine("Los soldados te llevan ante el Rey.");
            Console.WriteLine("");

            Console.WriteLine("Has sobrevivido a las tierras oscuras.");
            Console.WriteLine("Demuestra ahora que eres digno.");

            Console.WriteLine("");
            Console.WriteLine("1. Aceptar la prueba");
            Console.WriteLine("2. Rechazarla");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("El Rey reconoce tu valor, tal parece que el mero echo de aceptar era suficiente.");
                FinalGood();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("El Rey se esepciona de tí, los guardias te lleban");
                FinalBad();
            }
            else
            {
                Console.WriteLine(" a estas alturas....¿ aún crees que puedes regresar?");
                HumanKingdom();
            }
        }

    }
}
