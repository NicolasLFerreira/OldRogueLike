using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items.EquippableItems
{
    class Weapon : Equipment
    {
        public Weapon(string name, byte level) : base(name, level)
        {
            Type = 0;
        }

        public int Attack { get; set; }
        public int Mana { get; set; }
        public int Speed { get; set; }
    }
}
