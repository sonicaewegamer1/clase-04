using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class puerta_de_piedra
    {
        // ---------------------
        // PUERTA DE PIEDRA
        // -----------------------

        public void StoneGatePath()
        {
            Console.WriteLine("");
            Console.WriteLine("ESCENARIO 2: LA PUERTA DE PIEDRA");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Una enorme puerta bloquea tu camino.");
            Console.WriteLine("");
            Console.WriteLine("\"Solo aquel que entregue algo podrá pasar.\"");
            Console.WriteLine("");

            Console.WriteLine("1. Intentar abrir la puerta");
            Console.WriteLine("2. Buscar otra entrada");
            Console.WriteLine("3. Retroceder");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("La puerta comienza a temblar...");
                Console.WriteLine("¡Una trampa se activa!");
                Console.WriteLine("");
                Console.WriteLine("Caes por un precipicio.");

                FinalBad();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Encuentras una pequeña entrada secreta.");
                Console.WriteLine("Consigues continuar tu aventura.");

                LibraryPath();
            }
            else if (choice == "3")
            {
                QuestStart();
            }
            else
            {
                Console.WriteLine("Opcion invalida.");
                StoneGatePath();
            }
        }

    }
}
