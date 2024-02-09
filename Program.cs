using Module_3_Competency_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Module_3_Competency_Project_Purchases
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double qty;

            WriteLine("Module 3 Competency Project: Purchases by Jared Tims\n");

            // item instantiation
            InventoryClass soda = new InventoryClass(123, "soda", 1.19, 50);
            InventoryClass cookie = new InventoryClass(987, "cookie", 1.50, 20);
            //InventoryClass tempI;

            // employee instantiation
            CustomerClass cust1 = new CustomerClass(768, "Mark", "Matthews");
            CustomerClass cust2 = new CustomerClass(567, "Jane", "Jones");
            //CustomerClass tempC;

            // customer instantiation
            EmployeeClass emp1 = new EmployeeClass(1234, "Larry", "Lamb");
            EmployeeClass emp2 = new EmployeeClass(7654, "Nancy", "Nome");
            //EmployeeClass tempE;
            // temp object
            object temp;
            object purchaserDescriptor;

            WriteLine(soda.ToString());
            WriteLine(cookie.ToString());

            //for loop - "p" for purchases
            for (int p = 0; p < 4; p++)
            {   // loop through pay cycles
                switch (p)
                {
                    case 0:
                        {
                            temp = cust1;
                            descriptorMethod();
                            WriteLine($"\nProcessing purchases for {purchaserDescriptor} {temp}");
                            WriteLine(soda);
                            Write("How many do you want? ");
                            try
                            {
                                qty = double.Parse(ReadLine());
                                soda.purchase(qty);
                            }
                            catch (Exception)
                            {
                                WriteLine("Input string was not in a correct format.");
                            }

                            WriteLine(cookie);
                            Write("How many do you want? ");
                            try
                            {
                                qty = double.Parse(ReadLine());
                                cookie.purchase(qty);
                            }
                            catch (Exception)
                            {
                                WriteLine("Input string was not in a correct format.");
                            }
                            finally
                            {
                                WriteLine($"Total purchase for {purchaserDescriptor} {temp}: {soda.getTotalCost():C}");
                                soda.getTotalCost();

                                WriteLine("\nInventory:");
                                WriteLine(soda.ToString());
                                WriteLine(cookie.ToString());

                                resetTotalCost();
                            }
                        }
                        break;
                    case 1:
                        {
                            temp = cust2;
                            descriptorMethod();
                            WriteLine($"\nProcessing purchases for {purchaserDescriptor} {temp}");
                            WriteLine(soda);
                            Write("How many do you want? ");
                            try
                            {
                                qty = double.Parse(ReadLine());
                                soda.purchase(qty);
                            }
                            catch (Exception)
                            {
                                WriteLine("Input string was not in a correct format.");
                            }

                            WriteLine(cookie);
                            Write("How many do you want? ");
                            try
                            {
                                qty = double.Parse(ReadLine());
                                cookie.purchase(qty);
                            }
                            catch (Exception)
                            {
                                WriteLine("Input string was not in a correct format.");
                            }
                            finally
                            {
                                WriteLine($"Total purchase for {purchaserDescriptor} {temp}: {soda.getTotalCost():C}");
                                soda.getTotalCost();

                                WriteLine("\nInventory:");
                                WriteLine(soda.ToString());
                                WriteLine(cookie.ToString());
                            }
                        }
                        break;
                    case 2:
                        {
                            temp = emp1;
                        }
                        break;
                    case 3:
                        {
                            temp = emp2;
                        }
                        break;
                    default:
                        break;
                }

                void descriptorMethod()
                {
                    if (temp is CustomerClass)
                    {
                        purchaserDescriptor = "Customer";
                    }
                    else
                    {
                        purchaserDescriptor = "Employee";
                    }
                }

                ////calculates the total discount and discount total for employee purchases.
                //double employeeDiscount()
                //{
                //    double discount = .25;
                //    double totalDiscount;
                //    double discountTotal;

                //    totalDiscount = getTotalCost() * discount;
                //    WriteLine($"Employee discount = {totalDiscount:C}");
                //    discountTotal = getTotalCost() - totalDiscount;
                //    WriteLine($"Total purchase after discount: {discountTotal:C}");
                //}

                // resets total cost for new purchaser.
                void resetTotalCost()
                {
                    soda.totalCost = 0;

                    //InventoryClass reset = new InventoryClass(123, "soda", 1.19, 50);
                    //reset.totalCost = 0;
                }



                //switch (p)
                //{
                //    case 0:
                //        tempI = item1;
                //        tempC = cust1;
                //        // displays the customer's info and asks customer how many of each product and calculates the cost.
                //        WriteLine($"\nProcessing purchases for Customer {tempC.displayCust()}");
                //        WriteLine(item1.ToString());
                //        item1.purchase();
                //        WriteLine(item2.ToString());
                //        item2.purchase();
                //        WriteLine($"Total purchase for customer {tempC.displayCust()}: {tempI.getTotalCost():C}");
                //        // a method to reset the total cost for the next purchase
                //        tempI.resetTotalCost();
                //        // displays what is remaining in inventory
                //        WriteLine("\nInventory");
                //        WriteLine(item1.ToString());
                //        WriteLine(item2.ToString());
                //        break;
                //    case 1:
                //        tempI = item1;
                //        tempC = cust2;
                //        // displays the customer's info and asks customer how many of each product and calculates the cost.
                //        WriteLine($"\nProcessing purchases for Customer {tempC.displayCust()}");
                //        WriteLine(item1.ToString());
                //        item1.purchase();
                //        WriteLine(item2.ToString());
                //        item2.purchase();
                //        WriteLine($"Total purchase for customer {tempC.displayCust()}: {tempI.getTotalCost():C}");
                //        // a method to reset the total cost for the next purchase
                //        tempI.resetTotalCost();
                //        // displays what is remaining in inventory
                //        WriteLine("\nInventory");
                //        WriteLine(item1.ToString());
                //        WriteLine(item2.ToString());
                //        break;
                //    case 2:
                //        tempI = item1;
                //        tempE = emp1;
                //        // displays the customer's info and asks customer how many of each product and calculates the cost.
                //        WriteLine($"\nProcessing purchases for Customer {tempE.displayEmp()}");
                //        WriteLine(item1.ToString());
                //        item1.purchase();
                //        WriteLine(item2.ToString());
                //        item2.purchase();
                //        WriteLine($"Total purchase for customer {tempE.displayEmp()}: {tempI.getTotalCost():C}");
                //        // checks if purchaser is an employee
                //        if (tempE is EmployeeClass)
                //        {
                //            tempI.employeeDiscount();
                //        }
                //        // a method to reset the total cost for the next purchase
                //        tempI.resetTotalCost();
                //        // displays what is remaining in inventory
                //        WriteLine("\nInventory");
                //        WriteLine(item1.ToString());
                //        WriteLine(item2.ToString());
                //        break;
                //    case 3:
                //        tempI = item1;
                //        tempE = emp2;
                //        // displays the customer's info and asks customer how many of each product and calculates the cost.
                //        WriteLine($"\nProcessing purchases for Customer {tempE.displayEmp()}");
                //        WriteLine(item1.ToString());
                //        item1.purchase();
                //        WriteLine(item2.ToString());
                //        item2.purchase();
                //        WriteLine($"Total purchase for customer {tempE.displayEmp()}: {tempI.getTotalCost():C}");
                //        // checks if purchaser is an employee
                //        if (tempE is EmployeeClass )
                //        {
                //            tempI.employeeDiscount();
                //        }
                //        // a method to reset the total cost for the next purchase
                //        tempI.resetTotalCost();
                //        // displays what is remaining in inventory
                //        WriteLine("\nInventory");
                //        WriteLine(item1.ToString());
                //        WriteLine(item2.ToString());
                //        break;
                //    default:
                //        break;
                //}
            }
            Write("\nPress any key to continue...");
            ReadKey();
        }
    }
}
