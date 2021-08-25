using LeagueOfLegends.Models;
using System;

namespace LeagueOfLegends.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Champion katarina = new Champion("Katarina", "Assasin");
            katarina.DisplayInformation();
            katarina.Attack();
            Console.Read();
        }
    }
}
