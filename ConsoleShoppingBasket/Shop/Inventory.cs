using ConsoleShoppingBasket.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoppingBasket.Shop
{
    class Inventory
    {
        private List<int> index = new List<int>();
        private List<InventoryItem> list = new List<InventoryItem>();
        
        public void AddItem(InventoryItem item)
        {
            index.Add(index.Count);
            list.Add(item);
        }

        public void Total()
        {
            PrintMessage.EmptyBasket();
        }
        /*
       public void Browse()
       {
           foreach (int i in index)
           {
               Console.Write(itemNames[i]);
               Console.Write("\t$" + itemPrice[i]);
               Console.WriteLine("\t" + itemDescription[i]);
           }
       }
       public void Basket()
       {
           if (inBasket.Sum() > 0) {
               foreach (int i in index)
               {
                   if (inBasket[i] > 0)
                   {
                       Console.Write(inBasket[i]);
                       Console.Write("x \t" + itemNames[i]);
                       Console.Write("\t$" + itemPrice[i]);
                       Console.WriteLine("\t$" + itemPrice[i]);
                       //Console.WriteLine("\t$" + itemPrice[i] * inBasket[i]));
                   }
               }
           }
           else PrintMessage.EmptyBasket();
       }


       internal void Total()
       {
           throw new NotImplementedException();
       }*/
    }
}
