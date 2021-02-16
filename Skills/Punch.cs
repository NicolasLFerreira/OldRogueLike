using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;

namespace RogueLike.Skills
{
    class Punch : BaseSkill
    {
        public Punch(MapEntity user) : base(user)
        {
            Cost = 0;
        }

        public override void Cast(MapEntity target) => target.Hp -= User.Atk - target.Defense;
    }
}