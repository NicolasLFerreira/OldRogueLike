using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Entities
{
    class MapEntity : MapElement
    {
        public MapEntity(string name, int id, char icon, int vitality, int attack, int defense, int speed, int mAtk, int mDef, int mSpd) : base(name, id, icon)
        {
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
            Speed = speed;

            MultAttack = mAtk;
            MultDefense = mDef;
            MultSpeed = mSpd;
        }

        /*
         * Base stats: The base values that multipliers and effects will be applied to
         * Vitality, Attack, Defense and Speed;
         * 
         * Final product stats: with multipliers and effects applied
         * Hp: current life;
         * Atk: the amount of damage you will do to the enemy;
         * Def: the amount of damage you will absorb;
         * Spd: higher speed will attack first;
         */

        public readonly int Vitality;
        public readonly int Attack;
        public readonly int Defense;
        public readonly int Speed;
        public readonly int Mana;

        private readonly int MultAttack;
        private readonly int MultDefense;
        private readonly int MultSpeed;

        public int Hp { get; protected set; }
        public int Atk { get; protected set; }
        public int Def { get; protected set; }
        public int Spd { get; protected set; }
        public int Man { get; protected set; }

        
    }
}
