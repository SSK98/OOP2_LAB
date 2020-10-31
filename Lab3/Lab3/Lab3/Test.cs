using labTask3.student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Test
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "SSK";
            s.Id = "37370";
            s.Department = "CSE";
            s.Cgpa = 3.5f;
            s.ShowInfo();

            Account a = new Account();

            Triangle t = new Triangle();
            t.ShowInfo();

            Course c = new Course();
            c.CourseName = "C#";
            c.CourseCode = "CSC2212";
            c.CourseCredit = 3;
            c.ShowCourseInfo();

        }
    }
}
