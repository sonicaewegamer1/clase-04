using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escenario_10
    {
        // ---------------------
        // ESCENARIO 10
        // REINO OSCURO / FINAL1
        // ---------------

        public void DarkKingdom()
        {
            Console.WriteLine("");
            Console.WriteLine("al cruzar por el portal, el brillo te ciega un momento");
            Console.WriteLine("-------------------------");

            Console.WriteLine("El portal te lleva a un reino completamente oscuro.");
            Console.WriteLine("Una figura misteriosa aparece.");
            Console.WriteLine("");

            Console.WriteLine("alfin has llegado");
            Console.WriteLine("Te estaba esperando.");
            Console.WriteLine("");

            Console.WriteLine("1. Enfrentarlo");
            Console.WriteLine("2. Unirte a el");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Combat fight =
                    new Combat(
                        "La figura oscura revela su verdadero poder.",
                        new Enemy("Señor Oscuro", 60, 8)
                    );

                bool alive = fight.Execute(player);

                if (!alive)
                {
                    Restart();
                    return;
                }

                Console.WriteLine("");
                Console.WriteLine("Has derrotado al Señor Oscuro.");
                Console.WriteLine("El reino comienza a desaparecer.");

                FinalSecret();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Aceptas, empiezas a ser consumido por la oscuridad.");
                FinalBad();
            }
            else
            {
                Console.WriteLine("no trates de escapar...");
                DarkKingdom();
            }
        }
    }
}
