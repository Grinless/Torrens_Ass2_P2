using LibrarySystem;

namespace LibActions
{
    /// <summary>
    /// Class responsible for returning books. 
    /// </summary>
    public class MA_ReturnBook : MenuAction
    {
        public const string RETURN_LOAN_HEADER = "------------Return Loan:-----------";
        public const string RETURN_LOAN_PROMPT = ">> Please Enter ID of book to return. :3";
        public const string RETURN_LOAN_SUCESS = ">> Book returned successfully. :3";
        public const string RETURN_LOAN_FAIL = ">> Book return failed: ID was not valid. :3";
        public const string RETURN_NO_LOAN = ">> You have no books on loan, try again once you borrow some. :3 ";
        public const string SEPERATOR = "-------------------------------------";

        public override bool Execute(Library library)
        {
            Console.WriteLine(RETURN_LOAN_HEADER);
            int id = -1;

            ///Check if loaned item exists. 
            if (Program.borrowedIDs.Count == 0)
                Console.WriteLine(RETURN_NO_LOAN + "\n" + SEPERATOR);
            else
            {

                Console.WriteLine(RETURN_LOAN_PROMPT);

                ///Get the indicated ID. 
                while (id == -1)
                    id = ReadIntInput();

                //Attempt verification and removal. 
                for (int i = 0; i < Program.borrowedIDs.Count; i++)
                {
                    if (Program.borrowedIDs[i] == id)
                    {
                        Program.borrowedIDs.RemoveAt(i);
                        Console.WriteLine(RETURN_LOAN_SUCESS + "\n" + SEPERATOR);
                        return true;
                    }
                }

                Console.WriteLine(RETURN_LOAN_FAIL + "\n" + SEPERATOR);
            }

            return true;
        }
    }
}
