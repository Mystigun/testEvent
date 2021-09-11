using System;

namespace testEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Player player = null;


                Console.WriteLine("Möchten sie einen neuen spieler erstellen?\n1 = Ja\n2 = Nein");
                string eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out int zahl))
                {
                    if(zahl == 1)
                    {
                        player = new Player(20);
                        Console.WriteLine("Ein neuer spieler wurde erstellt");
                    }
                    if(zahl == 2)
                    {
                        Console.WriteLine("Es wurde kein neuer spieler erstellt spiel ende");
                    }
                }
                else
                {
                    Console.WriteLine("Die eingabe war nich richtig");
                }

                if(player != null)
                {
                    Console.WriteLine("Möchten sie den spieler hauen?\n1 = Ja\n2 = Nein");

                    string eingabe1 = Console.ReadLine();

                    if (int.TryParse(eingabe1, out int zahl2))
                    {
                        if (zahl2 == 1)
                        {                   
                            Console.WriteLine("Spieler wird gehaun");
                            player.SlapSelf(5);
                        }
                        if (zahl2 == 2)
                        {
                            Console.WriteLine("Der spieler wurde verschont");
                        }
                    }
                }
               

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
