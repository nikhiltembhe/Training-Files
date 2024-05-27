using System;

namespace cs_con_ReferenceTypes
{
    // Base Type
    internal class Employee
    {
        public const string CompanyName = "Microsoft";

        // Attributes / Qualities of the data type "Employee" (use nouns)
        public int EmployeeId;
        public string EmployeeName;
        public decimal Salary;
        public Designations Designation;

        // Behaviour of the data type "Employee" (use verbs)
        virtual public void Work()
        {
            Console.WriteLine("Employee with ID = {0} is working today", this.EmployeeId);
        }

        override public string ToString()
        {
            string output = "";
            output += $"  ID: {this.EmployeeId}";
            output += $"\n  Name: {this.EmployeeName}";
            output += $"\n  Salary: {this.Salary:C}";
            output += $"\n  Designation: {this.Designation}";

            return output;
        }
    }
}
