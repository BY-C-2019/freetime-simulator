using System;

namespace freetime_simulator
{
    class Movie : Media
    {
        string  title;
        string  releaseDate;
        int     length; 

        public Movie(string movieTitle, string releaseDate, int movieLength)
        {
            this.title          = movieTitle;
            this.releaseDate    = releaseDate;
            this.length         = movieLength;
        }
        
        public override bool ConsumeMedia(Person testSubject, ref int timeLeft)
        {
            if(timeLeft > length) {
                timeLeft -= length;
                return true;
            }
            
            return false;
        }

        public override void PrintMediaInformation(ref string textToPrint)
        {
            textToPrint += String.Format("  - {0} - {1}min - Released: {2}\n", title, length, releaseDate);
        }
    }
}
