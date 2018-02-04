using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApplication
{
    class RandomNames
    {
        public static Random r = new Random();
        public static string[] randomProductNames = new string[]
        {
            "Condoms", "Sack of potatoes", "Dank memes", "Fish", "Mullet", "Placenta", "Illegal software", "Drugs",
            "Air freshner", "Centaur", "Hat", "Husband pillow", "Girlfriend pillow", "Oni chan", "Afro", "Black tar heroin",
            "Dildo", "Dragons", "Cube", "Kinder eggs", "Skittles", "Fried chicken", "Waifu", "Mexicans", "Calories"
        };
        public static string[] randomFirstNames = new string[]
        {
            "Bob","Mattias","Ernes","Philip","Filip","Memer","Lord","Mr","Kevin","Alpha","Jesus","Timmy","Eric","Adolf",
            "Beth","Mathilda","Erin","Filicia","Filipia","Mavis","Pristess","Ms","Kathy","Zeta","Jasmine","Tina","Erika","Eva",
            "Alex","Baily","Charlie","Devin","Eli","Frances","Glenn","Harley","Jayden","Kelly","Logan","Monroe","Pheonix","Quinn",
            "Rowan","Sage","Taylor","Val","Winter","Salim"
        };
        public static string[] randomLastNames = new string[]
        {
            "Smith","Jones","Brown","Johnson","Williams","Miller","Taylor","Wilson","Davis","White","Clark","Hall","Thomas",
            "Thompson","Moore","Hill","Walker","Andersson","Wright","Martin","Wood","Allen","Robinsson","Lewis","Scott","Knuckles",
            "Young","Jacksson","Adams","Tryniski","Green","Evans","King","Baker","John","Harris","Robert","Campbell","James","Borgström",
            "Soroccos","Philipowhich", "Filipovic"
        };

        public static string FirstName()
        {
            return randomFirstNames[r.Next(randomFirstNames.Length)];
        }

        public static string LastName()
        {
            return randomLastNames[r.Next(randomLastNames.Length)];
        }

        public static string ProductName()
        {
            return randomProductNames[r.Next(randomProductNames.Length)];
        }
    
    }
}
