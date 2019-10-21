using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Experiment
    {
        private List<Media> completedActivities;
        private Random rand = new Random();

        public int Duration { get; }

        public Experiment()
        {
            Duration = rand.Next(0, 500);
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
        
    }
}