using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Klass
    {
        public List<Student> Students { get; set; }

        //empty constructor
        public Klass() { } 

        //full constructor
        public Klass(List<Student> students)
        {
            this.Students = students;
        }
    }
}
