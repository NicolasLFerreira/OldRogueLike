using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;
using RogueLike.Items;
using RogueLike.Graphics;

using RogueLike.Items.EquippableItems;

namespace RogueLike
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();

            Player n = new Player("Nicolas", '@');

            n.Storage.Add(new Weapon("Sword", 0));
            n.Storage.Add(new Weapon("Spear", 0));
            n.Storage.Add(new Weapon("Hammer", 0));
            n.Storage.Add(new Weapon("Staff", 0));

            PrintInventory.PrintContent(n.Storage);

            n.Storage.RemoveAt(0);

            PrintInventory.PrintContent(n.Storage);

            Console.ReadKey();
        }
    }
}