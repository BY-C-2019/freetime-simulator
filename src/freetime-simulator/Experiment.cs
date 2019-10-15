using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Experiment
    {
        private List<Media> completedActivities;

        public int Duration { get; }

        public Experiment(int duration)
        {
            Duration = duration;
        }

        public void SaveStatistics()
        {

        }

        public int CalculatePagesPerMinute()
        {
            int result = 0;
            return result;
        }
        
    }
}