using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_LINQ
{
    internal class Employee : System.IComparable
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public int Age { get; set; }

        #region System.IComparable members

        public int CompareTo(object obj)
        {
            Employee otherEmployee = obj as Employee;
            return this.Id.CompareTo(otherEmployee.Id);
        }

        #endregion
    }
}
