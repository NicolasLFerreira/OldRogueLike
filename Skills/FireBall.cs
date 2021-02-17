using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;

namespace RogueLike.Skills
{
    class FireBall : BaseSkill
    {
        public FireBall(Entity user) : base(user) => Cost = 0;

        public override void Action(Entity target) => target.Hp -= User.Atk - target.Defense;
    }
}