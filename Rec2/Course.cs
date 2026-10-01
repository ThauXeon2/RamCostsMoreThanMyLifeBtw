using System;
using System.Collections.Generic;
using System.Text;

namespace Rec2
{
    record Course(string Name, string Category, string Teacher)
    {
        private int _price;
        private int _studentCount;
        public void AddStudent(int count) => _studentCount += count;
        public int Money() => _studentCount* _price;
    }
}
