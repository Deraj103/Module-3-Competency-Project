using Module_3_Competency_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Module_3_Competency_Project_Purchases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Module 3 Competency Project: Purchases by Jared Tims\n");

            // item instantiation
            InventoryClass item1 = new InventoryClass(123, "soda", 1.19, 50);
            InventoryClass item2 = new InventoryClass(987, "cookie", 1.50, 20);
            InventoryClass tempI = item1;

            // employee instantiation
            CustomerClass cust1 = new CustomerClass(768, "Mark", "Matthews");
            CustomerClass cust2 = new CustomerClass(567, "Jane", "Jones");
            CustomerClass tempC = cust1;

            // customer instantiation
            EmployeeClass emp1 = new EmployeeClass(1234, "Larry", "Lamb");
            EmployeeClass emp2 = new EmployeeClass(7654, "Nancy", "Nome");
            EmployeeClass tempE = emp1;

            WriteLine(item1.ToString());
            WriteLine(item2.ToString());

            WriteLine($"\nProcessing purchasses for Customer {tempC.displayCust()}");
            WriteLine(item1.ToString());
            item1.purchase();
            WriteLine(item2.ToString());
            item2.purchase();
            WriteLine($"Total purchase for customer {tempC.displayCust()}: {tempI.getTotalCost():C}");

            WriteLine("\nInventory");
            WriteLine(item1.ToString());
            WriteLine(item2.ToString());

            Write("\nPress any key to continue...");
            ReadKey();
        }
    }
}
