using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class escenario_6
    {
        // --------------------
        // ESCENARIO 6
        // CRIPTA
        // ----------------

        public void CryptPath()
        {
            Console.WriteLine("");
            Console.WriteLine("al seguir tu camino, te encuentas en una cripta");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Bajas unas escaleras.....");
            Console.WriteLine("Una figura aparece entre las sombras.");
            Console.WriteLine("");

            Console.WriteLine("¡El Guardian de la Cripta te ataca!");

            Combat fight =
                new Combat(
                    "lobo de fuego",
                    new Enemy("lobo de fuego", 40, 6)
                );

            bool alive = fight.Execute(player);

            if (!alive)
            {
                Restart();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("Derrotaste al Guardian.");
            Console.WriteLine("Encuentras una llave negra.");

            PortalPath();
        }
    }
}
