using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class GenericStackExamples
    {
        public void StackMethods()
        {
            var stack = new Stack<string>();

            stack.Push("item1");
            stack.Push("item2");
            stack.Push("item3");

            var poppedItem = stack.Pop(); // Pop method remove the last item from Stack
            Console.WriteLine(poppedItem);

            var peekedItem = stack.Peek(); // Peek method get the value from the Stack
            Console.WriteLine(peekedItem);

            stack.Clear(); // Clear method will remove all the items from the Stack

            Console.ReadKey();
        }

        public void ShoppingCartExample()
        {
            int option = 0;

            ShoppingCart shoppingCart = new ShoppingCart();

            while (option != 5)
            {
                Console.WriteLine("\n\t\t Menu - Select an Option");
                Console.WriteLine("\t\t------------------------");
                Console.WriteLine("\t\t1. Add an item to shopping cart");
                Console.WriteLine("\t\t2. Undo");
                Console.WriteLine("\t\t3. Redo");
                Console.WriteLine("\t\t4. View Cart");
                Console.WriteLine("\t\t5. Exit");
                Console.WriteLine("Option: ");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.Write("Enter item name (type 'n' to stop): ");
                            var itemName = Console.ReadLine();

                            if (itemName != "n")
                                shoppingCart.AddCart(itemName);

                            repeat = itemName == "n" ? false : true;
                        }
                        ShowCartItems();
                        break;

                    case 2:
                        shoppingCart.Undo();
                        ShowCartItems();
                        break;

                    case 3:
                        shoppingCart.Redo();
                        ShowCartItems();
                        break;

                    case 4:
                        ShowCartItems();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option !");
                        break;
                }
            }
        }

        public void ShowCartItems()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tCart Items");
            Console.WriteLine("\t----------");
            shoppingCart.ViewCart();
            Console.WriteLine("\t----------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
