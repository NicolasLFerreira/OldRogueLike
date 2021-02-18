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
            Entity a = new Entity("person", 0, '@', 10, 10, 10, 10);

            Inventory b = new Inventory(9);

            b.Add(new Item("sword"));

            Console.WriteLine(b[0].Name);

            Console.WriteLine(Console.ReadKey().Key);

            Console.ReadKey();
        }
    }
}