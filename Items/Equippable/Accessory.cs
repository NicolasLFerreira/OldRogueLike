using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items
{
    class Accessory : Equipment
    {
        public Accessory(string name, byte level) : base(name, level)
        {
            Type = 2;
        }

        public int Vitality { get; set; }
        public int Attck { get; set; }
        public int Mana { get; set; }
    }
}
