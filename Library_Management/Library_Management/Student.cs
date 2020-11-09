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
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private Borrow[] accounts;
        private int bookCount;
        public int BookCount
        {
            get { return bookCount; }
            set { bookCount = value; }
        }
        public Student()
        {
            accounts = new Borrow[10];
            bookCount = 0;
            Console.WriteLine("Student Default");
        }

        public Student(string name, string id, string department, float cgpa)
        {
            this.cgpa = cgpa;
            Console.WriteLine("Student Valued Constructor");
            accounts = new Borrow[10];
            bookCount = 0;
        }





        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }
        public void StudentBorrowedBook(params Borrow[] accounts)
        {
            foreach (var acc in accounts)
            {
                if (bookCount < 10)
                {
                    this.accounts[bookCount++] = acc;
                    Console.WriteLine("Book has been Addded");
                }
                else
                {
                    Console.WriteLine("Unable to add Book  " );
                }
            }
        }

    }
}


