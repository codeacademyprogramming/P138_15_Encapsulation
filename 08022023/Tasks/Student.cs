using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Student:Human
    {
        public Student()
        {
            _age = 15;
        }
        public string GroupNo;

        public override byte Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value >= 15 && value <= 65)
                    _age = value;
            }
        }
    }
}
