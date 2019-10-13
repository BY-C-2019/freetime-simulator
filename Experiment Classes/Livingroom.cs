using System;

namespace freetime_simulator
{
    class Livingroom
    {
        public bool tv;
        public bool dvdPlayer;
        public bool musicPlayer;

        public Livingroom(int tv, int dvdPlayer, int musicPlayer)
        {
            this.tv             = Convert.ToBoolean(tv);
            this.dvdPlayer      = Convert.ToBoolean(dvdPlayer);
            this.musicPlayer    = Convert.ToBoolean(musicPlayer);
        }
    }
}