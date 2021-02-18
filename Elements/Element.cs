using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Elements
{
    public class Element
    {
        public Element(string name, char icon)
        {
            Name = name;
            Icon = icon;

        }

        public string Name { get; set; }
        public char Icon { get; set; }
        public int Type { get; set; }
    }
}
