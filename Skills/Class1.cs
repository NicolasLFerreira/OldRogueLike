using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;

namespace RogueLike.Skills
{
    class Meteor : BaseSkill
    {
        public Meteor(Entity user) : base(user) => Cost = 7;

        public override void Action(Entity target)
        {
            if (target.Mp > 0) target.Mp -= 2;
            if (target.Mp < 0) target.Mp = 0;

            target.Hp -= (User.Atk * User.Def / 2) - User.Defense;
        }
    }
}
