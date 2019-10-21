using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Experiment
    {
        public Experiment()
        {
            Duration = rand.Next(0, 500);
        }
        private List<Media> completedActivities;
        private Random rand = new Random();
        public int Duration { get; }

        public void UseMedia(Media media)
        {
            completedActivities.Add(media);

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

        public int TimeLeft()
        {
            int totalTime = 0;;
            foreach (var media in completedActivities)
            {
                totalTime += media.Length;
            }
            return Duration - totalTime;
        }

        public override String ToString()
        {
            string str = "";
            
            return str;
        }
    }
}