using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class Library
    {
        string libName;
        private int totalBook;
        private int borrowCount;
        private string libAddress;
        private Book[] listOfBook;
        Borrow[] borrows;

        public string LibName
        {
            set { libName = value; }
            get { return libName; }
        }
      
        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

       
        
        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        public int BorrowCount
        {
            get { return BorrowCount; }
            set { BorrowCount = value; }
        }

        public Library()
        {
            totalBook = 0;
            listOfBook = new Book[100];
            borrows = new Borrow[100];
            borrowCount = 0;
        }
        public Library(string libName, string libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            listOfBook = new Book[100];
            totalBook = 0;
            borrowCount = 0;
            borrows = new Borrow[100];
        }
        public void AddNewBook(params Book[] books)
        {
            foreach (var a in books)
            {
                if (totalBook < 100)
                {
                    this.listOfBook[totalBook++] = a;
                    Console.WriteLine("Book Added");
                }
                else
                {
                    Console.WriteLine("Cannot Add Book:  " + a.BookCopy);
                }
            }
        }
        public void DeleteBook(string bid)
        {
           for(int i = 0;i < totalBook;i++)
            {
                if (listOfBook[i].BookId == bid)
                {
                    listOfBook[i] = null;
                    break;
                }
            }
        }
        public void AddNewBookCopy(Book book, int copy)
        {
            book.AddBookCopy(copy);

        }
        public Book SearchBook(string id)
        {
            foreach (var a in listOfBook)
            {
                if (a.BookId == id) return a;
            }
            return null;
        }
        public void ShowAllBooks()
        {
            for(int i = 0; i < totalBook;i++)
            {
                listOfBook[i].ShowInfo();
                Console.WriteLine();
            }
        }
        public void AddBorrow( Borrow borrow)
        {
            borrows[borrowCount++] = borrow;
        }
        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name: " + libName);
            Console.WriteLine("Library Address: " + libAddress);
            Console.WriteLine("Total Books: " + totalBook);
            Console.WriteLine();
        }
        public void ShowAllBorrows()
        {
            for (int i = 0; i < BorrowCount; i++)
            {
                Console.WriteLine("**********STUDENT INFO***********");
                borrows[i].Student.ShowInfo();
                Console.WriteLine("**********Borrow INFO***********");
                borrows[i].ShowInfo();
            }
        }

    }
}
