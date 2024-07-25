using LibActions;

internal partial class Program
{
    #region Lib Responses.
    public const string MENU_HEADER = "What would you like to do:\n";
    public const string MENU_OPT_1 = "1) List all books you have on loan";
    public const string MENU_OPT_2 = "2) Return a book";
    public const string MENU_OPT_3 = "3) List all books in the library";
    public const string MENU_OPT_4 = "4) Borrow a book";
    public const string MENU_OPT_5 = "5) Exit";
    public const string MENU_FOOTER = ">> Enter choice(1–5) :";
    private const string INVALID_INPUT = "Invalid Input, Please Try Again.";
    #endregion

    public static LibrarySystem.Library lib = new LibrarySystem.Library();
    public static Dictionary<int, MenuAction> menuActions = new Dictionary<int, MenuAction>();
    public static List<int> borrowedIDs = new List<int>();
    public static bool applicationExit = false;

    /// <summary>
    /// Reads the users inputs in as an integer. 
    /// </summary>
    /// <returns> Integer input. </returns>
    public static int ReadIntInput()
    {
        string input = Console.ReadLine();
        int value = -1;

        if (int.TryParse(input, out value))
            return value;
        else
            Console.WriteLine(INVALID_INPUT);
        return -1;
    }

    static void Main(string[] args)
    {

        //Setup Library Functions. 
        menuActions.Add(1, new MA_ListAllLoan());
        menuActions.Add(2, new MA_ReturnBook());
        menuActions.Add(3, new MA_ListAllLibrary());
        menuActions.Add(4, new MA_Borrow());
        menuActions.Add(5, new MA_Exit());

        while (!applicationExit)
        {
            Console.WriteLine(MENU_HEADER);
            Console.WriteLine(MENU_OPT_1);
            Console.WriteLine(MENU_OPT_2);
            Console.WriteLine(MENU_OPT_3);
            Console.WriteLine(MENU_OPT_4);
            Console.WriteLine(MENU_OPT_5);
            Console.WriteLine(MENU_FOOTER);

            int inputChoice = -1;
            MenuAction? actionSelection;

            while (inputChoice == -1)
            {
                inputChoice = ReadIntInput();

                if (inputChoice < 1 || inputChoice > 5)
                {
                    inputChoice = -1;
                    Console.WriteLine(">> Please enter a selection between 1 and 5.");
                }
            }

            menuActions.TryGetValue(inputChoice, out actionSelection);
            if (actionSelection != null)
            {
                ((MenuAction)actionSelection).Execute(lib);
            }
        }
    }
}
