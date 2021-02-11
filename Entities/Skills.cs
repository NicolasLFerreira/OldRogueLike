using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Entities
{
    class Skills
    {
        MapEntity User { get; set; }

        int[] ChosenSkills = new int[3];
        
        public int CastSkills(MapEntity caster, MapEntity target, int type, int id)
        {
            if (type == 0) // Offense
            {
                switch (id)
                {
                    default:
                        return 0;
                    case 0: // Basic attack
                        return 0;
                }
            }

            if (type == 1) // Defense
            {
                switch (id)
                {
                    default:
                        return 0;
                    case 0:
                        return 0;
                }
            }

            if (type == 2) // Support
            {
                switch (id)
                {
                    default:
                        return 0;
                    case 0:
                        return 0;
                }
            }
            return 0;
        }
    }
}
