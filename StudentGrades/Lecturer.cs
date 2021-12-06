using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class Lecturer
    {
       public string lecturerName;
        public string studentName;
        public string taz;
        public List <int> Grades;

       public Lecturer() { }

       public Lecturer(string lecturerName, string studentName, string taz, List<int> Grades)
        {
            this.lecturerName = lecturerName;
            this.studentName = studentName;
            this.taz = taz;
            this.Grades = Grades;
        }
    }
}
