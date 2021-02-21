using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Utility
{
    class Input
    {
        public int IntCapturer()
        {
            string input;
            int output;

            input = Console.ReadLine();

            while (!int.TryParse(input, out output))
            {
                Console.Write("\nPlease enter an integer: ");
                input = Console.ReadLine();
            }
            return output;
        }
    }
}
