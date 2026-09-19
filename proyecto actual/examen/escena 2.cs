using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escena_2
    {
        // ---------------------------------------
        // ESCENARIO 2
        // BOSQUE
        //-----------------------------------------

        public void GoblinPath()
        {
            Console.WriteLine("");
            Console.WriteLine("ESCENARIO 2: EL BOSQUE");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Entras al oscuro bosque.");
            Console.WriteLine("Escuchas unas ramas romperse...");
            Console.WriteLine("");

            Console.WriteLine("¡Un goblin aparece!");

            Combat fight =
                new Combat(
                    "Un goblin aparece entre los arboles.",
                    new Enemy("Goblin", 15, 3)
                );

            bool alive = fight.Execute(player);

            if (!alive)
            {
                Restart();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("Derrotaste al goblin.");
            Console.WriteLine("entras a su campamento abandonado.");

            GoblinCamp();
        }

    }
}
