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
            Player n = new Player("Nicolas", '@');

            n.Storage.Add(new Item("Sword"));
            n.Storage.Add(new Item("Spear"));
            n.Storage.Add(new Item("Hammer"));
            n.Storage.Add(new Item("Staff"));

            PrintInventory.PrintContent(n.Storage);

            n.Storage.RemoveAt(0);

            PrintInventory.PrintContent(n.Storage);

            Console.ReadKey();
        }
    }
}