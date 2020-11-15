using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
   
    class Borrow 
    {
        public string Id { get; set; }
        public int Day { get; set; }
        public int BookCount { get; set; }
        public Student Student { get; set; }
        Book[] books;
        
        public Borrow()
        {
            books = new Book[5];
        }
        public Borrow(string id,int day,Student student)
        {
            books = new Book[5];
            Id = id; 
            Day = day; 
            Student = student; 
        }

        public void AddBook(params Book[] books)
        {
            foreach (var a in books)
            {
                if (BookCount < 5)
                {
                    this.books[BookCount++] = a;
                }
                
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("ID : " + Id);
            for (int i = 0; i < BookCount; i++) books[i].ShowInfo();
            
        }
    }
}
