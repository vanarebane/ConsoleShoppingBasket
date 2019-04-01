using ConsoleShoppingBasket.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoppingBasket.Shop
{
    class Cart : Inventory
    {/*
        internal void addToCart(int i, Double ammount)
        {
            inBasket[i] = inBasket[i] + ammount;
        }
        internal void removeFromCart(int i, Double ammount)
        {
            inBasket[i] = inBasket[i] - ammount;
            if (inBasket[i] < 0) inBasket[i] = 0;
        }*/

        public void Browse()
        {
            /*bool founditem = false;
            foreach (int i in index)
            {
                if (!founditem && itemNames[i].ToString().ToLower() == (string)(object)item)
                {
                    founditem = true;
                    removeFromCart(i, number);
                    PrintMessage.RemovedItem(inBasket[i] + "x " + itemNames[i]);
                }
            }
            if (!founditem)
            {
                PrintMessage.WeDontHave(item);
            }*/

            PrintMessage.WeDontHave("");
        }
        public void Basket()
        {
            /*bool founditem = false;
            foreach (int i in index)
            {
                if (!founditem && itemNames[i].ToString().ToLower() == (string)(object)item)
                {
                    founditem = true;
                    removeFromCart(i, number);
                    PrintMessage.RemovedItem(inBasket[i] + "x " + itemNames[i]);
                }
            }
            if (!founditem)
            {
                PrintMessage.WeDontHave(item);
            }*/

            PrintMessage.WeDontHave("");
        }
        public void AddToBasket(int number, string item)
        {
            /*bool founditem = false;
            foreach (int i in index)
            {
                if (!founditem && itemNames[i].ToString().ToLower() == (string)(object)item)
                {
                    founditem = true;
                    addToCart(i, number);
                    PrintMessage.AddedItem(number + "x " + itemNames[i]);
                }
            }
            if (!founditem)
            {
                PrintMessage.WeDontHave(item);
            }*/

            PrintMessage.WeDontHave(item);

        }
        public void RemoveFromBasket(int number, string item)
        {
            /*bool founditem = false;
            foreach (int i in index)
            {
                if (!founditem && itemNames[i].ToString().ToLower() == (string)(object)item)
                {
                    founditem = true;
                    removeFromCart(i, number);
                    PrintMessage.RemovedItem(inBasket[i] + "x " + itemNames[i]);
                }
            }
            if (!founditem)
            {
                PrintMessage.WeDontHave(item);
            }*/

            PrintMessage.WeDontHave(item);
        }
    }
}
