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

        public void StartInteracting(string itemDescription)
        {

        }

        public void UpdateInteractTime(int time)
        {

        }

        private string PrintInventory()
        {
            string items = "";
            foreach (var item in Inventory)
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