using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Human
    {
        public string Name;
        protected byte _age;

        public virtual byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 150)
                    _age = value;
            }
        }
    }
}
