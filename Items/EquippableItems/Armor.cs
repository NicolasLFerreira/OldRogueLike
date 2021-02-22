using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items.EquippableItems
{
    class Armor : Equipment
    {
        public Armor(string name, byte level) : base(name, level)
        {
            Type = 1;
        }

        public int Vitality { get; protected set; }
        public int Defense { get; protected set; }
        public int Mana { get; protected set; }
    }
}
