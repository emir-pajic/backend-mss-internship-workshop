using System;

namespace LeagueOfLegends.Contract
{
    public class Champion
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
        public virtual void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
