using System;

namespace freetime_simulator
{
    class Movie : Media
    {   
        public string Director { get; }
        public int ReleaseYear { get; }     
        public Movie(int length, string title, string director, int releaseYear) : base(length, title)
        {
            Director = director;
            ReleaseYear = releaseYear;
        }

        public override bool MediaPlayable(LivingRoom room)
        {
            // TODO if a DVD and TV exists in the LivingRoom
            return true;
        }

        public override string ToString()
        {
            string str = $"Title: {Title} | Director: {Director} | ReleaseYear: {ReleaseYear} | Length: {Length}";
            str += "\n";
            return str;
        }

        
        public static Movie StringToMovie(string[] data)
        {
            Movie movie = new Movie(
                int.Parse(data[3]),
                data[0],
                data[1],
                int.Parse(data[2])
            );
            return movie;
        }
    }
}