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
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;

        public string BookName
            {
                set { bookName = value; }
                get { return bookName; }
            }
            
            public string BookAuthor
            {
                get { return bookAuthor; }
                set { bookAuthor = value; }
            }
            

            public string BookId
            {
                get { return bookId; }
                set { bookId = value; }
            }
            

            public string BookType
            {
                get { return bookType; }
                set { bookType = value; }
            }


            public int BookCopy
            {
                get { return bookCopy; }
                set { bookCopy = value; }
            }
            
            public void AddBookCopy(int copy)
        {
            bookCopy += copy;
        }


            public Book() { 
            
                bookCopy = 0;
            }
            public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
            {
                this.bookName = bookName;
                this.bookAuthor = bookAuthor;
                this.bookId = bookId;
                this.bookType = bookType;
                this.bookCopy = bookCopy;
               
            }
           
       
            public void ShowInfo()
            {
                Console.WriteLine("Book Name: " + bookName);
                Console.WriteLine("Book Author: " + bookAuthor);
                Console.WriteLine("Book ID: " + bookId);
                Console.WriteLine("Book Type : " + bookType);
                Console.WriteLine("Book Copy : " + bookCopy);
            }

        }
    
}
