using System;

namespace freetime_simulator
{
    class Book : Media
    {
        string  name;
        int     nrOfPages;
        string  author;

        public Book(string bookName, int nrOfPages, string bookAuthor)
        {
            this.name       = bookName;
            this.nrOfPages  = nrOfPages;
            this.author     = bookAuthor; 
        }

        public override bool ConsumeMedia(Person testSubject, ref int timeLeft)
        {
            int readingTIme = CalculateTimeToReadBook(testSubject.PagesPerMinute);
            if(timeLeft > readingTIme) {
                timeLeft -= readingTIme;
                return true;
            }
            
            return false;
        }

        private int CalculateTimeToReadBook(int ppm)
        {
            return nrOfPages / ppm;
        }
        
        public override void PrintMediaInformation()
        {
            Console.WriteLine("  - {0} by {1} - Pages: {2}", name, author, nrOfPages);
        }
    }
}
