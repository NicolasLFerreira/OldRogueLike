using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items
{
    class Armor : Item
    {
        public Armor(string name, byte level) : base(name, level)
        {
            Type = 1;
        }

        public int Vitality { get; set; }
        public int Defense { get; set; }
        public int Mana { get; set; }
    }
}
