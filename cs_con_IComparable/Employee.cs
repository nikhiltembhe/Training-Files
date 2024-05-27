using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IComparable
{
    internal class Employee : System.IComparable
    {       
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }



        #region System.IComparable members

        /// <summary>
        ///     Called during any Comparison or Sorting operations of the Employee Object
        /// </summary>
        /// <param name="obj">Object to compare against with the current object </param>
        /// <returns>
        ///     0           this    equal to      otherEmployee
        ///     -negative   this    lesser than   otherEmployee
        ///     +positive   this    greater than  otherEmployee OR otherEmployee == NULL
        /// </returns>
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else
            {
                Employee empOther = obj as Employee;
                return this.EmployeeID.CompareTo(empOther.EmployeeID);      // ASC order of EmployeeID
                // return empOther.EmployeeID.CompareTo(this.EmployeeID);   // DESC order of EmployeeID
            }
        }

        #endregion
    }
}
