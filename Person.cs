using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Person
    {
        Random rnd = new Random();
        public static List <Person> personList = new List <Person>();
        public int readTime;
        public int ReadTime { get { return readTime; } set { readTime = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public Person()
        {
        }
        public Person(string name, int readtime)
        {
            this.Name = name;
            this.ReadTime = readtime;
        }
        public void AddPerson()
        {
            System.Console.Write("Please enter the name of our next subject: ");
            var person = new Person(Console.ReadLine(),rnd.Next(1,4)); //1-3 sidor per minut
            personList.Add(person);
        }
    }
}
