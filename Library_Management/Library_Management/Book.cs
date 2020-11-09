using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    
        class Book
        {
            string bookName;
            public string BookName
            {
                set { bookName = value; }
                get { return bookName; }
            }
            private string bookAuthor;
            public string BookAuthor
            {
                get { return bookAuthor; }
                set { bookAuthor = value; }
            }
            private string bookId;

            public string BookId
            {
                get { return bookId; }
                set { bookId = value; }
            }
            private string bookType;

            public string BookType
            {
                get { return bookType; }
                set { bookType = value; }
            }

            private int bookCopy;

            public int BookCopy
            {
                get { return bookCopy; }
                set { bookCopy = value; }
            }
         
            private Library[] accounts;
            private int bookCount;
            public int BookCount
            {
                get { return bookCount; }
                set { bookCount = value; }
            }
            public Book()
            {
                accounts = new Library[10];
                bookCount = 0;
                Console.WriteLine("Book Default");
            }
            public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
            {
                this.bookName = bookName;
                this.bookAuthor = bookAuthor;
                this.bookId = bookId;
                this.bookType = bookType;
                this.bookCopy = bookCopy;
                Console.WriteLine("Book Valued Constructor");
                accounts = new Library[10];
                bookCount = 0;
            }
            public void ShowAllBooks(params Library[] accounts)
            {
                foreach (var acc in accounts)
                {
                    if (bookCount < 10)
                    {
                        this.accounts[bookCount++] = acc;
                        Console.WriteLine("List of all books");
                    }
                    else
                    {
                        Console.WriteLine("Cannot Add Book:  " + acc.TotalBook);
                    }
                }
            }
       
            public void ShowInfo()
            {
                Console.WriteLine("Book Name: " + bookName);
                Console.WriteLine("Book Author: " + bookAuthor);
                Console.WriteLine("Book ID: " + bookId);
                Console.WriteLine("Book Type : " + bookType);
            }

        }
    
}
