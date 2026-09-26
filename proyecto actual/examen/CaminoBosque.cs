using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class CaminoBosque
    {
        private Game game;
        private Player player;

        public CaminoBosque(Game game, Player player)
        {
            this.game = game;
            this.player = player;
        }

        // ----------------------------
        // ESCENARIO 2
        // BOSQUE
        // ----------------------------

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
                game.Restart();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("Derrotaste al goblin.");
            Console.WriteLine("entras a su campamento abandonado.");

            GoblinCamp();
        }

        // -------------------
        // ESCENARIO 3
        // CAMPAMENTO GOBLIN
        // -------------------

        public void GoblinCamp()
        {
            Console.WriteLine("");
            Console.WriteLine("miras alrededor");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Encuentras dos caminos.");
            Console.WriteLine("");

            Console.WriteLine("1. Seguir huellas.");
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

        // -------------------------------
        // ESCENARIO 4
        // BIBLIOTECA
        // -------------------------------

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

        // --------------------
        // ESCENARIO 5
        // ALDEA
        // ---------------------

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
                Console.WriteLine("entras a la casa y, ves a su hermano mal herido, tras ayudarlo como agradecimiento te dan una poción");

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
                    game.Restart();
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
                game.Restart();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("Derrotaste al Guardian.");
            Console.WriteLine("Encuentras una llave negra.");

            PortalPath();
        }

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

        // -----------------
        // ESCENARIO 8
        // REINO HUMANO
        // -----------------

        public void HumanKingdom()
        {
            Console.WriteLine("");
            Console.WriteLine("al cruzar por el portal, el brillo te ciega un momento");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Llegas a un enorme castillo.");
            Console.WriteLine("Los soldados te llevan ante el Rey.");
            Console.WriteLine("");

            Console.WriteLine("Has sobrevivido a las tierras oscuras.");
            Console.WriteLine("Demuestra ahora que eres digno.");
            Console.WriteLine("");

            Console.WriteLine("1. Aceptar la prueba");
            Console.WriteLine("2. Rechazarla");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("El Rey reconoce tu valor, tal parece que el mero echo de aceptar era suficiente.");

                game.FinalGood();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("El Rey se esepciona de tí, los guardias te lleban");

                game.FinalBad();
            }
            else
            {
                Console.WriteLine("a estas alturas....¿ aún crees que puedes regresar?");

                HumanKingdom();
            }
        }

        // ------------------------
        // ESCENARIO 9
        // REINO LYCANTROPO
        // -----------------

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

                game.FinalLycan();
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
                    game.Restart();
                    return;
                }

                Console.WriteLine("");
                Console.WriteLine("Sobreviviste al combate.");

                game.FinalGood();
            }
            else
            {
                Console.WriteLine("no trates de uir");

                LycanKingdom();
            }
        }

        // ---------------------
        // ESCENARIO 10
        // REINO OSCURO
        // ---------------------

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
                    game.Restart();
                    return;
                }

                Console.WriteLine("");
                Console.WriteLine("Has derrotado al Señor Oscuro.");
                Console.WriteLine("El reino comienza a desaparecer.");

                game.FinalSecret();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Aceptas, empiezas a ser consumido por la oscuridad.");

                game.FinalBad();
            }
            else
            {
                Console.WriteLine("no trates de escapar...");

                DarkKingdom();
            }
        }
    }
}