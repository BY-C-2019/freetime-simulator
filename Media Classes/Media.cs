using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Media
    {
        static public List<Media> MediaLibrary = new List<Media>();

        static public void AddMediaToLibrary()
        {
            MediaLibrary.Add(new Movie("Die Hard", "30 September 1988", (2*60 + 12)));
            MediaLibrary.Add(new Movie("The Terminator", "8 February 1985", (1*60 + 47)));
            MediaLibrary.Add(new Movie("Love Actually", "21 November 2003", (2*60 + 15)));
            MediaLibrary.Add(new Movie("The Simpsons Movie", "27 July 2007", (1*60 + 27)));

            MediaLibrary.Add(new Book("Harry Potter and the Philosopher's Stone", 223, "J.K. Rowling"));
            MediaLibrary.Add(new Book("The Three Musketeers", 700, "Alexander Dumas"));
            MediaLibrary.Add(new Book("The Hobbit", 310, "J.R.R. Tolkien"));
            MediaLibrary.Add(new Book("Hundraåringen som klev ut genom fönstret och försvann", 404, "Jonas Jonasson"));

            MediaLibrary.Add(new MusicAlbum("Abbey Road", "The Beatles", 25, 22));
            MediaLibrary.Add(new MusicAlbum("Born in the U.S.A.", "Bruce Springsteen", 22, 24));
            MediaLibrary.Add(new MusicAlbum("Waterloo", "ABBA", 19, 19));
            MediaLibrary.Add(new MusicAlbum("Pet Sounds", "The Beach Boys", 18, 17));
        }

        public virtual bool ConsumeMedia(Person testSubject, ref int timeLeft)
        {
            throw new Exception( this.ToString() + "- ConsumeMedia() inte implementerad");
        }
        public virtual void PrintMediaInformation()
        {
            throw new Exception( this.ToString() + "- PrintMediaInformation() inte implementerad");
        }
    }
}
