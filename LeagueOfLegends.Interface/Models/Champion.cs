using LeagueOfLegends.Contract;
using System;

namespace LeagueOfLegends.Models
{
    class Champion : IChampion
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public Champion(string name, string family)
        {
            Name = name;
            Family = family;
        }

        public void Attack()
        {
            Console.WriteLine(Name + " attacks");
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Family: " + Family);
        }
    }
}
