using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Module_3_Competency_Project
{
    internal class InventoryClass
    {
        double itemID;
        string itemName;
        double itemPrice;
        double itemQuantity;
        string reply;

        public InventoryClass(double i, string n, double p, double q)
        {
            this.itemID = i;
            this.itemName = n;
            this.itemPrice = p;
            this.itemQuantity = q;
        }

        public void displayItem()
        {
            WriteLine($"Item {itemID} {itemName}, {itemPrice:C}, quantity: {itemQuantity}");
        }

        public void purchase()
        {
            double qtyReq;
            double purchaseCost;

            Write("How many do you want?");
            qtyReq = double.Parse(ReadLine());
            do
            {
                if (itemQuantity < qtyReq)
                {
                    WriteLine("There is not enough quantity of that item. Please request a different amount.");
                }
                else
                {
                    itemQuantity -= qtyReq;
                    purchaseCost = qtyReq * itemPrice;
                    WriteLine($"{purchaseCost:C}");
                }

                WriteLine("\nWould you like anything else? Yes(Y) or No(N)");
                reply = ReadLine();
            } while (reply == "Y");
        }
    }
}
