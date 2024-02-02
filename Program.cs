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

            item1.displayItem();
            item2.displayItem();

            item1.purchase();
            item2.purchase();

            Write("\nPress any key to continue...");
            ReadKey();
        }
    }
}
