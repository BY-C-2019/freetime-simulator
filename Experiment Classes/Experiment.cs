using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Experiment
    {       
        int             id;
        int             experimentTime;
        int             timeLeft;
        Person          testSubject;
        Livingroom      roomSetup;
        List<Media>     consumedMedia = new List<Media>();

        public Experiment(int id, Person person, Livingroom roomSetup, int randomTime, ref List<Experiment> listOfExperiments)
        {
            this.id             = id;
            this.testSubject    = person;
            this.roomSetup      = roomSetup; 
            this.experimentTime = randomTime;
            this.timeLeft       = experimentTime;

            // Starts the test
            StartTest();
            AddExperimentToLog(ref listOfExperiments);
        }

        private void StartTest()
        {
            // Print fluff
            Console.WriteLine("New test initated...");
            Console.WriteLine("  {0}", testSubject.Name);
            Console.WriteLine("  {0} ppm", testSubject.PagesPerMinute);
            Console.WriteLine("  {0} items brought", testSubject.mediaCount);
            Console.WriteLine("Time: {0}", timeLeft);
            Console.WriteLine("Room setup: Tv: {0} | DVD player: {1} | Music player: {2}", roomSetup.tv, roomSetup.dvdPlayer, roomSetup.musicPlayer);
            Console.WriteLine("----------------------------------------------");
            Console.Write("Test started...");
            System.Threading.Thread.Sleep(2000);

            // Consume until times up or all media is consumed        
            testSubject.Consume(ref timeLeft, roomSetup, ref consumedMedia);

            // Wait for userinput
            Console.Write("...Press any key to see list of consumed media...");
            Console.ReadLine();

            // Print media that got consumed
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("CONSUMED MEDIA:");
            PrintMediaList(consumedMedia);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Time elapsed: {0} / {1}", (experimentTime - timeLeft), experimentTime);

            // Wait for userinput to continue
            Console.Write("\n...Press any key to continue");
            Console.ReadLine();
        }

        /// <summary>  Gather all types of different media and print them together </summary>
        private void PrintMediaList(List<Media> mediaToPrint)
        {
            List<Movie> movies      = new List<Movie>();
            List<Book> books        = new List<Book>();
            List<MusicAlbum> albums = new List<MusicAlbum>();
            
            // Get type of media consumed in media list
            foreach (Media media in mediaToPrint)
            {
                if (media.GetType() == typeof(Movie)) {
                    movies.Add((Movie)media);
                }
                else if (media.GetType() == typeof(MusicAlbum)) {
                    albums.Add((MusicAlbum)media);
                }
                else if (media.GetType() == typeof(Book)) {
                    books.Add((Book)media);
                }
            }   

            // Print all movies consumed if list isnt empty
            if (movies.Count != 0) {
                Console.WriteLine(" Movies");
                foreach (Movie movie in movies)
                {
                    movie.PrintMediaInformation();
                }
            }

            // Print all albums consumed if list isnt empty
            if (albums.Count != 0) {
                Console.WriteLine(" Albums");
                foreach (MusicAlbum album in albums)
                {
                    album.PrintMediaInformation();
                }
            }

            // Print all books consumed if list isnt empty
            if (books.Count != 0) {
                Console.WriteLine(" Books");
                foreach (Book book in books)
                {
                    book.PrintMediaInformation();
                }
            }
        }

        private void AddExperimentToLog(ref List<Experiment> experiments)
        {
            experiments.Add(this);
        }
    }
}