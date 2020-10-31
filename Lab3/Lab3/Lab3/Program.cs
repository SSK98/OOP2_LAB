using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask3.student
{
    internal class Student
    {
        string name;
        string id;
        string department;
        float cgpa;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { name = value; }
        }
        public string Department
        {
            get { return department; }
            set { name = value; }
        }
        public float Cgpa
        {
            get { return cgpa; }
            set { name = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("id : " + id);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }
    }
}
