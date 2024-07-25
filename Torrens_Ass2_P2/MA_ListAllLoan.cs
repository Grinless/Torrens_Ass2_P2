using LibrarySystem;

namespace LibActions
{
    /// <summary>
    /// Class handling listing all user loans. 
    /// </summary>
    public class MA_ListAllLoan : MenuAction
    {
        public const string LOAN_HEADER = "------------On Loan:-----------";
        public const string NO_LOAN_RESPONSE = "\n >> You have no current book loans.";
        public const string BOOK_A = "\n Book ID: <";
        public const string BOOK_B = ">, Book Name: ";
        public const string SEPERATOR = "\n ------------------------------------- \n";

        public override bool Execute(Library library)
        {
            string output = LOAN_HEADER;

            //Check if there are any loans.
            if (Program.borrowedIDs.Count == 0)
                output += NO_LOAN_RESPONSE;
            else
            {
                ///Print all loans by checking stored book IDs. 
                for (int i = 0; i < Program.borrowedIDs.Count; i++)
                {
                    int key = Program.borrowedIDs[i];
                    string title = library.books.TryGetValue(key, out var value) ? value : " ";
                    output += BOOK_A + key + BOOK_B + title;
                }
            }

            Console.WriteLine(output + SEPERATOR);
            return true;
        }
    }
}
