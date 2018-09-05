using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Program
    {
        static void Main( string[] args )
        {
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            } while (notQuit);

            //PlayWithStrings();
            //PlayWithArrays();
            //ReadInt32();
        }

        private static void PlayWithStrings()
        {
            //From String
            //string hoursString = "10";
            //int hours = Int32.Parse(hoursString);
            //int hours;
            //bool result = Int32.TryParse(hoursString, out int hours);

            //ToString
            //hoursString = hours.ToString();
            //4.75.ToString();
            //457.ToString();
            //Console.ReadLine().ToString();

            string message = "Hello\tWorld";
            string filePath = "C:\\Temp\\Test";
            //Verbatim string
            filePath = @"C:\Temp\Test";

            //Concat
            string firstName = "Bob";
            string lastName = "Smitn";
            string name = firstName + " " + lastName;
            //String formatting
            //Strings are immutable - this produces a new string
            //name = "hello" + name;
            Console.WriteLine("Hello" + name); //Approach 1
            Console.WriteLine("Hello {0} {1}", firstName, lastName); //Approach 2
            string str = String.Format("Hello {0} {1}", firstName, lastName); //Approach 3
            Console.WriteLine(str);
            //Approach 4 (Interpreted String) **Best**
            Console.WriteLine($"Hello {firstName} {lastName}");

            string missing = null; //undefined
            string empty = ""; //same as empty2
            string empty2 = String.Empty;
            //Checking for empty strings
            //if (firstName != null && firstName != "")
            if (!String.IsNullOrEmpty(firstName)) // **Best**
                Console.WriteLine(firstName);

            //Other stuff
            string upperName = firstName.ToUpper();
            string lowerName = firstName.ToLower();

            //Comparison
            bool areEqual = firstName == lastName;
            areEqual = firstName.ToLower() == lastName.ToLower();
            areEqual = String.Compare(firstName, lastName, true) == 0;

            bool startsWithA = firstName.StartsWith("A");
            bool endsWithA = firstName.EndsWith("A");
            bool hasA = firstName.IndexOf("A") >= 0;
            string subset = firstName.Substring(4);

            //Clean up
            string cleanMe = firstName.Trim(); //TrimStart, TrimEnd
            string makeLonger = firstName.PadLeft(20); //PadRight

        }

        private static void PlayWithArrays()
        {
            int count = ReadInt32("How many names? ", 1); //size of array

            string[] names = new string[count];
            for (int index = 0; index < count; index++)
            {
                Console.WriteLine("Name? ");
                names[index] = Console.ReadLine();
            };

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
            };
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("E)dit Movie");
                Console.WriteLine("D)elete Movie");
                Console.WriteLine("V)iew Movies");
                Console.WriteLine("Q)uit\n");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'a':
                    case 'A': AddMovie(); return true;

                    case 'e':
                    case 'E': EditMovie(); return true;

                    case 'd':
                    case 'D': DeleteMovie(); return true;

                    case 'v':
                    case 'V': ViewMovie(); return true;

                    case 'q':
                    case 'Q': return false;

                    default:
                    Console.WriteLine("Please enter a valid value.\n\n");
                    break;
                };
            };
        }

        private static void AddMovie()
        {
            Console.WriteLine("Add movie\n");
        }

        private static void EditMovie()
        {
            Console.WriteLine("Edit movie\n");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("Delete movie\n");
        }

        private static void ViewMovie()
        {
            Console.WriteLine("View movie\n");
        }

        private static int ReadInt32(string message, int minValue)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out int result))
                {
                    if (result >= minValue)
                        return result;
                };

                Console.WriteLine($"You must enter an integer value >= {minValue}");
            };

        }
    }
}
