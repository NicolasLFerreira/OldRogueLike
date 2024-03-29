﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Items;

namespace RogueLike.Graphics
{
    class PrintInventory
    {
        static public void PrintContent(Inventory targetInventory)
        {
            Console.WriteLine($"Empty slots: {targetInventory.Cap - targetInventory.Count}");
            Console.WriteLine($"Used slots: {targetInventory.Count}\n");

            for (int i = 0; i < targetInventory.Cap; i++)
            {
                // Changes the color that the item name and icon is written in according to its type.
                //if (targetInventory[i].Type != -1)
                //    Console.ForegroundColor = (ConsoleColor)(int)((targetInventory[i].Type + 2 * 6) % 15);
                //else Console.ResetColor();

                if (targetInventory[i].Type == -1) Console.WriteLine($"- {i + 1}: EMPTY");
                else Console.WriteLine($"- {i + 1}: {targetInventory[i].Name} : {targetInventory[i].Icon}");
            }
        }
    }
}
