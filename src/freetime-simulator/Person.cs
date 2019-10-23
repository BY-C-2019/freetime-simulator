using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Person
    {
        public string Name { get; set; }
        public int InteractTimeTotal { get; set; }
        public decimal ReadSpeed { get; }

        public List<Media> Inventory { get; set; }

        public Person(string name, decimal readSpeed)
        {
            Name = name;
            ReadSpeed = readSpeed;
            Inventory = new List<Media>();
        }

        public Person(string name, decimal readSpeed, bool debug) 
            : this(name, readSpeed)
        {
            this.CreateDefaultMedia();
        }

        // ctor for development with example media.
        private void CreateDefaultMedia()
        {
            MusicAlbum album = new MusicAlbum(73, "Octavarium", "Dream Theater");
            Movie movie = new Movie(
                178, "Pulp-Fiction", "Quentin Tarantino", 1994);
            Book book = new Book(50, "Kalle Anka", "Disney", 120);
            Inventory.Add(album);
            Inventory.Add(movie);
            Inventory.Add(book);
        }

        // This function adds all item seperated by a line 
        // that´s equals the length of the item string.
        private string ReturnInventoryAsString()
        {
            string items = "";
            foreach (var item in Inventory)
            {
                string delimeter = ""; 
                foreach (char c in item.ToString())
                    delimeter += "-";
                items += "\n" + delimeter + "\n\r" + item;
            }
            return items;
        }

        public override string ToString()
        {
            string str = $"{Name} | Pages/min: {ReadSpeed:N2}";
            str += ReturnInventoryAsString();
            return str;
        }
    }
}