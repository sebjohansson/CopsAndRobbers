using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopsAndRobbers
{
    class Town
    {
        List<Person> townsimulation = new List<Person>();
        Random rnd = new Random();


        protected static int townwidth = 101;
        protected static int townheight = 26;

        private void Declare_Value()
        {
            for (int i = 0; i < 100; i++) //Randomizar följande int/floats som appliceras individuellt för varje person, upp till 100
            {
                int generate_person = rnd.Next(0, 3);
                int generate_startpos_x = rnd.Next(0, 100);
                int generate_startpos_y = rnd.Next(0, 25);
                int[] citizen_inventory = { 1, 1, 1, 1 };
                int[] empty_inventory = { 0, 0, 0, 0 };

                switch (generate_person) //Ändrade från If{} till switch{case}
                {
                    case 0:
                        townsimulation.Add(new Citizen(generate_startpos_x, generate_startpos_y, citizen_inventory));
                        break;

                    case 1:
                        townsimulation.Add(new Robber(generate_startpos_x, generate_startpos_y, empty_inventory));
                        break;

                    case 2:
                        townsimulation.Add(new Police(generate_startpos_x, generate_startpos_y, empty_inventory));
                        break;
                }
            }
        }
            private void Generate_Townspeople() //WIP; Använder MovementBETA som mall
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MOVEMENT WIP");
            Console.ForegroundColor = ConsoleColor.Gray;
            int count = 0;


            foreach (var item in townsimulation) //Genererar visuella bokstäver just nu; men saknar rörelse
            {

                if (item is Police)
                {

                    Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("P");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                if (item is Robber)
                {
                    Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("R");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                if (item is Citizen)
                {
                    Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("C");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                count++;
            }

            while (true)
            {
                
                int x = 1;
                int y = 1;
                Console.CursorLeft = x;
                Console.CursorTop = y;
                foreach (var item in townsimulation)
                {
                    Random randMove = new Random();
                    int random = randMove.Next(0, 4);
                    if (item is Police)
                    {

                        //Old Position
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                        Console.WriteLine(" ");


                        //New Position
                        if (random == 0)
                        {
                            townsimulation[count].XPosition++;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 100;
                            }
                            if (townsimulation[count].XPosition > 100)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        else if (random == 1)
                        {
                            townsimulation[count].XPosition--;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 100;
                            }
                            if (townsimulation[count].XPosition > 100)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        else if (random == 2)
                        {
                            townsimulation[count].YPosition++;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 25;
                            }
                            if (townsimulation[count].XPosition > 25)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        if (random == 3)
                        {
                            townsimulation[count].YPosition--;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 25;
                            }
                            if (townsimulation[count].XPosition > 25)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }


                        Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("P");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        //Collision


                    }

                    if (item is Robber)
                    {
                        //Old Position
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                        Console.WriteLine(" ");


                        //New Position
                        if (random == 0)
                        {
                            townsimulation[count].XPosition++;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 100;
                            }
                            if (townsimulation[count].XPosition > 100)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        else if (random == 1)
                        {
                            townsimulation[count].XPosition--;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 100;
                            }
                            if (townsimulation[count].XPosition > 100)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        else if (random == 2)
                        {
                            townsimulation[count].YPosition++;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 25;
                            }
                            if (townsimulation[count].XPosition > 25)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        if (random == 3)
                        {
                            townsimulation[count].YPosition--;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 25;
                            }
                            if (townsimulation[count].XPosition > 25)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }


                        Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("R");
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }

                    if (item is Citizen)
                    {

                        //Old Position
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                        Console.WriteLine(" ");


                        //New Position
                        if (random == 0)
                        {
                            townsimulation[count].XPosition++;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 100;
                            }
                            if (townsimulation[count].XPosition > 100)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        else if (random == 1)
                        {
                            townsimulation[count].XPosition--;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 100;
                            }
                            if (townsimulation[count].XPosition > 100)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        else if (random == 2)
                        {
                            townsimulation[count].YPosition++;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 25;
                            }
                            if (townsimulation[count].XPosition > 25)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }
                        if (random == 3)
                        {
                            townsimulation[count].YPosition--;
                            if (townsimulation[count].XPosition < 0)
                            {
                                townsimulation[count].XPosition = 25;
                            }
                            if (townsimulation[count].XPosition > 25)
                            {
                                townsimulation[count].XPosition = 0;
                            }
                        }


                        Console.SetCursorPosition(townsimulation[count].XPosition, townsimulation[count].YPosition);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("C");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    count++;
                }
            }
        }
        internal void Run() //Huvudmetod; Main hänvisas hit där alla metoder körs.
        {

            Declare_Value();
            //Show_Inventory();
            Generate_Townspeople();

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                //Movement_Townspeople();
                Thread.Sleep(64);
            }
        }
    }
}
