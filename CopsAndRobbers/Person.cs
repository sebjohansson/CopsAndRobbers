using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsAndRobbers
{
    class Person //Superclass
    {
        internal int XPosition { get; set; }
        internal int YPosition { get; set; }
        internal int[] Inventory = { 1, 1, 1, 1 };
        internal Person(int xposition, int yposition, int[] inventory)
        {
            XPosition = xposition;
            YPosition = yposition;
            Inventory = inventory;
        }
    }

    class Citizen : Person
    {
        internal Citizen(int xposition, int yposition, int[] inventory)
            : base(xposition, yposition, inventory)
        {
            XPosition = xposition;
            YPosition = yposition;

            Inventory = inventory;
        }

    }

    class Robber : Person
    {
        internal Robber(int xposition, int yposition, int[] inventory)
            : base(xposition, yposition, inventory)
        {
            XPosition = xposition;
            YPosition = yposition;

            Inventory = inventory;
        }
    }

    class Police : Person
    {
        internal Police(int xposition, int yposition, int[] inventory)
            : base(xposition, yposition, inventory)
        {
            XPosition = xposition;
            YPosition = yposition;

            Inventory = inventory;
        }
    }


}
