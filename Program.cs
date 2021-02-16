using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;
using RogueLike.Items;
using RogueLike.Skills;

namespace RogueLike
{
    class Program
    {
        static void Main()
        {
            BaseInventory a = new BaseInventory(9)
            {
                new Item("Dragon Slayer", 23),
                new Item("Dark sword", 23),
                new Item("Mjolnir", 23),
                new Item("Godly glaive", 23)
            };

            Console.WriteLine(a.Count);
            Console.WriteLine(a[5].Name);

            Console.ReadKey();
        }
    }
}