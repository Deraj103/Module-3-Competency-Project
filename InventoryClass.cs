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
        private double itemID;
        private string itemName;
        private double itemPrice;
        private double itemQuantity;
        //private string reply;
        private double purchaseCost;
        private double totalCost;

        public InventoryClass(double i, string n, double p, double q)
        {
            this.itemID = i;
            this.itemName = n;
            this.itemPrice = p;
            this.itemQuantity = q;
        }

        // Getters
        public double getItemID() { return itemID; }
        public string getItemName() { return itemName; }
        public double getItemPrice() { return itemPrice; }
        public double getItemQuantity() { return itemQuantity; }
        public double getPurchaseCost() { return purchaseCost; }
        public double getTotalCost() { return totalCost;}

        // Setters
        public void setGetItem(double i)
        {
            itemID = i;
        }

        public void setItemName(string n)
        {
            itemName = n;
        }

        public void setItemPrice(double p)
        {
            itemPrice = p;
        }

        public void setItemQuantity(double q)
        {
            itemQuantity = q;
        }

        public void setPurchaseCost(double pC)
        {
            purchaseCost = pC;
        }

        public void setTotalCost(double tC)
        {
            totalCost = tC;
        }

        //public string displayItem() => $"Item {itemID} {itemName}, {itemPrice:C}, quantity: {itemQuantity}";

        public override string ToString()
        {
            return $"Item {itemID} {itemName}, {itemPrice:C}, quantity: {itemQuantity}";
        }

        public (double, double) purchase()
        {
            double qtyReq;

            Write("How many do you want? ");
            qtyReq = double.Parse(ReadLine());

            if (itemQuantity < qtyReq)
            {
                WriteLine("There is not enough quantity of that item. Please request a different amount.");
            }
            else
            {
                itemQuantity -= qtyReq;
                purchaseCost = qtyReq * itemPrice;
                totalCost += purchaseCost;
            }

            return (purchaseCost, totalCost);

            //do
            //{


            //    WriteLine("\nWould you like anything else? Yes(Y) or No(N)");
            //    reply = ReadLine();
            //} while (reply == "Y");
        }
    }
}
