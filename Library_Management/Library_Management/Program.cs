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
            Library l1 = new Library("AIUB", "Kuratoli");

            Book b1 = new Book("HP1", "JK Rowling", "1001", "Fiction", 10);
            Book b2 = new Book("HP2", "JK Rowling", "1002", "Fiction", 10);
            l1.AddNewBook(b1, b2);
            Student s1 = new Student("Sadman", "101", "CSE", 3.5f);
            Borrow br1 = new Borrow("01", 1, s1);
            Borrow br2 = new Borrow("02", 2, s1);
         //   l1.ShowAllBooks();
           var temp= l1.SearchBook("1001");
            if (temp != null) l1.AddNewBookCopy(temp, 10);
           // l1.ShowAllBooks();
            /////////////////////////
            s1.AddBorrow(br1);
            br1.AddBook(b1);
            s1.AddBorrow(br2);
            //s1.ShowAllBorrows();
            l1.AddBorrow(br1);
            l1.AddBorrow(br2);
            //l1.ShowAllBorrows();


        }
    }
}
