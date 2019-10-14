using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Program
    {
        public List<int> idList = new List<int>();
        static void Main(string[] args)
        {
            var person = new Person();
            var movie = new Movie();
            var book = new Book();
            var music = new Music();
            var livingroom = new Livingroom();
            //Adds movies, books, music
            movie.AddMovie();
            book.AddBook();
            music.AddMusic();

            while (true)
            {
                person.AddPerson();
                Console.Clear();
                //enter livingroom
                livingroom.EnterLivingRoom();
                //want to do another experiment?
                Console.Clear();
                //print experimentlist
                System.Console.Write("Would you like to see all our test results so far? (Y/N): ");
                bool printList = TryYesOrNO();
                if (printList == true)
                {
                    livingroom.PrintExperiments();
                }
                Console.Clear();
                Console.Write("Would you like to try out another subject? (Y/N): ");
                bool anotherSubject = TryYesOrNO();
                if (anotherSubject == false)
                {
                    break;
                }
            }
            Console.WriteLine("You have done {0} experiment(s).", Person.personList.Count);
        }
        public static bool TryYesOrNO()
        {
            string input = "";
            bool yes = true;
            while (true)
            {
                try
                {
                    input = Console.ReadLine().Substring(0, 1).ToUpper();
                    System.Console.WriteLine(input);
                }
                catch
                {
                    System.Console.WriteLine("Please follow the instructions.");
                }
                if (input == "Y")
                {
                    yes = true;
                    break;
                }
                else if (input == "N")
                {
                    yes = false;
                    break;
                }
                else
                {
                    System.Console.WriteLine("Please follow the instructions.");
                }
            }
            return yes;
        }
        public static string TryString()
        {
            string input;
            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    break;
                }
                catch
                {
                    System.Console.WriteLine("Please follow the instructions.");
                }
            }
            return input;
        }
    }
}
