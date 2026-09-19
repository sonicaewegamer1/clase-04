using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escenario_7
    {
        // -----------------
        // ESCENARIO 7
        // PORTAL
        // ------------------

        public void PortalPath()
        {
            Console.WriteLine("");
            Console.WriteLine("La llave abre una enorme puerta");
            Console.WriteLine("-------------------------");

            Console.WriteLine(" dudas pero la abres de par en par");
            Console.WriteLine("Detras aparece un portal magico.");
            Console.WriteLine("");

            Console.WriteLine("Tres caminos aparecen:");
            Console.WriteLine("");
            Console.WriteLine("1. Reino Humano");
            Console.WriteLine("2. Reino Lycantropo");
            Console.WriteLine("3. Reino Oscuro");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                HumanKingdom();
            }
            else if (choice == "2")
            {
                LycanKingdom();
            }
            else if (choice == "3")
            {
                DarkKingdom();
            }
            else
            {
                Console.WriteLine("ya es demaciado tarde para pensar en volver, ¿no lo crees?");
                PortalPath();
            }
        }
    }
}
