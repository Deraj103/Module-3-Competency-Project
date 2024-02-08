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
        private double purchaseCost;
        private static double totalCost;

        // constructor
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
        public double getTotalCost() { return totalCost; }

        // displays the item information
        public override string ToString()
        {
            return $"Item {itemID} {itemName}, {itemPrice:C}, quantity: {itemQuantity}";
        }

        // calculates the purchase
        public void purchase()
        {
            double qtyReq;

            try
            {
                Write("How many do you want? ");
                qtyReq = double.Parse(ReadLine());

                if (itemQuantity < qtyReq)
                {
                    WriteLine("Not enough inventory in stock, no sale.");
                    totalCost = 0;
                }
                else
                {
                    itemQuantity -= qtyReq;
                    purchaseCost = qtyReq * itemPrice;
                    totalCost += purchaseCost;
                }
            }
            catch (Exception e)
            {
                WriteLine("Input string was not in a correct format.");
            }
            //finally
            //{
            //    itemQuantity -= qtyReq;
            //    purchaseCost = qtyReq * itemPrice;
            //    totalCost += purchaseCost;
            //}

        }
        // calculates the total discount and discount total for employee purchases.
        public void employeeDiscount()
        {
            double discount = .25;
            double totalDiscount;
            double discountTotal;

            totalDiscount = totalCost * discount;
            WriteLine($"Employee discount = {totalDiscount:C}");
            discountTotal = totalCost - totalDiscount;
            WriteLine($"Total purchase after discount: {discountTotal:C}");
        }

        // resets total cost for new purchaser.
        public double resetTotalCost()
        {
            totalCost = 0;

            return totalCost;
        }
    }
}
