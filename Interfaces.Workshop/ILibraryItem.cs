namespace Interfaces.Workshop
{
    public interface ILibraryItem
    {
        string ItemId { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Borrower { get; set; }
        int Pages { get; set; }
        int RunTimeInMinutes { get; set; }
        void CheckIn();
        void CheckOut(string borrower);
        bool CheckSound();
        bool CheckMissingPages();
    }
}