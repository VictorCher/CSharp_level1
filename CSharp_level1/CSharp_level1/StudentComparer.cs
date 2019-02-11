using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    class StudentComparer<Sudent>
    {
        public int CompareAge(Student p1, Student p2)
        {
            if (p1.age > p2.age)
                return 1;
            else if (p1.age < p2.age)
                return -1;
            else
                return 0;
        }
        public int CompareCourse(Student p1, Student p2)
        {
            if (p1.course > p2.course)
                return 1;
            else if (p1.course < p2.course)
                return -1;
            else
                return 0;
        }
    }
}
