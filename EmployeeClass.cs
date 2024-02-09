using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Module_3_Competency_Project
{
    internal class EmployeeClass
    {
        private double empID;
        private string fName;
        private string lName;

        public EmployeeClass(double ID, string fN, string lN)
        {
            this.empID = ID;
            this.fName = fN;
            this.lName = lN;
        }

        public override string ToString()
        {
            return $"{empID}, {fName} {lName}";
        }

    }
}
