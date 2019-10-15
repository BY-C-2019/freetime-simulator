using System.Collections.Generic;

namespace freetime_simulator
{
    class Person
    {
        public string Name { get; set; }
        public int InteractTimeTotal { get; set; }

        List<Media> inventory;

        public Person(string name)
        {
            Name = name;
            inventory = new List<Media>();
        }

        public void StartInteracting(string itemDescription)
        {

        }

        public void UpdateInteractTime(int time)
        {

        }

        private string PrintInventory()
        {
            string items = "";
            foreach (var item in inventory)
            {
                string delimeter = "";
                foreach (char c in item.ToString())
                    delimeter += "-";
                items += delimeter + "\n\r" + item;
            }
            return items;
        }

        public override string ToString()
        {
            string str = $"{Name}:\n\r";
            str += "\n\r";
            str += PrintInventory();
            return str;
        }
    }
}