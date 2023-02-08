using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    internal class Product
    {
        public string Name;
        protected double _price;
        private double _discountPercent;
        public double DiscountPercent
        {
            get
            {
                return _discountPercent;
            }
            set
            {
                if(value>=0 && value<=100)
                    _discountPercent = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value>=0)
                {
                    _price = value;
                }
            }
        }

        public void SetPrice(double price)
        {
            if (price >= 0)
            {
                _price = price;
            }
        }

        public double GetPrice()
        {
            return _price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {_price}");
        }
    }

}
