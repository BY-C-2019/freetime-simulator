using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Music : Media
    {
        public string artist;
        public int lengthA;
        public int lengthB;
        public static List <Music> musicList = new List <Music>();
        public Music(){}
        public Music(string title, string artist, int lengthA, int lengthB)
        {
            this.Title = title;
            this.artist = artist;
            this.lengthA = lengthA;
            this.lengthB = lengthB;
        }
        public void AddMusic()
        {
            //Adds my movies that my experiments can bring.
            var rumours = new Music("Rumours", "Fleetwood Mac", 19, 20);
            musicList.Add(rumours);
            var abbeyRoad = new Music("Abbey Road", "The Beatles", 25, 22);
            musicList.Add(abbeyRoad);
            var sPLHCB = new Music("Sgt. Pepper's Lonely Hearts Club Band", "The Beatles", 20, 20);
            musicList.Add(sPLHCB);
            var letItBe = new Music("Let It Be", "The Beatles", 19, 16);
            musicList.Add(letItBe);
            var theWall1 = new Music("The Wall Disc One", "Pink Floyd", 20, 19);
            musicList.Add(theWall1);
            var theWall2 = new Music("The Wall Disc Two", "Pink Floyd", 20, 22);
            musicList.Add(theWall2);
            var tDSOTM = new Music("The Dark Side of the Moon", "Pink Floyd", 19, 24);
            musicList.Add(tDSOTM);
        }
    }
}