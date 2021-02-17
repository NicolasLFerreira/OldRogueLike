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
        public BaseSkill(Entity user) => User = user; // Sets the caster and cost

        public Entity User { get; set; }
        public int Cost { get; set; }

        virtual public void Action(Entity target)
        {
            throw new NotImplementedException();
        }
    }
}
