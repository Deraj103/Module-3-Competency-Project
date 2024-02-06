using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Module_3_Competency_Project
{
    internal class CustomerClass
    {
        private double custID;
        private string fName;
        private string lName;

        public CustomerClass(double ID, string fN, string lN)
        {
            this.custID = ID;
            this.fName = fN;
            this.lName = lN;
        }

        public string displayCust() => $"{custID}, {fName} {lName}";

    }
}
