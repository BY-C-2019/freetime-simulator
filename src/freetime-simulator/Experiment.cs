using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Experiment
    {
        public Experiment()
        {
            completedActivities = new List<Media>();
            Duration = rand.Next(0, 500);
            TimeCounter = Duration;
            Id = rand.Next(1, 10000000);
            room = new LivingRoom();
        }
        private List<Media> completedActivities;
        private Random rand = new Random();
        public int Duration { get; }
        public int TimeCounter { get; set; }
        public int Id { get; }
        public LivingRoom room { get; set; }

        public bool UseMedia(Media media)
        {
            if (IsMediaUsable(media))
            {
                completedActivities.Add(media);
                TimeCounter -= media.Length;
                return true;
            }
            else { return false; }
        }

        public bool IsMediaUsable(Media media)
        {
            var value = media.GetType();
            if (value.Equals(typeof(Book)))
            {
                return true;
            }
            if (value.Equals(typeof(Movie)) && CanPlayMovie())
            {
                return true;
            }
            if (value.Equals(typeof(MusicAlbum)) && CanPlayAlbum())
            {
                return true;
            }
            else { return false; }
        }

        private bool CanPlayMovie()
        {
            if (room.HasTelevision() && room.HasDvdPlayer())
            {
                return true;
            }
            else { return false; }
        }

        private bool CanPlayAlbum()
        {
            if (room.HasRecordPlayer())
            {
                return true;
            }
            else { return false; }
        }

        private string ReturnCompletedActivities()
        {
            string str = "";
            foreach (var media in completedActivities)
            {
                str += media + "\n";
                str += "---------------------------\n";
            }
            return str;
        }

        public void SaveStatistics()
        {

        }

        public decimal GetRandomPagesPerMinute()
        {
            decimal result = Convert.ToDecimal(rand.NextDouble());
            result += rand.Next(0, 1);
            return result;
        }

        public override String ToString()
        {
            string str = $"Experiment nr: {Id} | Length: {Duration}\n";
            str += "======================\n";
            str += "Completed Activities:\n";
            str += ReturnCompletedActivities();
            return str;
        }
    }
}