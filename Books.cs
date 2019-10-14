using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Book : Media
    {
        public string author;
        public int pages;
        public static List <Book> bookList = new List <Book>();
        public Book(){}
        public Book(string title, string author, int pages)
        {
            this.Title = title;
            this.author = author;
            this.pages = pages;
        }
        public void AddBook()
        {
            //Adds my movies that my experiments can bring.
            var hPATPS = new Book("Harry Potter and the Philosopher's Stone", "J. K. Rowling", 223);
            bookList.Add(hPATPS);
            var hPATCOS = new Book("Harry Potter and the Chamber of Secrets", "J. K. Rowling", 251);
            bookList.Add(hPATCOS);
            var hPATPOA = new Book("Harry Potter and the Prisoner of Azkaban", "J. K. Rowling", 317);
            bookList.Add(hPATPOA);
            var hPATGOF = new Book("Harry Potter and the Goblet of Fire", "J. K. Rowling", 636);
            bookList.Add(hPATGOF);
            var hPATOOTP = new Book("Harry Potter and the Order of the Phoenix", "J. K. Rowling", 766);
            bookList.Add(hPATOOTP);
            var hPATHBP = new Book("Harry Potter and the Half-Blood Prince", "J. K. Rowling", 607);
            bookList.Add(hPATHBP);
            var hPATDH = new Book("Harry Potter and the Deathly Hallows", "J. K. Rowling", 607 );
            bookList.Add(hPATDH);

        }
    }
}