using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IEnumerator
{
    internal class Company : System.Collections.IEnumerator
    {
        private System.Collections.ArrayList _employees;
        public string CompanyName { get; private set; }


        #region System.Collections.IEnumerator members

        private int _currentPosition;

        public object Current
        {
            get
            {
                return _employees[_currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (_currentPosition < _employees.Count - 1)
            {
                _currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _currentPosition = -1;
        }

        #endregion


        public Company(string companyname)
        {
            this.CompanyName = companyname;
            this._employees = new System.Collections.ArrayList();
        }

        public System.Collections.ArrayList this[string branchName]
        {
            get
            {
                System.Collections.ArrayList empFoundCollection = new System.Collections.ArrayList();

                foreach(Employee emp in _employees)
                {
                    if(emp.BranchName == branchName)
                    {
                        empFoundCollection.Add(emp);
                    }
                }

                return empFoundCollection;
            }
        }


        public Employee this[int findID]
        {
            get
            {
                Employee empFound = null;

                foreach (Employee emp in this._employees)
                {
                    if (emp.EmployeeID == findID)
                    {
                        empFound = emp;
                        break;          // no need to continue searching for the employee
                    }
                }

                return empFound;
            }
        }

        public void AddEmployee(Employee newEmployee)
        {
            this._employees.Add(newEmployee);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"List of Employees in : {this.CompanyName}");
            foreach(Employee emp in this._employees)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.EmployeeName} {emp.BranchName}");
            }
        }
    }
}
