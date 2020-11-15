using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{

    class Student
    {
        string name;
        private float cgpa;
        private string id;
        private string department;
        private int borrowCount;
        Borrow[] borrows;

        

        public int BorrowCount
        {
            get { return borrowCount; }
            set { borrowCount = value; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
       
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

    
      
        public Student()
        {

            borrows = new Borrow[100];


        }

        public Student(string name, string id, string department, float cgpa)
        {
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
            this.department = department;
            borrows = new Borrow[100];
       
       
        }
        public void AddBorrow(Borrow borrow)
        {
            borrows[borrowCount++] = borrow;
        }
        public void ShowAllBorrows()
        {
            ShowInfo();
            for (int i = 0; i < borrowCount; i++)
            {
                
                borrows[i].ShowInfo();
            }
        }


        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }
        

    }
}


