using System;


namespace Interfaces.Workshop
{
    public class AudioBook : ILibraryItem
    {
        public string ItemId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; } = -1;
        public string Borrower { get; set; }

        public int RunTimeInMinutes { get; set; }

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
            return true;
        }

        public bool CheckMissingPages()
        {
            throw new NotImplementedException();
        }
    }
}
