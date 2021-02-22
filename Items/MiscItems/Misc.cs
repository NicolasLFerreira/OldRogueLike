using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items.MiscItems
{
    class Misc : Item
    {
        public Misc(string name) : base(name)
        {
            Type = 3;
        }
    }
}
