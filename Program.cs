using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;
using RogueLike.Items;
using RogueLike.Graphics;

namespace RogueLike
{
    class Program
    {
        static void Main()
        {
            Inventory a = new Inventory(9)
            {
                new Item("Steel Sword", 0, "-|==>")
            };

            PrintInventory i = new PrintInventory(a);
            i.PrintContent();

            Console.ReadKey();
        }
    }
}