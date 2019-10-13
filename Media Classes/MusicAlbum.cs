using System;

namespace freetime_simulator
{
    class MusicAlbum : Media
    {
        string  name;
        string  artist;
        int     lengthASide;
        int     lengthBSide;
        
        public MusicAlbum(string albumName, string albumArtist, int lengthASide, int lengthBSide)
        {
            
            this.name           = albumName;
            this.artist         = albumArtist;
            this.lengthASide    = lengthASide;
            this.lengthBSide    = lengthBSide;
        }

        public override bool ConsumeMedia(Person testSubject, ref int timeLeft)
        {
            if(timeLeft > (lengthASide + lengthBSide)) {
                timeLeft -= (lengthASide + lengthBSide);
                return true;
            }
            
            return false;
        }

        public override void PrintMediaInformation()
        {
            Console.WriteLine("  - {0} by {1} - Length: A side: {2}min | B side: {3}min ", name, artist, lengthASide, lengthBSide);
        }
    }
}
