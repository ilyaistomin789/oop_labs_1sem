﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_12
{
    public sealed class Flower : Plants
    {
        public Flower(string name, string family, string kingdom)
        {
            Name = name;
            Family = family;
            Kingdom = kingdom;
        }
    }
}
