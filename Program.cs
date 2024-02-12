using Module_3_Competency_Project;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            // employee instantiation
            CustomerClass cust1 = new CustomerClass(768, "Mark", "Matthews");
            CustomerClass cust2 = new CustomerClass(567, "Jane", "Jones");

            // customer instantiation
            EmployeeClass emp1 = new EmployeeClass(1234, "Larry", "Lamb");
            EmployeeClass emp2 = new EmployeeClass(7654, "Nancy", "Nome");

            // temp object
            object temp = 0;
            // temp object that is used to check if a purchaser is a customer or a employee and displays it in customer info.
            object purchaserDescriptor;

            WriteLine(soda.ToString());
            WriteLine(cookie.ToString());

            //for loop that loops through each person
            for (int p = 0; p < 4; p++)
            {
                if (p == 0)
                {
                    temp = cust1;
                }
                else if (p == 1)
                {
                    temp = cust2;
                }
                else if (p == 2)
                {
                    temp = emp1;
                }
                else if (p == 3)
                {
                    temp = emp2;
                }
                // a method that checks for and assigns a purchaser descriptor value and displays it as a text
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
                    // an if statement that checks if temp is from employee class and calls a method to calculate employee discount
                    if (temp is EmployeeClass)
                    {
                        employeeDiscount();
                    }

                    WriteLine("\nInventory:");
                    WriteLine(soda.ToString());
                    WriteLine(cookie.ToString());

                    resetTotalCost();
                }
            }
            Write("\nPress any key to continue...");
            ReadKey();

            // a method that checks what class the purchaser is and assigns a text value to display it
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

            //calculates the total discount and discount total for employee purchases
            void employeeDiscount()
            {
                double discount = .25;
                double totalDiscount;
                double discountTotal;

                totalDiscount = soda.getTotalCost() * discount;
                WriteLine($"employee discount = {totalDiscount:c}");
                discountTotal = soda.getTotalCost() - totalDiscount;
                WriteLine($"total purchase after discount: {discountTotal:c}");
            }

            // resets total cost for new purchaser
            void resetTotalCost()
            {
                // to access static variables, there is no need to create any object of that class,
                // simply access the variable as: class_name.variable_name;
                InventoryClass.totalCost = 0;
            }
        }
    }
}
