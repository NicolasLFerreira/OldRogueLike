﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items
{
    class Equipment : Item
    {
        public Equipment(string name, byte level) : base(name)
        {
            Level = level;
        }
        public byte Level { get; set; }
    }
}