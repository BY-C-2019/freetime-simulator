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
            MediaLibrary.Add(new Movie("The Avengers", "27 April 2012", (2*60 + 23)));
            MediaLibrary.Add(new Movie("I Am Legend", "25 Januari 2007", (1*60 + 44)));
            MediaLibrary.Add(new Movie("Green Book", "11 September 2018", (1*60 + 44)));
            MediaLibrary.Add(new Movie("Sagan om konungens återkomst", "17 December 2003", (3*60 + 20)));
            MediaLibrary.Add(new Movie("Gudfadern", "27 September 1972", (2*60 + 58)));
            MediaLibrary.Add(new Movie("Nyckeln till frihet", "3 Mars 1995", (2*60 + 22)));
            MediaLibrary.Add(new Movie("Lejonkungen", "18 November 1994", (1*60 + 29)));

            MediaLibrary.Add(new Book("Harry Potter and the Philosopher's Stone", 223, "J.K. Rowling"));
            MediaLibrary.Add(new Book("The Three Musketeers", 700, "Alexander Dumas"));
            MediaLibrary.Add(new Book("The Hobbit", 310, "J.R.R. Tolkien"));
            MediaLibrary.Add(new Book("Hundraåringen som klev ut genom fönstret och försvann", 404, "Jonas Jonasson"));
            MediaLibrary.Add(new Book("Dödssynden", 296, "Harper Lee"));
            MediaLibrary.Add(new Book("Räddaren i nöden", 277, "J.D. Salinger"));
            MediaLibrary.Add(new Book("Stolthet och fördom", 475, "Jane Austen"));
            MediaLibrary.Add(new Book("Nalle Puh", 161, "A.A. Milne"));
            MediaLibrary.Add(new Book("Boktjuven", 584, "Markus Zusak"));

            MediaLibrary.Add(new MusicAlbum("Abbey Road", "The Beatles", 25, 22));
            MediaLibrary.Add(new MusicAlbum("Born in the U.S.A.", "Bruce Springsteen", 22, 24));
            MediaLibrary.Add(new MusicAlbum("Waterloo", "ABBA", 19, 19));
            MediaLibrary.Add(new MusicAlbum("Pet Sounds", "The Beach Boys", 18, 17));
            MediaLibrary.Add(new MusicAlbum("The Dark Side of the Moon", "Pink Floyd", 19, 24));
            MediaLibrary.Add(new MusicAlbum("Bridge over Troubled Water", "Simon & Garfunkel", 17, 20));
            MediaLibrary.Add(new MusicAlbum("Led Zeppelin IV", "Led Zeppelin", 22, 20));
            MediaLibrary.Add(new MusicAlbum("Sticky Fingers", "Rolling Stones", 23, 23));
        }
        /// <summary> Checks if the media can be consumed within the time, if yes consume it</summary>
        public virtual bool ConsumeMedia(Person testSubject, ref int timeLeft)
        {
            throw new Exception( this.ToString() + "- ConsumeMedia() inte implementerad");
        }
        /// <summary> Prints information of the media</summary>
        public virtual void PrintMediaInformation()
        {
            throw new Exception( this.ToString() + "- PrintMediaInformation() inte implementerad");
        }
    }
}
