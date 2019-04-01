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

            var shop = new Cart();

            shop.AddItem(new InventoryItem { Name = "Banana", Price = 2.2, Description = "Yellow and with nice curve" });
            shop.AddItem(new InventoryItem { Name = "Milk", Price = 3.2, Description = "Goes well with coffee" });
            shop.AddItem(new InventoryItem { Name = "Bread", Price = 4, Description = "The most expensive we have" });
            shop.AddItem(new InventoryItem { Name = "Beans", Price = 1.2, Description = "Kidney shaped brown things stored in shiny silver cylinder" });
            shop.AddItem(new InventoryItem { Name = "Apple", Price = 1599, Description = "This year's model, expires in a year" });
            shop.AddItem(new InventoryItem { Name = "Beer", Price = 2.5, Description = "It bubbles, it fizzes!" });
            shop.AddItem(new InventoryItem { Name = "Coffee", Price = 15.5, Description = "Finest brand!" });
            shop.AddItem(new InventoryItem { Name = "Suggar", Price = 11, Description = "Makes things sweet" });
            shop.AddItem(new InventoryItem { Name = "Muffins", Price = 3.2, Description = "No raisins included" });
            
            PrintMessage.Hello();
            PrintMessage.Beginning();

            bool inTheShopLoop = true;
            while (inTheShopLoop) {
                string[] lines = Console.ReadLine().ToLower().Split(' ');
                switch (lines[0])
                {
                    case "browse":
                        PrintMessage.WeHave();
                        shop.Browse();
                        PrintMessage.BrowsingActions();
                        break;
                    case "add":
                        shop.AddToBasket(int.Parse(lines[1]), lines[2]);
                        break;
                    case "remove":
                        shop.RemoveFromBasket(int.Parse(lines[1]), lines[2]);
                        break;
                    case "basket":
                        PrintMessage.CurrentlyInBasket();
                        shop.Basket();
                        break;
                    case "total":
                        shop.Total();
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
