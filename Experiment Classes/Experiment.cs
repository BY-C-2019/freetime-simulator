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

            // Add experiment to experimentlog
            AddExperimentToLog(ref listOfExperiments);
        }

        private void StartTest()
        {
            string textToPrint = "";
            string fileName = "backlog.txt";
            
            textToPrint += "New test initated...\n";
            textToPrint += String.Format("  {0}\n", testSubject.Name);
            textToPrint += String.Format("  {0} ppm\n", testSubject.PagesPerMinute);
            textToPrint += String.Format("  {0} items brought\n", testSubject.mediaCount);
            textToPrint += String.Format("Time: {0}\n", timeLeft);
            textToPrint += String.Format("Room setup: Tv: {0} | DVD player: {1} | Music player: {2}\n", roomSetup.tv, roomSetup.dvdPlayer, roomSetup.musicPlayer);
            textToPrint += ("----------------------------------------------\n");
            textToPrint += "Test started...";

            // Print fluff to console and file
            Console.Write(textToPrint);
            FileManager.Write(textToPrint, fileName);
            
            // Sleep for powerful effect!!!
            System.Threading.Thread.Sleep(2000);

            // Consume until times up or all media is consumed        
            testSubject.Consume(ref timeLeft, roomSetup, ref consumedMedia, ref textToPrint);

            // Wait for userinput
            FileManager.Write(textToPrint, fileName);
            textToPrint += "Press any key to see list of consumed media...";
            Console.Write(textToPrint);
            Console.ReadLine();

            // Print media that got consumed
            textToPrint = "----------------------------------------------\n";
            textToPrint += "CONSUMED MEDIA:\n";
            PrintMediaList(consumedMedia, ref textToPrint);
            textToPrint += "----------------------------------------------\n";
            textToPrint += String.Format("Time elapsed: {0} / {1}\n", (experimentTime - timeLeft), experimentTime);

            // Wait for userinput to continue
            FileManager.Write(textToPrint, fileName);
            textToPrint += "\nPress any key to continue\n";
            Console.Write(textToPrint);
            Console.ReadLine();

            // If no errors were detected during experiment delete backlog.
            FileManager.DeleteFile(fileName);
        }

        /// <summary>  Gather all types of different media and print them together </summary>
        private void PrintMediaList(List<Media> mediaToPrint, ref string textToPrint)
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
                textToPrint += " Movies\n";
                foreach (Movie movie in movies)
                {
                    movie.PrintMediaInformation(ref textToPrint);
                }
            }

            // Print all albums consumed if list isnt empty
            if (albums.Count != 0) {
                textToPrint += " Albums\n";
                foreach (MusicAlbum album in albums)
                {
                    album.PrintMediaInformation(ref textToPrint);
                }
            }

            // Print all books consumed if list isnt empty
            if (books.Count != 0) {
                textToPrint += " Books\n";
                foreach (Book book in books)
                {
                    book.PrintMediaInformation(ref textToPrint);
                }
            }
        }

        private void AddExperimentToLog(ref List<Experiment> experiments)
        {
            experiments.Add(this);
        }
    }
}