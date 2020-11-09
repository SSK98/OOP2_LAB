using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Information \n \n ");
            
            Student s = new Student("Sadman", "01", "CSE", 3);

            s.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Account Information \n \n");
           
            Account a = new Account();
            Console.WriteLine();
            Console.WriteLine();
            Student s = new Student("Sadman", "0001", "CSE",3);

            s.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Account Information");
            Console.WriteLine();
            Console.WriteLine();
             a = new Account("Sadman","1212",11000);
            a.ShowInfo();
            a.Transfer(1000, "1212");
            Console.WriteLine();
            Console.WriteLine("Book Information");
            Console.WriteLine();
            Console.WriteLine();
            Book b = new Book("HP", "JKR", "001","Ad",3);
            b.ShowInfo();
            Library l = new Library("GK", "Dhaka", 1200);
            Console.WriteLine();
            Console.WriteLine();
            l.AddNewBook(b);
            Console.WriteLine();
            Console.WriteLine("Added Book Information");
            l.ShowLibInfo();
            Console.WriteLine();
            Console.WriteLine();
            b.ShowAllBooks(l);
            Console.WriteLine();
            Console.WriteLine("List of all book information");
            b.ShowInfo();
            Console.WriteLine();
            Console.WriteLine();
            Borrow bor = new Borrow("Borrowed", "HP2", "JKR", "002", "Ad", 100);
            bor.ShowBorrowedBookInfo();
            bor.ShowStudentNameAndBookInfo(b);
            a.ShowInfo();
            a.Transfer(1000, "1212");
            Console.WriteLine();
            Console.WriteLine("Book Information");
            Console.WriteLine();
            Console.WriteLine();
            Book b = new Book("HP", "JKR", "001", "Ad", 3);
            b.ShowInfo();
            Library l = new Library("GK", "Dhaka", 1200);
            Console.WriteLine();
            Console.WriteLine();
            l.AddNewBook(b);
            Console.WriteLine();
            Console.WriteLine("Added Book Information");
            l.ShowLibInfo();
            Console.WriteLine();
            Console.WriteLine();
            b.ShowAllBooks(l);
            Console.WriteLine();
            Console.WriteLine("List of all book information");
            b.ShowInfo();
            Console.WriteLine();
            Console.WriteLine();
            Borrow bor = new Borrow("Borrowed", "HP2", "JKR", "002", "Ad", 100);
            bor.ShowBorrowedBookInfo();
            bor.ShowStudentNameAndBookInfo(b);
        }
    }
}
