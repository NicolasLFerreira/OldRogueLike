using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Items;

namespace RogueLike.Elements
{
    class Player : Element
    {
        public Player(string name, char icon) : base(name, icon)
        {
            Equipped = new Inventory(3);
            Storage = new Inventory(9);
        }

        // Dependecies

        public Inventory Equipped { get; set; }
        public Inventory Storage { get; set; }

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

        public int[] Move()
        {
            char input = Console.ReadKey().KeyChar;

            switch (input)
            {
                default:
                    return new int[] { 0, 0 };
                case 'a':
                    return new int[] { 0, -1 };
                case 'd':
                    return new int[] { 0, 1 };
                case 'w':
                    return new int[] { -1, 0 };
                case 's':
                    return new int[] { 1, 0 };
            }
        }
    }
}