using System.Collections.Generic;
using static Program;

namespace LibrarySystem
{
    public class Library
    {
        public SortedDictionary<int, string> books = new SortedDictionary<int, string>();

        public Library()
        {
            GenerateLibrary();
        }

        /// <summary>
        /// Used to generate library contents. 
        /// </summary>
        public void GenerateLibrary()
        {
            books.Add(10001, "The Hundred Year Old Man Who Climbed Out the Window, Jonas Jonasson");
            books.Add(10002, "Gideon the Ninth, Tamsyn Muir");
            books.Add(10003, "John Dies At The End, David Wong");
            books.Add(10004, "The Metamorphosis, Franz Kafka");
            books.Add(10005, "Help! A Bear is Eating Me, Mykle Hansen.");
            books.Add(10006, "Images You Should Not Masturbate To, Rob Hibbert");
            books.Add(10007, "Bombproof Your Horse, Rick Pelicano");
            books.Add(10008, "How To Talk To Your Cat About Gun Safety, Zachary Auburn");
            books.Add(10009, "Outwitting Squirrels: 101 Cunning Stratagems To Reduce Dramatically The Misappropriation of Seed from Your Birdfeeder by Squirrels, JR Bill Addler");
            books.Add(10010, "The Haunted Vagina, Carlton Mellick III");
            books.Add(10011, "The Penis Name Book: A Guide to Naming Mans Best Friend, David Rosenthal");
            books.Add(10012, "If God Loves Me, Why Can't I Get My Locker Open?, Lorraine Peterson");
            books.Add(10013, "The Stray Shopping Carts of Eastern North America: A Guide to Field Identification, Julian Montague");
            books.Add(10014, "Better Never To Have Been: The Harm of Coming into Existence, David Benatar");
            books.Add(10015, "Castration: The Advantages and Disadvantages, Victor T. Cheney");
            books.Add(10016, "Collectable Spoons of the 3rd Reich, James A Yannes");
            books.Add(10017, "Reusing Old Graves, Davies, Douglas");
            books.Add(10018, "Street Sword: Practical Use of the Long Blade for Self-Defense, Phil Elmore");
            books.Add(10019, "Fancy Coffins To Make Yourself, Dale Power");
            books.Add(10020, "How To Avoid Huge Ships 2nd Edition, Captain John W Trimmer");
            books.Add(10021, "How To Raise Your IQ by Eating Gifted Children, Lewis B. Frumkes");
            books.Add(10022, "Eating People Is Wrong, Malcolm Bradbury");
            books.Add(10023, "50 Ways to Use Feminine Hygiene Products in a Manly Manner (for the self-assured male), B. Koz");
            books.Add(10024, "Not Pounded By Anything: Six Platonic Tales Of Non-Sexual Encounters, Chuck Tingles");
        }
    }
}
