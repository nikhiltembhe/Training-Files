using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Collections.Specialized;
using System.ComponentModel;

namespace cs_con_INotifyCollectionChanged
{
    // LATE INSTANTIATION PATTERN.

    internal class Company
        : System.Collections.IEnumerable, 
          System.ComponentModel.INotifyPropertyChanged,
          System.Collections.Specialized.INotifyCollectionChanged
    {
        private List<Employee> _employees;


        #region System.ComponentModel.INotifyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region System.Collections.Specialized.INotifyCollectionChanged members

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        #endregion


        private string _companyName;

        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            private set
            {
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("CompanyName"));
                }
                _companyName = value;
            }
        }

        public Company(string companyName)
        {
            _companyName = companyName;
            _employees = null;                              // defer/postponing the instantion of the object
        }

        public void Add(Employee newEmployee)
        {
            // Late-Instation Pattern: instantiate only when really required.
            if(_employees == null)
            {
                _employees = new List<Employee>();
            }

            _employees.Add(newEmployee);

            // check if event is subscribed
            if (this.CollectionChanged != null)
            {
                // Raise the event!
                this.CollectionChanged(
                    this,                                           // whose collection got changed.
                    new NotifyCollectionChangedEventArgs(
                        NotifyCollectionChangedAction.Add,          // what action was done on the collection (e.Action)
                        newEmployee));                              // which object was impacted (in e.NewItems)
            }
        }

        public void Remove(Employee existingEmployee)
        {
            // Late-Instantion Pattern: check before consumption
            if (_employees != null)
            {
                _employees.Remove(existingEmployee);

                // check if event is subscribed
                if (this.CollectionChanged != null)
                {
                    // Raise the event!
                    this.CollectionChanged(
                        this,                                           // whose collection got changed.
                        new NotifyCollectionChangedEventArgs(
                            NotifyCollectionChangedAction.Remove,       // what action was done on the collection (e.Action)
                            existingEmployee));                         // which object was impacted (in e.OldItems)
                }
            }
        }



        // Indexer
        public Employee this[string nameOfEmployeeToFind]
        {
            get
            {
                Employee empFound = null;
                
                foreach(Employee emp in _employees)
                {
                    if(emp.Name == nameOfEmployeeToFind)
                    {
                        empFound = emp;
                        break;
                    }
                }

                Employee empFound2 = (from e in _employees
                                      where e.Name == nameOfEmployeeToFind
                                      select e).FirstOrDefault();

                Employee empFound3 = _employees.FirstOrDefault(e => e.Name == nameOfEmployeeToFind);

                return empFound;
            }
        }


        #region System.Collections.IEnumerable members

        public IEnumerator GetEnumerator()
        {
            // Late-Instation Pattern: Check before usage!
            if (_employees != null)
            {
                foreach (Employee employee in _employees)
                {
                    yield return employee;
                }
            }
            else
            {
                yield break;
            }
        }

        #endregion
    }
}
