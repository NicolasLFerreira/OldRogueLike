using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items
{
    class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; set; } // Name to be displayed
        public int Id { get; set; } // Type of the item (weapon, armor, etc)
    }
}
