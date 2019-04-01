using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleShoppingBasket.Shop;
using ConsoleShoppingBasket.Interface;

/*

so the idea is that the software should have preset items. In the basket I can have n amount of these items, 
where n is just however many I want. Each item has a price, obv. I should be able to add, remove and modify items - it should also be able to produce a total
command line shopping basket
to be more precise
its a scenario where you're essentially programming in the intricacies of doing the weekend shopping

so i should be able to add, remove and modify items
to/from/in the basket
the software should also produce a total price based on what's in there when asked for it

*/

namespace ConsoleShoppingBasket.Start
{
    class Program
    {

        static void Main()
        {

            var inventory = new Inventory<string, Double, string, int>();

            inventory.addItem("Banana", 2.2, "Yellow and with nice curve");
            inventory.addItem("Milk", 3.2, "Goes well with coffee");
            inventory.addItem("Bread", 4, "The most expensive we have");
            inventory.addItem("Beans", 1.2, "Kidney shaped brown things stored in shiny silver cylinder");
            inventory.addItem("Apple", 1599, "This year's model, expires in a year");
            inventory.addItem("Beer", 2.5, "It bubbles, it fizzes!");
            inventory.addItem("Coffee", 15.5, "Finest brand!");
            inventory.addItem("Suggar", 11, "Makes things sweet");
            inventory.addItem("Muffins", 3.2, "No raisins included");

            PrintMessage.Hello();
            PrintMessage.Beginning();

            bool inTheShopLoop = true;
            while (inTheShopLoop) {
                string[] lines = Console.ReadLine().ToLower().Split(' ');
                switch (lines[0])
                {
                    case "browse":
                        inventory.Browse();
                        PrintMessage.BrowsingActions();
                        break;
                    case "add":
                        inventory.AddToCart(int.Parse(lines[1]), lines[2]);
                        break;
                    case "remove":
                        inventory.RemoveFromCart(int.Parse(lines[1]), lines[2]);
                        break;
                    case "basket":
                        inventory.Basket();
                        break;
                    case "total":
                        inventory.Total();
                        break;
                    case "exit":
                        inTheShopLoop = false;
                        break;
                    default:
                        PrintMessage.Confused();
                        PrintMessage.Beginning();
                        break;
                }
            }
            Exit();
        }
        
        static void Exit() {
            // GTFO
        }
    }
}
