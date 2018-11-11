using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Klass
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        //empty constructor
        public Klass() { } 

        //full constructor
        public Klass(Teacher teacher, List<Student> students)
        {
            this.Teacher = teacher;
            this.Students = students;
        }
    }
}
