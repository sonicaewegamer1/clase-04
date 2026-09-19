using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escenario_3
    {
        // -------------------
        // ESCENARIO 3
        // CAMPAMENTO GOBLIN
        // ------------------

        public void GoblinCamp()
        {
            Console.WriteLine("");
            Console.WriteLine("miras alrededor");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Encuentras dos caminos.");
            Console.WriteLine("");

            Console.WriteLine("1. Seguir  huellas.");
            Console.WriteLine("2. Entrar en la pequeña cueva.");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Sigues las huellas y encuentras una pocion.");

                Event potion =
                    new Event(
                        "Encuentras una pocion.",
                        new HealthPotion()
                    );

                potion.Execute(player);

                LibraryPath();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Entras en la cueva...");
                Console.WriteLine("Encuentras una espada oxidada pero que emana gran poder.");
                Console.WriteLine("Tu daño aumenta.");

                player.Damage += 5;

                LibraryPath();
            }
            else
            {
                Console.WriteLine("ya no puedes retroceder");
                GoblinCamp();
            }
        }
    }
}
