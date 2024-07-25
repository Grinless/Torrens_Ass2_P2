using LibrarySystem;

namespace LibActions
{
    /// <summary>
    /// Class responsible for listing library contents. 
    /// </summary>
    public class MA_ListAllLibrary : MenuAction
    {
        public const string LIST_HEADER = "------------List Library:-----------";
        public const string BOOK_A = "\n Book ID: <";
        public const string BOOK_B = ">, Book Name: ";
        public const string SEPERATOR = "\n ------------------------------------- \n";

        public override bool Execute(Library library)
        {
            //Setup the start of the list.
            string output = LIST_HEADER;

            ///Display all items in the library. 

            foreach (var item in library.books)
                output += BOOK_A + item.Key + BOOK_B + item.Value;

            //Add the end of the list and display.
            Console.WriteLine(output + SEPERATOR);
            return true;
        }
    }
}
