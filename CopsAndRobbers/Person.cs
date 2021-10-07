using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsAndRobbers
{
    class Person
    {
        internal int Startpos_X { get; set; }
        internal int Startpos_Y { get; set; }

        internal double Xdirection { get; set; }
        internal double Ydirection { get; set; }

        internal int[] Inventory = { 1, 1, 1, 1 };

        internal Person(int startposx, int startposy, float xdirection, float ydirection, int[] inventory)
        {
            Startpos_X = startposx;
            Startpos_Y = startposy;
            Xdirection = xdirection;
            Ydirection = ydirection;
            Inventory = inventory;
        }
    }

    class Citizen : Person
    {
        internal Citizen(int startposx, int startposy, float xdirection, float ydirection, int[] inventory)
            : base(startposx, startposy, xdirection, ydirection, inventory)
        {
        }

    }

    class Robber : Person
    {
        internal Robber(int startposx, int startposy, float xdirection, float ydirection, int[] inventory)
    : base(startposx, startposy, xdirection, ydirection, inventory)
        {
        }
    }

    class Police : Person
    {
        internal Police(int startposx, int startposy, float xdirection, float ydirection, int[] inventory)
    : base(startposx, startposy, xdirection, ydirection, inventory)
        {
        }
    }
}
