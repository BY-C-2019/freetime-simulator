using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Movie : Media
    {
        public string release;
        public int length;
        public static List <Movie> movieList = new List <Movie>();
        public Movie(){}
        public Movie(string title, string release, int length)
        {
            this.Title = title;
            this.release = release;
            this.length = length;
        }
        public void AddMovie()
        {
            //Adds my movies that my experiments can bring.
            var aNewHope = new Movie("A New Hope", "May 25, 1977", 121);
            movieList.Add(aNewHope);
            var goneWithTheWind = new Movie("Gone with the Wind", "December 15, 1939", 221);
            movieList.Add(goneWithTheWind);
            var avengers = new Movie("The Avengers", "May 4, 2012", 143);
            movieList.Add(avengers);
            var toyStory = new Movie("Toy Story", "November 22, 1995", 81);
            movieList.Add(toyStory);
            var jaws = new Movie("Jaws", "June 20, 1975", 124);
            movieList.Add(jaws);
            var raiderLostArk = new Movie("Raiders of the Lost Ark", "June 12, 1981", 115);
            movieList.Add(raiderLostArk);
            var spaceOdyssey = new Movie("2001: A Space Odyssey", "April 3, 1968", 142);
            movieList.Add(spaceOdyssey);
            var ironGiant = new Movie("The Iron Giant", "August 6, 1999", 87);
            movieList.Add(ironGiant);
            var mIFallout = new Movie("Mission: Impossible – Fallout", "July 27, 2018", 147);
            movieList.Add(mIFallout);
            var lotrfotr = new Movie("The Lord of the Rings: The Fellowship of the Ring", "19 December 2001", 178);
            movieList.Add(lotrfotr);
        }

    }
}
