namespace LibActions
{
    /// <summary>
    /// Menu abstract base class. 
    /// </summary>
    public abstract class MenuAction
    {
        /// <summary>
        /// Read inputs from Console. 
        /// </summary>
        /// <returns> The last line entered as an integer.</returns>
        public int ReadIntInput()
        {
            string? input = Console.ReadLine();
            int value = -1;

            if (input != null)
            {
                if (int.TryParse(input.ToString(), out value))
                    return value;
            }
            else
                Console.WriteLine("Invalid Input, Please Try Again.");
            return -1;
        }

        /// <summary>
        /// Execute the menu action. 
        /// </summary>
        /// <returns></returns>
        public abstract bool Execute(LibrarySystem.Library library);
    }
}
