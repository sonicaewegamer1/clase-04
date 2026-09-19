using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escenario_9
    {
        // ------------------------
        // ESCENARIO 9
        // REINO LYCANTROPO
        //-----------------

        public void LycanKingdom()
        {
            Console.WriteLine("");
            Console.WriteLine("al cruzar por el portal, el brillo te ciega un momento");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Llegas a un bosque cubierto por la luna.");
            Console.WriteLine("Un grupo de Lycantropos te rodea.");
            Console.WriteLine("");

            Console.WriteLine("Hueles diferente...");
            Console.WriteLine("Pero has demostrado tu fuerza.");
            Console.WriteLine("huelen el olor de un antiguo compañero suyo en ti, quizá fue aquel habitante que viste");
            Console.WriteLine("");

            Console.WriteLine("1. Unirte a la manada");
            Console.WriteLine("2. Enfrentarlos");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Los Lycantropos te aceptan.");
                FinalLycan();
            }
            else if (choice == "2")
            {
                Combat fight =
                    new Combat(
                        "Los Lycantropos atacan.",
                        new Enemy("Lycantropo", 45, 7)
                    );

                bool alive = fight.Execute(player);

                if (!alive)
                {
                    Restart();
                    return;
                }

                Console.WriteLine("");
                Console.WriteLine("Sobreviviste al combate.");

                FinalGood();
            }
            else
            {
                Console.WriteLine("no trates de uir");
                LycanKingdom();
            }
        }
    }
}
