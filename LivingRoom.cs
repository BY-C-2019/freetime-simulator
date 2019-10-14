using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Livingroom
    {
        public static List<Experiment> experimentList = new List<Experiment>();
        protected int experiment = 0;
        bool GenerateMediaOption()
        {
            bool generate;
            //Generates a 50 % off having the corresponding movie option in a single experiment.
            var rnd = new Random();
            int access = rnd.Next(0, 2);
            if (access == 1)
            {
                generate = true;
            }
            else
            {
                generate = false;
            }
            return generate;
        }
        public void EnterLivingRoom()
        {
            bool accessMovies;
            bool accessBooks;
            bool accessMusic;
            //Start by randomly generate which media options are available
            while (true)
            {
                accessMovies = GenerateMediaOption();
                accessBooks = GenerateMediaOption();
                accessMusic = GenerateMediaOption();
                //Makes sure that at least one media option is available
                if (accessMovies == true || accessBooks == true || accessMusic == true)
                {
                    break;
                }
            }
            Experiment(accessMovies, accessBooks, accessMusic);
        }
        void Experiment(bool accessMovies, bool accessBooks, bool accessMusic)
        {
            // How much time this experiment will have. In minutes. 5-24h
            var rnd = new Random();
            int time = rnd.Next(300, 1441);
            int consumedMedia = 0;
            int mediaChoice;
            experiment++;

            Console.WriteLine("This experiment will last for {0} minutes. OK?", time);
            Console.ReadKey();
            //Subject starts to pick his media.
            while (time > 0)
            {
                Console.Clear();
                while (true)//check if mediachoice exists in this roomconfig
                {
                    mediaChoice = rnd.Next(1, 4);
                    if (mediaChoice == 1 && accessMovies == true) { break; }
                    else if (mediaChoice == 2 && accessMusic == true) { break; }
                    else if (mediaChoice == 3 && accessBooks == true) { break; }
                }

                System.Console.WriteLine("We have {0} minutes left in this experiment.", time);

                if (mediaChoice == 1)
                {
                    int filmChoice = rnd.Next(1, Movie.movieList.Count); //chooses film
                    Console.WriteLine("{0} watches " + Movie.movieList[filmChoice].Title, Person.personList[experiment - 1].Name); //prints movie name
                    time = time - Movie.movieList[filmChoice].length; // reduces our time left.
                }
                else if (mediaChoice == 2)
                {
                    int musicChoice = rnd.Next(1, Music.musicList.Count);
                    Console.WriteLine("Listens to " + Music.musicList[musicChoice].Title);
                    System.Console.WriteLine("{0} listens to side A.", Person.personList[experiment - 1].Name);
                    time = time - Music.musicList[musicChoice].lengthA;
                    System.Console.WriteLine("{0} listens to side B.", Person.personList[experiment - 1].Name);
                    time = time - Music.musicList[musicChoice].lengthB;
                }
                else if (mediaChoice == 3)
                {
                    int bookChoice = rnd.Next(1, Book.bookList.Count);
                    Console.WriteLine("{0} reads {1}.", Person.personList[experiment - 1].Name, Book.bookList[bookChoice].Title);
                    //Console.WriteLine(Book.bookList[bookChoice].Title + " " + Book.bookList[bookChoice].length);
                    time = time - (Book.bookList[bookChoice].pages / Person.personList[experiment - 1].ReadTime); //pages / numberofpagesperminute
                }
                //adds consumed media and checks if subject finished media before time ran out. -1 if so.
                consumedMedia++;
                if (time < 0)
                {
                    System.Console.WriteLine("The subject did not have time to consume the last chosen media...It will not count.");
                    consumedMedia--;
                }
                Console.ReadKey();
            }
            System.Console.WriteLine(Person.personList[experiment - 1].Name + " consumed {0} types of media before time ran out.", consumedMedia);
            //creates and completes experiment. Adds it to a list of experiments.
            var newExp = new Experiment(experiment, Person.personList[experiment - 1].Name, consumedMedia, accessMovies, accessMusic, accessMusic);
            experimentList.Add(newExp);
            Console.ReadKey();
        }
        public void PrintExperiments()
        {
            Console.Clear();
            foreach (Experiment exp in experimentList)
            {
                Console.WriteLine();
                Console.WriteLine("Test subjects id: {0}", exp.id);
                Console.WriteLine("Test subjects name: {0}", exp.name);
                Console.WriteLine("Test subjects consumed {0} medias.", exp.mediaConsumed);
                Console.Write("It had access to: ");
                if (exp.movieAccess == true)
                {
                    Console.Write("movies");
                }
                if (exp.musicAccess == true)
                {
                    Console.Write("| music");
                }
                if (exp.bookAccess == true)
                {
                    Console.Write("| books");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
