using System;

namespace PizzaCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            } while (notQuit);
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\nN)ew Order");
                Console.WriteLine("M)odify Order");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit");

                var input = Console.ReadLine();
                switch (input[0])
                {
                    case 'n':
                    case 'N':
                        NewOrder();
                        return true;

                    case 'd':
                    case 'D':
                        DisplayOrder();
                        return true;

                    case 'm':
                    case 'M':
                        ModifyOrder();
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

        private static void NewOrder()
        {
            size = ReadString("Pizza size:\nS)mall\tM)edium\tL)arge", true);
            meats = ReadString("What meats would you like added:\nB)acon\tH)am\tP)epperoni\tS)ausage", true);
            vegetables = ReadString("What vegetables would you like added:\nB)lack olives\tM)ushrooms\tO)nions\tP)eppers", true);
            sauce = ReadString("What sauce would you like added:\nT)raditional\tG)arlic\tO)regano", true);
            cheese = ReadString("Extra cheese:\nY)es\tN)o", true);
            delivery = ReadString("T)ake out\tD)elivery", true);
            price = ReadInt32("Current price: ", 0);
        }

        private static void ModifyOrder()
        {
            DisplayOrder();
            //var - type inferencing
            var newSize = ReadString("Pizza size:\nS)mall\tM)edium\tL)arge");
            if (!string.IsNullOrEmpty(newSize))
                size = newSize;

            var newMeats = ReadString("What meats would you like added:\nB)acon\tH)am\tP)epperoni\tS)ausage");
            if (!string.IsNullOrEmpty(newMeats))
                meats = newMeats;

            var newVegetables = ReadString("What vegetables would you like added:\nB)lack olives\tM)ushrooms\tO)nions\tP)eppers");
            if (!string.IsNullOrEmpty(newVegetables))
                vegetables = newVegetables;

            var newSauce = ReadString("What sauce would you like added:\nT)raditional\tG)arlic\tO)regano");
            if (!string.IsNullOrEmpty(newSauce))
                sauce = newSauce;

            var newCheese = ReadString("Extra cheese:\nY)es\tN)o");
            if (!string.IsNullOrEmpty(newCheese))
                cheese = newCheese;

            var newDelivery = ReadString("T)ake out\tD)elivery");
            if (!string.IsNullOrEmpty(newDelivery))
                delivery = newDelivery;

            var newPrice = ReadInt32("Current price: ", 0);
            if (newPrice > 0)
                price = newPrice;
        }

        private static void DisplayOrder()
        {
            if (string.IsNullOrEmpty(size))
            {
                Console.WriteLine("No size was selected\n");
                return;
            };
            Console.WriteLine(size);

            if (string.IsNullOrEmpty(meats))
            {
                Console.WriteLine("No meats have been selected\n");
                return;
            };
            Console.WriteLine(meats);

            if (string.IsNullOrEmpty(vegetables))
            {
                Console.WriteLine("No vegetables have been selected\n");
                return;
            };
            Console.WriteLine(vegetables);

            if (string.IsNullOrEmpty(sauce))
            {
                Console.WriteLine("No sauce type was selected\n");
                return;
            };
            Console.WriteLine(sauce);
        }

        private static bool Confirm(string message)
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

        private static int ReadInt32(string message, int minValue)
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

        private static string ReadString(string message)
        {
            return ReadString(message, false);
        }

        private static string ReadString(string message, bool required)
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

        //pizza order
        static string size;
        static string meats;
        static string vegetables;
        static string sauce;
        static string cheese;
        static string delivery;
        static int price;
    }
}