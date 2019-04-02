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
        public List<InventoryItem> list = new List<InventoryItem>();
        
        public void AddItem(InventoryItem item)
        {
            list.Add(item);
        }
    }
}
