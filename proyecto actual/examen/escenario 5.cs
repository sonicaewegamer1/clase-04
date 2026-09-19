using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escenario_5
    {
        // --------------------
        // ESCENARIO 5
        // ALDEA
        //---------------------

        public void VillagePath()
        {
            Console.WriteLine("");
            Console.WriteLine("llegas a la aldea del altiplano");
            Console.WriteLine("-------------------------");

            Console.WriteLine("parece que has llegado demaciado tarde, todo está abandonado");
            Console.WriteLine("derrepente ves a un hombre que corre a ti desesperado");
            Console.WriteLine("");
            Console.WriteLine("Ayudame... ¡mi hermano esta atrapado!");
            Console.WriteLine("");

            Console.WriteLine("1. Ayudarlo");
            Console.WriteLine("2. Ignorarlo");
            Console.WriteLine("3. cuestionarlo");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("entras a la casa y, ves a su hermano  mal herido, tras ayudarlo como agradecimiento te dan una poción");

                Event potion =
                    new Event(
                        "aceptas la pocion y sigues tu camino.",
                        new HealthPotion()
                    );

                potion.Execute(player);

                CryptPath();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Decides continuar tu camino.");

                CryptPath();
            }
            else if (choice == "3")
            {
                Console.WriteLine("");
                Console.WriteLine("El hombre comienza a transformarse.");
                Console.WriteLine("¡Era un monstruo!");

                Combat fight =
                    new Combat(
                        "El aldeano se transforma.",
                        new Enemy("shapeshifter", 30, 5)
                    );

                bool alive = fight.Execute(player);

                if (!alive)
                {
                    Restart();
                    return;
                }

                Console.WriteLine("");
                Console.WriteLine("lo derrotaste..");

                CryptPath();
            }
            else
            {
                Console.WriteLine("Decides huir, algo te dio mala espina,");
                Console.WriteLine("pero tropiezas y te haces algo de daño.");

                player.Health -= 5;

                Console.WriteLine("Perdiste 5 puntos de vida.");

                VillagePath();
            }
        }

    }
}
