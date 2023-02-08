using System;
using System.Collections.Generic;
using System.Text;
using Lesson1;

namespace Lesson
{
    internal class Drink:Product
    {
        public double AlcoholPercent;

        public override double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 3)
                {
                    _price = value;
                }
            }
        }
    }
}
