namespace Interfaces.Workshop
{
    public class Book : ILibraryItem
    {
        public string ItemId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Borrower { get; set; }

        public int RunTimeInMinutes { get; set; } = 0;

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
        }

        public void CheckIn()
        {
            Borrower = "";
        }

        public bool CheckSound()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckMissingPages()
        {
            // Do check
            return true;
        }
    }
}
