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

        public override string ToString()
        {
            string str = "";
            str += $"Type: {GetMediaType()} | ";
            str += $"Title: {Title} | ";
            str += "Director: {Director} | ";
            str += "ReleaseYear: {ReleaseYear} | ";
            str += "Length: {Length}";
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