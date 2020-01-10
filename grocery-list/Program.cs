using System;
using System.Collections.Generic;

namespace grocery_list
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string item;

            List<string> groceryList = new List<string>();

            Console.WriteLine("Grocery List");

            do
            {
                Console.Write("Add/Remove/Display items from grocery list (Add/Remove/Display/Exit): ");
                input = Console.ReadLine();

                switch(input)
                {
                    case "Add":
                        Console.Write("What would you like to add? ");
                        item = Console.ReadLine();
                        groceryList.Add(item);
                        Console.WriteLine(item + " has been added.");
                        break;
                    case "Remove":
                        Console.Write("What would you like to remove? ");
                        item = Console.ReadLine();
                        groceryList.Remove(item);
                        Console.WriteLine(item + " has been removed.");
                        break;
                    case "Display":
                        DisplayGroceries(groceryList);
                        break;
                    case "Exit":
                        break;
                    default:
                        Console.WriteLine(input + " is not a valid choice");
                        break;
                }

            } while (input != "Exit");
            
        }

        static void DisplayGroceries(List<string> groceryList)
        {
            foreach (string item in groceryList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
