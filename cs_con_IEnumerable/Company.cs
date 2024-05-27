using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IEnumerable
{
    internal class Company : System.Collections.IEnumerable
    {

        private System.Collections.ArrayList _employees;
        public string CompanyName { get; private set; }

        #region System.Collections.IEnumerable members

        public System.Collections.IEnumerator GetEnumerator()
        {
            for(int i = 0; i < _employees.Count; i++)
            {
                yield return _employees[i];
            }

            // --- SAME AS ABOVE
            //foreach(Employee emp in this._employees)
            //{
            //    yield return emp;
            //}
        }

        #endregion

        public Company(string companyname)
        {
            this.CompanyName = companyname;
            this._employees = new System.Collections.ArrayList();
        }

        public void AddEmployee(Employee newEmployee)
        {
            this._employees.Add(newEmployee);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"List of Employees in : {this.CompanyName}");
            foreach (Employee emp in this._employees)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.EmployeeName} {emp.BranchName}");
            }
        }

    }
}
