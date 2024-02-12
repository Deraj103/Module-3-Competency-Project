using Module_3_Competency_Project_Purchases;
using System;
using System.CodeDom;
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
        private double purchaseCost;
        public static double totalCost;

        // constructor
        public InventoryClass(double i, string n, double p, double q)
        {
            this.itemID = i;
            this.itemName = n;
            this.itemPrice = p;
            this.itemQuantity = q;
        }

        // getters
        public double getItemID() { return itemID; }
        public string getItemName() { return itemName; }
        public double getItemPrice() { return itemPrice; }
        public double getItemQuantity() { return itemQuantity; }
        public double getPurchaseCost() { return purchaseCost; }
        public double getTotalCost() { return totalCost; }

        // displays the item info
        public override string ToString()
        {
            return $"Item {itemID} {itemName}, {itemPrice:C}, quantity: {itemQuantity}";
        }

        // method to calculate the purchase cost
        public double purchase(double qty)
        {
            if (itemQuantity < qty)
            {
                WriteLine("Not enough inventory in stock, no sale.");
                totalCost = 0;
            }
            else
            {
                itemQuantity -= qty;
                purchaseCost = qty * itemPrice;
                totalCost += purchaseCost;
            }

            return totalCost;
        }
    }
}
