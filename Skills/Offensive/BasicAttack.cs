using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;

namespace RogueLike.Skills.Offensive
{
    class BasicAttack : BaseSkill
    {
        public BasicAttack(MapEntity user, int cost) : base(user, cost) { }

        public MapEntity User { get; set; }
        public int Cost { get; set; }

        public override void Cast(MapEntity target) => target.ReceiveDamage(User.Atk - target.Defense);
    }
}
