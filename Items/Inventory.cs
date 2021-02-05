using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items
{
    class Inventory
    {
        private Item[] Items = new Item[9];
        private int NextSlot { get; set; }


        // Adds an Item to the Items array. Returns true if the action is succesful, and false if not
        public bool AddItem(Item item)
        {
            if (NextSlot < 9) Items[NextSlot++] = item;
            else return false;
            return true;
        }

        public bool GetItem(int index)
        {
            if (index > 9 || index < 1 || Items[index] != null) return false;
        }
    }
}