using System;

namespace freetime_simulator
{
    class Movie : Media
    {   
        public DateTime ReleaseDate { get; }     
        public Movie(int length, string title, DateTime releaseDate) : base(length, title)
        {
            ReleaseDate = releaseDate;
        }

        public override bool MediaPlayable(LivingRoom room)
        {
            // TODO if a DVD and TV exists in the LivingRoom
            return true;
        }

        public override string ToString()
        {
            string str = $"Title: {Title} | Author: {ReleaseDate} | Length: {Length}";
            return str;
        }
    }
}