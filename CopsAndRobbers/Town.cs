using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsAndRobbers
{
    class Town
    {
        List<Person> townsimulation = new List<Person>();
        Random randy = new Random();

        protected static int townwidth = 100;
        protected static int townheight = 25;

        private void Generate() //Metod för att generera slumpad info om varje person
        {

            for (int i = 0; i < 100; i++) //Randomizar följande int/floats som appliceras individuellt för varje person, upp till 100
            {
                int generate_person = randy.Next(0, 3);
                float generate_movement_x = randy.Next(-2, 2);
                float generate_movement_y = randy.Next(-2, 2);
                int generate_startpos_x = randy.Next(0, 100);
                int generate_startpos_y = randy.Next(0, 25);
                int[] citizen_inventory = { 1, 1, 1, 1 };
                int[] empty_inventory = { 0, 0, 0, 0 };

                if (generate_person == 0)
                {
                    townsimulation.Add(new Citizen(generate_startpos_x, generate_startpos_y, generate_movement_x, generate_movement_y, citizen_inventory));
                }
                if (generate_person == 1)
                {
                    townsimulation.Add(new Robber(generate_startpos_x, generate_startpos_y, generate_movement_x, generate_movement_y, empty_inventory));
                }
                if (generate_person == 2)
                {
                    townsimulation.Add(new Police(generate_startpos_x, generate_startpos_y, generate_movement_x, generate_movement_y, empty_inventory));
                }

            }

            int count = 0;
            foreach (var item in townsimulation) //Skriver ut info om varje person
            {
                count++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"[{count}] ");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(item);
                //Console.WriteLine("Starting Position X: " + item.Startpos_X);
                //Console.WriteLine("Starting Position Y: " + item.Startpos_Y);
                //Console.WriteLine("Movement X" + item.Xdirection);
                //Console.WriteLine("Movement Y" + item.Ydirection);
                if (item.Inventory.ElementAt(0) == 1)
                {
                    Console.WriteLine("Keys:  " + item.Inventory.ElementAt(0));
                    Console.WriteLine("Phone: " + item.Inventory.ElementAt(1));
                    Console.WriteLine("Cash:  " + item.Inventory.ElementAt(2));
                    Console.WriteLine("Watch: " + item.Inventory.ElementAt(3));
                }
                if (item.Inventory.ElementAt(0) == 0)
                {
                    Console.WriteLine("Keys:  " + item.Inventory.ElementAt(0));
                    Console.WriteLine("Phone: " + item.Inventory.ElementAt(1));
                    Console.WriteLine("Cash:  " + item.Inventory.ElementAt(2));
                    Console.WriteLine("Watch: " + item.Inventory.ElementAt(3));
                }
            }
        }
        private void Movement() //BETA; Testar än så länge en metod som förflyttar via knapptryck; målet är en loop som automatiserar rörelse
        {
            int redo = 0;
            int x = 20;
            int y = 20;
            ConsoleKeyInfo Keyinfo;
            do
            {
                Keyinfo = Console.ReadKey(true);
                Console.Clear();

                switch (Keyinfo.Key) //Crashar ifall värdet blir -1; då det räknas som utanför consolefönstret
                {                    //Behöver en bestämd Buffer Size till Consolefönstret för att göra det optimalt (System.ArgumentOutofRangeException)

                    case ConsoleKey.RightArrow:
                        x++;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("Penislord");
                        break;

                    case ConsoleKey.LeftArrow:
                        x--;
                        if (x < 0)
                        {
                            x++;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("Penislord");
                        break;

                    case ConsoleKey.UpArrow: //Y går i motsatt riktning
                        y--;
                        if (y < 0)
                        {
                            y++;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("Penislord");
                        break;

                    case ConsoleKey.DownArrow: //Y går i motsatt riktning
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("Penislord");
                        break;
                }


            } while (redo == 0);
        }
        internal void Run() //Huvudmetod; Main hänvisas hit där alla metoder körs.
        {
            Generate();
            Movement();
        }
    }
}
