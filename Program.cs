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
            Inventory a = new Inventory(9);

            a.Add(new Item("Dragon Slayer", 23));
            a.Add(new Item("Dark sword", 23));
            a.Add(new Item("Mjolnir", 23));
            a.Add(new Item("Godly glaive", 23));

            Console.WriteLine(a.Count);
            Console.WriteLine(a[3].Name);

            Console.ReadKey();
        }
    }
}