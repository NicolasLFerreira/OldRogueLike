using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;

namespace RogueLike.Skills
{
    class Heal : BaseSkill
    {
        public Heal(MapEntity user) : base(user)
        {
            Cost = 5;
        }

        public override void Cast(MapEntity target)
        {
            if (User.Hp < User.Vitality * 5) User.Hp += User.Vitality;

            if (User.Hp > User.Vitality * 5) User.Hp = User.Vitality;
        }
    }
}
