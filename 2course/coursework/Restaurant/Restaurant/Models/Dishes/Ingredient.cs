﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Ingredient : BaseModel
    {
        public double PricePerOneKilogram { get; private set; }

        public Ingredient(int id, string name, double price) : base(id, name)
        {

        }

        public double GetPrice(Weight weight)
        {
            return (weight.Amount / 1000.0) * PricePerOneKilogram;
        }

        public override string ToString()
        {
            return "Name: " + Name + " | PricePerOneKilogram: " + PricePerOneKilogram;
        }
    }
}