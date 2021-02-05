using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Entities
{
    class Entity : Character
    {
        public Entity(string name, int id, char icon, bool hasCollision, int vitality, int attack, int defense, int speed, int vitalityMult, int attackMult, int defenseMult, int speedMult) : 
            base(name, id, icon, hasCollision, vitality, attack, defense, speed, vitalityMult, attackMult, defenseMult, speedMult)
        { }
    }
}
