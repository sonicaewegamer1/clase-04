using System;

namespace examen
{
    public class Game
    {
        Player player;

        public void Start()
        {
            Console.WriteLine("================================");
            Console.WriteLine("       hola aventurero           ");
            Console.WriteLine("================================");

            Console.WriteLine("¿cómo deberia llamarte?");
            string name = Console.ReadLine();

            player = new Player(name);

            QuestStart();
        }

        // ----------------------------
        // ESCENARIO 1
        // ----------------------------

        public void QuestStart()
        {
            Console.WriteLine("");
            Console.WriteLine("¿a dónde ir?");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Has llegado a un cruce de caminos.");
            Console.WriteLine("Tres caminos aparecen frente a ti.");
            Console.WriteLine("");
            Console.WriteLine("1. Bosque");
            Console.WriteLine("2. Santuario");
            Console.WriteLine("3. Puerta de Piedra");

            string choice = GetChoice();

            if (IsValidChoice(choice))
            {
                if (choice == "1")
                {
                    CaminoBosque bosque = new CaminoBosque(this, player);
                    bosque.GoblinPath();
                }
                else if (choice == "2")
                {
                    CaminoSantuario santuario = new CaminoSantuario(this, player);
                    santuario.TreasurePath();
                }
                else if (choice == "3")
                {
                    // Por ahora dejamos este camino aquí.
                    StoneGatePath();
                }
            }
            else
            {
                Console.WriteLine("no trates de retroceder");
                QuestStart();
            }
        }

        // ----------------------------
        // PUERTA DE PIEDRA
        // ----------------------------

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

                CaminoBosque bosque = new CaminoBosque(this, player);
                bosque.LibraryPath();
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

        // ----------------------
        // FINALES
        // ----------------------

        public void FinalGood()
        {
            Console.WriteLine("");
            Console.WriteLine("==============================");
            Console.WriteLine("        FINAL BUENO");
            Console.WriteLine("==============================");
            Console.WriteLine("Has demostrado ser un verdadero héroe.");
            Console.WriteLine("");
        }

        public void FinalLycan()
        {
            Console.WriteLine("");
            Console.WriteLine("==============================");
            Console.WriteLine("       BEST ENDING");
            Console.WriteLine("==============================");
            Console.WriteLine("Te conviertes en parte de la manada.");
            Console.WriteLine("Ahora tienes un nuevo hogar.");
            Console.WriteLine("");
        }

        public void FinalBad()
        {
            Console.WriteLine("");
            Console.WriteLine("==============================");
            Console.WriteLine("        FINAL MALO");
            Console.WriteLine("==============================");
            Console.WriteLine("Tu aventura termina en las sombras.");
            Console.WriteLine("");
        }

        public void FinalSecret()
        {
            Console.WriteLine("");
            Console.WriteLine("==============================");
            Console.WriteLine("       FINAL SECRETO");
            Console.WriteLine("==============================");
            Console.WriteLine("Derrotaste al verdadero enemigo.");
            Console.WriteLine("El reino ha sido salvado.");
            Console.WriteLine("");
        }

        // ----------------------
        // REINICIO
        // ----------------------

        public void Restart()
        {
            Console.WriteLine("");
            Console.WriteLine("---- Un hada te ha resucitado ----");
            Console.WriteLine("¿Lo vuelves a intentar? si/no");

            string answer = Console.ReadLine();

            if (answer == "si")
            {
                Start();
            }
            else if (answer == "no")
            {
                Console.WriteLine(" fin de tu aventura");
            }
            else
            {
                Console.WriteLine("El hada no te entiende.");
            }
        }

        // =====================================================
        // SEGUROS ANTI FALLOS
        // =====================================================

        public string GetChoice()
        {
            try
            {
                string choice = Console.ReadLine();

                if (choice == null)
                {
                    throw new Exception();
                }

                return choice;
            }
            catch
            {
                Console.WriteLine("hablaste en un dialecto totalmente incomprensible..");
                return "";
            }
        }

        public bool IsValidChoice(string choice)
        {
            Func<string, bool> validChoice =
                option => option == "1" || option == "2" || option == "3";

            return validChoice(choice);
        }
    }
}