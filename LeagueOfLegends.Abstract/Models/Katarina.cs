using LeagueOfLegends.Contract;
using System;

namespace LeagueOfLegends.Models
{
    class Katarina : Champion
    {
        public Katarina():base("Katarina", "Assasin")
        {}

        public override void Attack()
        {
            Console.WriteLine("Katarina attacks with the death lotus");
        }
    }
}
