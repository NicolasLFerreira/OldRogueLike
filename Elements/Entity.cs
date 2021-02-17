using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Items;
using RogueLike.Skills;

namespace RogueLike.Elements
{
    class Entity : MapElement
    {
        public Entity(string name, int id, char icon, int vitality, int attack, int defense, int speed) : base(name, id, icon)
        {
            // Sets the base value for the stats
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
            Speed = speed;

            // Sets other values

            EquippedItems = new Inventory(7);
            ItemInventory = new Inventory(9);

            SkillSet = new BaseSkill[3];
        }

        /*
         * Base stats: The base values that and effects will be applied to
         * Vitality, Attack, Defense and Speed
         */

        public readonly int Vitality; // Defines the maximun Hp one can have (times 5)
        public readonly int Attack;   // Base damage
        public readonly int Defense;  // Base damage reduction
        public readonly int Speed;    // Base speed
        public readonly int Mana;     // Total mana

        public int Hp { get; set; }  // Current life
        public int Atk { get; set; } // The amount of damage you will do to the enemy
        public int Def { get; set; } // The amount of damage you will absorb
        public int Spd { get; set; } // Higher speed will attack first
        public int Mp { get; set; }  // Current mana

        public Inventory EquippedItems { get; set; } // Items currently being used
        public Inventory ItemInventory { get; set; } // Items the Entity has stored
        public BaseSkill[] SkillSet { get; set; } // Skills the Player can use

        public void SetSkill(int id)
        {
            SkillSet[0] = new FireBall(this);
            SkillSet[1] = new Heal(this);
        }

        public void CastSkill(int id)
        {

        }
    }
}
