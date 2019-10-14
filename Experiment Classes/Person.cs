using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Person
    {
        private string name;
        public  string Name { get{ return name; } }


        List<Media> mediaBrought = new List<Media>();
        public  int mediaCount { get { return mediaBrought.Count; }}  

        private int pagesPerMinute;
        public  int PagesPerMinute { get{ return pagesPerMinute; }}

        public Person(string firstName, int pagesPerMinute)
        {
            this.name           = firstName;
            this.pagesPerMinute = pagesPerMinute;
            
            // Random a list of media to bring to the experiment
            Random rand = new Random();
            RandomMediaBrought(rand.Next(10,25));
        }

        public void Consume(ref int timeLeft, Livingroom roomSetup, ref List<Media> consumedMedia, ref string textToPrint)
        {
            for (int i = 0; i < mediaBrought.Count; i++)
            {
                // Check the type of media and if the room meet the required criterias
                // If criterias isnt met, continue to next media in the list
                if(mediaBrought[i].GetType() == typeof(Movie)) {
                    if (!roomSetup.tv || !roomSetup.dvdPlayer) {
                        continue;
                    }
                }
                else if(mediaBrought[i].GetType() == typeof(MusicAlbum)) {
                    if (!roomSetup.musicPlayer) {
                        continue;
                    }
                }

                // Consume media if there is enough time, if not end the experiment
                if (!mediaBrought[i].ConsumeMedia(this, ref timeLeft)){
                    textToPrint = "...Time's up!\n";
                    return;    
                }

                // Add the media to consumelist
                consumedMedia.Add(mediaBrought[i]);
            }

            textToPrint = "...Everything that could be consumed did!\n";
        }

        private void RandomMediaBrought(int numberOfMedia) 
        {
            List<int> uniqueNumbers = new List<int>();

            // If wanted number of media is higher than media available, set it to max amount
            if (numberOfMedia > Media.MediaLibrary.Count) {
                numberOfMedia = Media.MediaLibrary.Count;
            }
            // Get a list of unique numbers 
            for (int i = 0; i < numberOfMedia; i++)
            {
                int randomNumber;
                
                // Random a number within the range of available media content
                // til a unique number has been found
                do 
                {
                    Random rand = new Random();
                    randomNumber = rand.Next(0, Media.MediaLibrary.Count);
                } while (uniqueNumbers.Contains(randomNumber));
                
                // When unique number is found, add it to list;
                uniqueNumbers.Add(randomNumber);
            }

            // Get a random list of mediacontent
            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                int index = uniqueNumbers[i];
                mediaBrought.Add(Media.MediaLibrary[index]);
            }
        }
    }
}
