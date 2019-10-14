using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Who is this designed for?
            //---------------------------------------
            // The scientists

            // Whats the most important information to include?
            //---------------------------------------
            // The consumed media


            // For debug purpose only
            FileManager.DeleteFile("backlog.txt");

            // Add media to library
            Media.AddMediaToLibrary();

            Random rand = new Random();
            int experimentTme = rand.Next(200,401); 

            List<Experiment>    experiments     = new List<Experiment>();
            List<Person>        testSubjects    = new List<Person>();

            // Adding test subjects
            testSubjects.Add(new Person("Klas-Göran", 12));
            testSubjects.Add(new Person("Wilhelmina", 16));
            testSubjects.Add(new Person("Thor", 8));
            testSubjects.Add(new Person("Elvis P", 10));
            testSubjects.Add(new Person("Hermione", 34));

            // Welcome text
            Console.Clear();
            Console.WriteLine("Welcome to the livingroom experiment!");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Press any key to start the tests");
            Console.ReadLine();

            // Run the tests
            foreach (Person subject in testSubjects)
            {
                int         newTime  = rand.Next(240, 421);
                Livingroom  newRoom  = new Livingroom(rand.Next(0,4), rand.Next(0,4), rand.Next(0,3)); // Increased values for higher chance of having a tv 

                new Experiment(experiments.Count, subject, newRoom, newTime, ref experiments);
                Console.Clear();
            }         

            // Print end text
            Console.WriteLine("Testing completed...");
            Console.WriteLine("Experiment performed: {0}", experiments.Count);

        }
    }
}
