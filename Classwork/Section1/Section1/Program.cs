﻿/* ITSE 1430
   Sample implementation*/
using System;

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

            //PlayWithObjects();
            //PlayWithStrings();
            //PlayWithArrays();
            //ReadInt32();
        }
        private static void PlayWithObjects ()
        {
            int hours = 10;
            Int32 hoursFull = 10;
            var areEqual = hours == hoursFull;

            var obj1 = "Hello";
            DisplayObject(obj1);
        }

        private static void DisplayObject( object value )
        {
            if (value == null)
                return;

            //approach1
            if (value is string)
            {
                var str = (string)value;
                Console.WriteLine(str);
            } else
            {
                var str = value.ToString();
                Console.WriteLine(str);
            };

            //approach2
            var str2 = value as string;
            if (str2 != null)
                Console.WriteLine(str2);
            else
                Console.WriteLine(value.ToString());

            //approach3
            var str3 = value as string;
            Console.WriteLine((str3 != null) ? str3.ToString() : value.ToString());

            //approach4
            var str4 = value as string;
            Console.WriteLine((str4 ?? value).ToString());

            //approach5**
            //var str5 = value is string;
            if (value is string str5)
                Console.WriteLine(str5.ToString());
            else
                Console.WriteLine(value.ToString());

            //approach6**
            var str6 = value as string;
            Console.WriteLine(str6?.ToString()); //look at approach4
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

            //resize array
            //for (int index = 0; index < names.Length; index++)
            foreach (string name in names)
            {
                //read only - not allowed
                //name = "";
                string str = name;
                str = "";
                //Console.WriteLine(names[index]);
                Console.WriteLine(name);
            };
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\nA)dd Movie");
                Console.WriteLine("E)dit Movie");
                Console.WriteLine("D)elete Movie");
                Console.WriteLine("V)iew Movies");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'a':
                    case 'A':
                    AddMovie();
                    return true;

                    case 'e':
                    case 'E':
                    EditMovie();
                    return true;

                    case 'd':
                    case 'D':
                    DeleteMovie();
                    return true;

                    case 'v':
                    case 'V':
                    ViewMovie();
                    return true;

                    case 'q':
                    case 'Q':
                    return false;

                    default:
                    Console.WriteLine("Please enter a valid value.\n\n");
                    break;
                };
            };
        }

        private static void AddMovie()
        {
            name = ReadString("Enter a name: ", true);
            description = ReadString("Enter a description: ");
            runLength = ReadInt32("Enter run length (in minutes): ", 0);
        }

        private static void EditMovie()
        {
            ViewMovie();
            //var - type inferencing
            var newName = ReadString("Enter a name (or press ENTER for default): ");
            if (!string.IsNullOrEmpty(newName))
                name = newName;

            var newDescription = ReadString("Enter a description: ");
            if (!string.IsNullOrEmpty(newDescription))
                description = newDescription;


            var newLength = ReadInt32("Enter run length (in minutes): \n", 0);
            if (newLength > 0)
                runLength = newLength;
        }

        private static void DeleteMovie()
        {
            if (Confirm("Are you sure you want to delete this movie?"))
            {
                //"Delete" the movie
                name = null;
            };
        }

        private static bool Confirm( string message )
        {
            Console.WriteLine($"{message} (Y/N)\n");

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'Y':
                    case 'y':
                    return true;

                    case 'N':
                    case 'n':
                    return false;
                }
            } while (true);
        }

        private static void ViewMovie()
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("No movies available\n");
                return;
            };
            Console.WriteLine(name);

            if (!string.IsNullOrEmpty(description))
                Console.WriteLine(description);

            Console.WriteLine($"Run length = { runLength} mins");
        }

        private static int ReadInt32( string message, int minValue )
        {
            while (true)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();

                if (Int32.TryParse(input, out var result))
                {
                    if (result >= minValue)
                        return result;
                };

                Console.WriteLine($"You must enter an integer value >= {minValue}");
            };

        }

        private static string ReadString( string message )
        {
            return ReadString(message, false);
        }

        private static string ReadString( string message, bool required )
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value");
            };
        }

        //movie
        static string name;
        static string description;
        static int runLength;
        static DateTime releaseDate;
    }
}
