using ConsoleShoppingBasket.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoppingBasket.Shop
{
    class Cart : Inventory
    {
        public List<CartItem> list = new List<CartItem>();
        public void AddItem(CartItem item)
        {
            list.Add(item);
        }

        public void Browse()
        {
            foreach (CartItem item in list)
            {
                Console.WriteLine($"{item.Name} \t${item.Price:0.00}\t {item.Description}");
            }
        }
        public void Basket()
        {
            if (list.Sum(x => x.InBasket) > 0)
            {
                foreach (CartItem item in list)
                {
                    if(item.InBasket > 0)
                        Console.WriteLine($"{item.InBasket}x\t{item.Name}\t${item.Price:0.00}\t${item.Price * item.InBasket:0.00}");
                }
            }
            else PrintMessage.EmptyBasket();
        }
        public void AddToBasket(int amount, string item)
        {
            var select = list.FirstOrDefault(x => x.Name.ToLower() == item);
            if (select == null)
            {
                PrintMessage.WeDontHave(item);
            }
            else
            {
                select.InBasket = select.InBasket + amount;
                PrintMessage.AddedItem(amount + "x " + select.Name);
            }
        }
        public void RemoveFromBasket(int amount, string item)
        {
            var select = list.FirstOrDefault(x => x.Name.ToLower() == item);
            if (select == null)
            {
                PrintMessage.WeDontHave(item);
            }
            else
            {
                select.InBasket = select.InBasket - amount;
                if (select.InBasket < 0) select.InBasket = 0;
                PrintMessage.RemovedItem(amount + "x " + select.Name);
            }
        }
        public void Total()
        {
            PrintMessage.CartTotal($"${list.Sum(x => x.Price * x.InBasket):0.00}");
        }
    }
}
