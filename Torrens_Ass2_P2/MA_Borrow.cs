using LibrarySystem;

namespace LibActions
{
    /// <summary>
    /// Class responsible for borrowing an item from the lib. 
    /// </summary>
    public class MA_Borrow : MenuAction
    {
        public const string LIST_HEADER = "------------Borrow:-----------\n";
        public const string LIST_ENTER_ID = ">> Please Enter ID of book to borrow. :3 \n";
        public const string BORROW_BOOK_ON_LOAN = ">> Book is not currently in the library, try again later.";
        public const string BORROW_SUCCESS = ">> You successfully loaned: ID({0}) Title: {1} \n";
        public const string BORROW_FAIL = ">> Book ( {0}) could not be located, try again later. \n";
        public const string SEPERATOR = "\n ------------------------------------- \n";

        public override bool Execute(Library library)
        {
            Console.WriteLine(LIST_HEADER);
            Console.WriteLine(LIST_ENTER_ID);

            ///Get the user input. 
            int id = base.ReadIntInput();

            //Check if book is already loaned. 
            for (int i = 0; i < Program.borrowedIDs.Count; i++)
            {
                if (Program.borrowedIDs[i] == id)
                {
                    Console.WriteLine(BORROW_BOOK_ON_LOAN);
                    return true;
                }
            }

            //Check if the book is within the library. 
            if (library.books.ContainsKey(id))
            {
                Program.borrowedIDs.Add(id);
                bool success = library.books.TryGetValue(id, out string? value);
                Console.WriteLine(String.Format(BORROW_SUCCESS, id, value) + SEPERATOR);
            }
            else
                Console.WriteLine(String.Format(BORROW_FAIL, id) + SEPERATOR);
            return true;
        }
    }
}
