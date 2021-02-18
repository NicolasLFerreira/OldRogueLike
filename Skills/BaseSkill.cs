using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;

namespace RogueLike.Skills
{
    class BaseSkill
    {
        // Skills are anything combat related that affects the stats
        // Damage, self healing and effects are all used here

        public BaseSkill(Entity user) => User = user; // Sets the caster and cost
        public Entity User { get; set; } // The entity that is using the skill
        public int Cost { get; set; } // MP cost for casting the skill

        // Override this method and write the skill code
        virtual public void Action(Entity target)
        {
            throw new NotImplementedException();
        }
    }
}
