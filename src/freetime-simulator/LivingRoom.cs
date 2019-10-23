using System;

namespace freetime_simulator
{
    class LivingRoom
    {
        Random rand = new Random();
        public TV Television { get; }
        public DVDPlayer DvdPlayer { get; }
        public RecordPlayer RecordPlayer { get; }

        public LivingRoom()
        {
            if (rand.Next(0, 2) == 1) { Television = new TV(); }
            if (rand.Next(0,2) == 1) { DvdPlayer = new DVDPlayer(); }
            if (rand.Next(0,2) == 1) { RecordPlayer = new RecordPlayer(); }
        }

        public bool HasRecordPlayer()
        {
            if (RecordPlayer != null)
            {
                return true;
            }
            else { return false; }
        }

        public bool HasDvdPlayer()
        {
            if (DvdPlayer != null)
            {
                return true;
            }
            else { return false; }
        }

        public bool HasTelevision()
        {
            if (Television != null)
            {
                return true;
            }
            else { return false; }
        }

        public override String ToString()
        {
            string str = "=============================================\n";
            str += $"Livingroom setup | TV: {HasTelevision()} | DvdPlayer: {HasDvdPlayer()} | RecordPlayer: {HasRecordPlayer()}";
            return str;
        }
    }
}