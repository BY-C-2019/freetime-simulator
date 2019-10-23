using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bookInput = true;
            bool movieInput = true;
            bool vinylInput = true;

            string input;
            bool validInput = false;

            string[] bookData;
            string[] movieData;
            string[] albumData;

            Experiment experiment;
            Person person;   

            Console.WriteLine("===== FreeTime Simulator =====");
            
            // Skriv ut instructioner
            Console.WriteLine("Ett gäng forskare vill ta reda på vad en person gör med sin fritid.");
            Console.WriteLine("Du får ta med dig valfritt antal böcker, DVD filmer och Vinyl-skivor till experimentet.");
            Console.WriteLine("Vi vill ha en lista med allt du har tagit med dig.");
            Console.WriteLine("När du inte har något mer att fylla i enligt instruktionerna lämnar du fältet tomt.");
            Console.WriteLine("==============================");
            
            // Initiering.
            do
            {
                Console.WriteLine("Vem utsätts för experimentet?");
                Console.Write("Namn >>");
                input = Console.ReadLine();
                Console.WriteLine("Stämmer detta att namnet på försökspersonen är " + input);
                Console.Write("ja/nej >>");
                if (Console.ReadLine().ToLower()[0] == 'j') { break; }
            }while(true);

            experiment = new Experiment();
            decimal readSpeed = experiment.GetRandomPagesPerMinute();
            
            // Calling constructor for debugging and development.
            // TODO Change before deployment!
            person = new Person(input, readSpeed, true);

            // Be användaren om en lista med object.
            do{
                Console.Clear();
                Console.WriteLine("\nVilka böcker har du med dig?");
                Console.WriteLine("Skriv in Titel, Författare och antal sidor. Separerat av kommatecken.");
                Console.WriteLine("Exempel [Kapten Kalsong,Dav Pilkey,87]");
                Console.Write(">>");
                // Inmatning
                input = Console.ReadLine();
                validInput = ValidCommaSeperated(2, input);
                if (validInput)
                {
                    bookData = SplitUpString(input);
                    person.Inventory.Add(Book.StringToBook(bookData, person.ReadSpeed));
                }
                else if (input == "")
                { 
                    break;
                }
                else 
                { 
                    Console.WriteLine("Nu vart det lite fel på den boken."); 
                }
            }while(bookInput);

            do
            {
                Console.Clear();
                Console.WriteLine("\nVilka filmer har du med dig?");
                Console.WriteLine("Skriv in Titel, Regisör, utgivningsår och Längd i minuter. Separerat av kommatecken.");
                Console.WriteLine("Exempel [Tillbaka Till Framtiden,Robert Zemeckis,1985,117]");
                Console.Write(">>");

                // Inmatning
                input = Console.ReadLine();
                validInput = ValidCommaSeperated(3, input);
                if (validInput)
                {
                    movieData = SplitUpString(input);
                    person.Inventory.Add(Movie.StringToMovie(movieData));
                }
                else if (input == "")
                { 
                    break;
                }
                else 
                { 
                    Console.WriteLine("Nu vart det lite fel på den boken."); 
                }
            }while(movieInput);

            do
            {
                Console.Clear();
                Console.WriteLine("\nVilka vinyler har du med dig?");
                Console.WriteLine("Skriv in Titel, Artist och Längd i minuter. Separerat av kommatecken.");
                Console.WriteLine("Exempel [Powerslave,Iron Maiden,50]");
                Console.Write(">>");

                // Inmatning
                input = Console.ReadLine();
                validInput = ValidCommaSeperated(2, input);
                if (validInput)
                {
                    albumData = SplitUpString(input);
                    person.Inventory.Add(MusicAlbum.StringToAlbum(albumData));
                }
                else if (input == "") { break; }
                else 
                { 
                    Console.WriteLine("Nu vart det lite fel på den filmen."); 
                }
            }while(vinylInput);

            Console.WriteLine("Experimentet kommer nu startas.");
            Console.WriteLine("Tryck valfri tangent för att fortsätta.");
            Console.ReadKey();

            // Starta experimentet.
            do
            {
                // Utför aktivitet.
                foreach(var media in person.Inventory)
                {
                    if (media.Length <= experiment.TimeCounter)
                    {
                        // Is there time left media is used.
                        var value = media.GetType();
                
                        Console.WriteLine($"Using {value.Name}");
                        if(!experiment.UseMedia(media))
                        {
                            Console.WriteLine("Kunde inte använda:");
                            Console.WriteLine(media);
                            Console.WriteLine("Utrustning saknas!");
                            Console.ReadKey();
                        }
                    }
                    else 
                    {
                        experiment.TimeCounter = 0;
                        break; 
                    }
                }
                // Runs the list over and over until experiment ends.
                // Är experimentet slut?
                if (experiment.TimeCounter <= 0)
                {
                    break;
                }
            }while(true);


            // Be användaren att använde en pryl.



            // Är experimentet slut så sammanfatta statistik.
            Console.Clear();
            Console.WriteLine(person);
            Console.WriteLine(experiment);
            // TODO Snygga tilll utskriften av statistik.
            // Även rummet ska vara med här.

            // Alternativt spara data i textfil.
            
            // Avsluta.
            Console.WriteLine("Experimentet är över.");
            Console.WriteLine("Tryck valfri tangent för att avsluta...");
            Console.ReadKey();
        }

        private static bool ValidCommaSeperated(int commas, string input)
        {
            int numberOfCommas = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',') { numberOfCommas++; }
            }
            return (commas == numberOfCommas);
        }

        public static string[] SplitUpString(string str)
        {
            string[] data = str.Split(',');
            return data;
        }
    }
}
