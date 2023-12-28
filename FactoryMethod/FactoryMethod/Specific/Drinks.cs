﻿using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Specific
{
    internal class Drinks : Factory
    {
        public override IDepartment ProduceProduct()
        {
            return new SoftDrink();
        }
    }
}
