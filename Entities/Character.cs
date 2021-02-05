using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Entities
{
    public class Character : MapElement
    {
        public Character()
        {

        }
        public Character(string name, int id, char icon, bool hasCollision, int vitality, int attack, int defense, int speed, int vitalityMult, int attackMult, int defenseMult, int speedMult) :
            base(name, id, icon, hasCollision)
        {
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }

        // The base stats of the entities, only modified by level ups and other initial custom multipliers
        public readonly int Vitality; // Max health
        public readonly int Attack; // Base raw attack
        public readonly int Defense; // Base raw defense
        public readonly int Speed; // Base raw speed

        // The multiplier that is applied to every final stat calculation
        private readonly int AttackMultiplier;
        private readonly int DefenseMultiplier;
        private readonly int SpeedMultiplier;

        // The stats affected by multipliers, items and effects
        public int HP { get; protected set; } // Your current health
        public int ATK { get; protected set; } // Attack final product with items and effects
        public int DEF { get; protected set; } // Defense final product with items and effects
        public int SPD { get; protected set; } // Speed final product with items and effects

        public void UpdatedStats()
        {
            
        }
    }
}
