using LeagueOfLegends.Models;
using System;

namespace LeagueOfLegends
{
    class Program
    {
        static void Main(string[] args)
        {
            Katarina katarina = new Katarina();
            katarina.Attack();
            Console.Read();
        }
    }
}
