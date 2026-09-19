using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escenario_4
    {
        // -------------------------------
        // ESCENARIO 4
        // BIBLIOTECA
        // --------------

        public void LibraryPath()
        {
            Console.WriteLine("");
            Console.WriteLine("Sigues caminando, encuentras una biblioteca");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Llegas a un librero cubierto de polvo.");
            Console.WriteLine("Tres libros llaman tu atención.");
            Console.WriteLine("");

            Console.WriteLine("1. El libro del Rey");
            Console.WriteLine("2. El libro de los Lycantropos");
            Console.WriteLine("3. El libro prohibido");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("el libro habla de un pueblo que fue abandonado por el rey");
                Console.WriteLine("Asumes que quizá puedas conseguir una recompensa si lo visitas");
                Console.WriteLine("");
                Console.WriteLine("Decides continuar tu camino hacia la aldea.");

                VillagePath();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Los Lycantropos buscan proteger el bosque.");
                Console.WriteLine("Descubres la existencia de un antiguo santuario.");
                LibraryPath();
            }
            else if (choice == "3")
            {
                Console.WriteLine("");
                Console.WriteLine("Lees el libro prohibido...");
                Console.WriteLine("Una extraña energia te rodea dañandote");
                Console.WriteLine("Pero logras cerrar el libro...");
                player.Health -= 5;

                Console.WriteLine("Perdiste 5 puntos de vida.");
                LibraryPath();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Los demás libros están muy quemados o desgastados para leer.");
                LibraryPath();
            }
        }

    }
}
