using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Turco
{
    internal class Student
    {
            private static int _Id = 1;
            public int Id { get; set; }
            public string Fullname { get; set; }
            public double Point { get; set; }


            public Student(string fullname, double point)
            {
                Fullname = fullname;
                Point = point;
                Id = _Id++;
            }

    }
}
