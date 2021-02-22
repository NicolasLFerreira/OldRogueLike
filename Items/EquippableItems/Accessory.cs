using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items.EquippableItems
{
    class Accessory : Equipment
    {
        public Accessory(string name, byte level) : base(name, level)
        {
            Type = 2;
        }

        public int Vitality { get; protected set; }
        public int Attck { get; protected set; }
        public int Mana { get; protected set; }
    }
}
