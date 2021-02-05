using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Entities
{
    public class MapElement
    {
        public MapElement()
        {

        }

        public MapElement( string name, int id, char icon, bool hasCollision)
        {
            Name = name;
            Id = id;
            Icon = icon;
            HasCollision = hasCollision;
        }

        // Every element will have a name (walls, trees, monsters, etc...)
        public string Name { get; private set; }

        // Every object of a MapElement will have an unique Id according to their type, like unique entity id, map object id, etc...
        public int Id { get; private set; }

        // The char representing the map element
        public char Icon { get; private set; }

        // If the element can be walked over, like floor or small enemies
        public bool HasCollision { get; private set; }
    }
}