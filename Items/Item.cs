using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items
{
    class Item
    {
        public Item(string name, sbyte type, string icon)
        {
            Name = name;
            Type = type;
            Icon = icon;
        }

        public string Name { get; protected set; }
        public sbyte Type { get; protected set; }
        public string Icon { get; protected set; }
    }
}
