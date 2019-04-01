using ConsoleShoppingBasket.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoppingBasket.Shop
{
    class Inventory<N, P, D, B>
    {
        private List<int> index = new List<int>();
        private List<N> itemNames = new List<N>();
        private List<P> itemPrice = new List<P>();
        private List<D> itemDescription = new List<D>();
        private List<Double> inBasket = new List<Double>();

        public void addItem(N name, P price, D description){
            index.Add(index.Count);
            itemNames.Add(name);
            itemPrice.Add(price);
            itemDescription.Add(description);
            inBasket.Add(0);
        }
        /*public N getName(int i) {
            return itemNames[i];
        }
        public P getPrice(int i)
        {
            return itemPrice[i];
        }
        public D getDescrription(int i)
        {
            return itemDescription[i];
        }*/
        internal void addToCart(int i, Double ammount)
        {
            inBasket[i] = inBasket[i]+ammount;
        }
        internal void removeFromCart(int i, Double ammount)
        {
            inBasket[i] = inBasket[i] - ammount;
            if (inBasket[i] < 0) inBasket[i] = 0;
        }
        public void Browse()
        {
            PrintMessage.WeHave();
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
                PrintMessage.CurrentlyInBasket();
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

        public void AddToCart(int number, string item)
        {
            bool founditem = false;
            foreach (int i in index)
            {
                if (!founditem && itemNames[i].ToString().ToLower() == (string)(object)item)
                {
                    founditem = true;
                    addToCart(i, number);
                    PrintMessage.AddedItem(number + "x " + itemNames[i]);
                }
            }
            if(!founditem)
            {
                PrintMessage.WeDontHave(item);
            }

        }
        public void RemoveFromCart(int number, string item)
        {
            bool founditem = false;
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
            }

        }

        internal void Total()
        {
            throw new NotImplementedException();
        }
    }
}
