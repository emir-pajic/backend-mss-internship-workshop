using System;

namespace LeagueOfLegends.Contract
{
    public abstract class Champion
    {
        public string Name { get; set; }

        public string Family { get; set; }

        public Champion(string name, string family)
        {
            Name = name;
            Family = family;
        }
        public void DisplayInformation()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Family: " + Family);

        }
        public abstract void Attack();
        
    }
}
