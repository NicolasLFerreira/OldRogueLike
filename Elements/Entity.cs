using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Elements
{
    class Entity : Element
    {
        public Entity(string name, char icon) : base(name, icon)
        { 
        }

        // Base stats

        public readonly int Vitality;
        public readonly int Attack;
        public readonly int Defense;
        public readonly int Speed;
        public readonly int Mana;

        // Stats

        public int HP { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spd { get; set; }
        public int Mp { get; set; }
    }
}
