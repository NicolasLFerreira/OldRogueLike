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
        public BaseSkill(MapEntity user) // Sets the caster and cost
        {
            User = user;
        }

        public MapEntity User { get; set; }
        public int Cost { get; set; }

        virtual public void Cast(MapEntity target)
        {
            throw new NotImplementedException();
        }
    }
}
