using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Entities;
using RogueLike.Items;

namespace RogueLike
{
    class Program
    {
        static void Main()
        {
            Inventory inv = new Inventory();

            inv.AddItem(new Item("as"));
            Console.ReadKey();
        }
    }
}