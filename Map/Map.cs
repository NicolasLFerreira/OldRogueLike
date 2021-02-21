using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueLike.Elements;

namespace RogueLike.Map
{
    class Map
    {
        public Map(int x, int y)
        {
            X = x;
            Y = y;
        }

        private Element[,] Matrix { get; set; }
        

        private readonly int X;
        private readonly int Y;

        public void BuildMap()
        {
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    
                }
            }
        }
    }
}