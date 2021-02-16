﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Items;
using RogueLike.Skills;

namespace RogueLike.Elements
{
    class MapEntity : MapElement
    {
        public MapEntity(string name, int id, char icon, int vitality, int attack, int defense, int speed) : base(name, id, icon)
        {
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }

        /*
         * Base stats: The base values that and effects will be applied to
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

        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spd { get; set; }
        public int Mp { get; set; }

        public BaseInventory Inventory { get; set; }
        public BaseSkill SkillSet { get; set; }

        public void ReceiveDamage(int amount) => Hp -= amount;
    }
}
