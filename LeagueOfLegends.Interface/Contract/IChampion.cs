namespace LeagueOfLegends.Contract
{
    public interface IChampion
    {
        string Name { get; set; }
        string Family { get; set; }
        void DisplayInformation();
        void Attack();        
    }
}
