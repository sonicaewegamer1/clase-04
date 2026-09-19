using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class camino_del_santuario
    {
        // -------------------
        // CAMINO DEL SANTUARIO
        // -----------------------

        public void TreasurePath()
        {
            Console.WriteLine("");
            Console.WriteLine("te encuentras en una especie de santuario");
            Console.WriteLine("-------------------------");

            Event potion =
                new Event(
                    "Encuentras una pocion.",
                    new HealthPotion()
                );

            potion.Execute(player);

            Console.WriteLine("");
            Console.WriteLine("El santuario se divide en dos caminos...");
            Console.WriteLine("");

            Console.WriteLine("1. Camara del guerrero");
            Console.WriteLine("2. Pasillo oscuro");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Encuentras una espada antigua.");
                Console.WriteLine("Tu daño aumenta.");

                player.Damage += 5;
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Sigues tu camino.");
            }
            else
            {
                Console.WriteLine("obserbas el santuario, es bastante bello");
                TreasurePath();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("Un Lycantropo aparece...");
            Console.WriteLine("");

            Combat fight =
                new Combat(
                    "Este emerge de las sombras...",
                    new Enemy("Lycantropo", 45, 7)
                );

            bool alive = fight.Execute(player);

            if (!alive)
            {
                Restart();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("El Lycantropo cae ante ti...");
            Console.WriteLine("El aire del santuario cambia.");
            Console.WriteLine("Tu olor ya no es humano.");
            Console.WriteLine("");
            Console.WriteLine("Llegas al reino Lycantropo.");
            Console.WriteLine("Hueles como uno de ellos.");
            Console.WriteLine("Te aceptan.");
            Console.WriteLine("");
            Console.WriteLine("BEST ENDING: PARTE DE LA MANADA");
        }
    }
}
