using LibrarySystem;

namespace LibActions
{
    /// <summary>
    /// Class responsible for exiting the application.
    /// </summary>
    public class MA_Exit : MenuAction
    {
        public const string EXIT_HEADER = "------------Exit:-----------\n";
        public const string EXIT_MSG = ">> Thank you for your patronage. Have a nice day. :) \n";
        public const string SEPERATOR = "\n ------------------------------------- \n";

        public override bool Execute(Library library)
        {
            Console.WriteLine(EXIT_HEADER + EXIT_MSG + SEPERATOR);
            Program.applicationExit = true;
            return true;
        }
    }
}
