using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Entities
{
    class MapElement
    {
        public MapElement(string name, int id, char icon)
        {
            Name = name;
            Id = id;
            Icon = icon;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public char Icon { get; set; }
    }
}
