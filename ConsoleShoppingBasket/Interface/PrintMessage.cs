using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleShoppingBasket.Interface;

namespace ConsoleShoppingBasket.Interface
{
    public class PrintMessage : ConsolePresets
    {
        public static void Hello() =>
            WriteLine("Welcome to our Convenient Console Store");
        public static void Beginning() =>
            Suggest("Start with commands like: ", "browse, basket, total, exit");
        public static void BrowsingActions() =>
            Suggest("To add to cart use command like: ", "add 2 banana");
        public static void WeHave() =>
            Message("Goods currently in stock:");
        public static void CurrentlyInBasket() =>
            Message("Currently in your basket:");     
        public static void EmptyBasket() =>
            Error("Basket is empty. Add some now!");  
        public static void WeDontHave(string item) =>
            Error("Sorry, we don't have " + item);
        public static void AddedItem(string item) =>
            Message("Added " + item + " to basket");
        public static void RemovedItem(string item) =>
            Message("Now you have " + item + " in basket");
        public static void Confused() =>
            Error("Sorry, bad command");
    }
}
