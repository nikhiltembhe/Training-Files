using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace cs_con_INotifyPropertyChanged
{
    internal class Employee
        : System.ComponentModel.INotifyPropertyChanged
    {

        #region System.ComponenetModel.INotifyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion



        public int Id { get; private set; }


        public string Name { get; set; } = String.Empty;

        private string _designation;
        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Designation"));
                }
                _designation = value;
            }
        }


        private decimal _salary;
        public decimal Salary 
        {
            get
            {
                return _salary;
            }
            private set
            {
                if (this.PropertyChanged != null)   // check if event is subscribed
                {
                    //-- Raise the event
                    // PropertyChangedEventArgs e = new PropertyChangedEventArgs("Salary");
                    // this.PropertyChanged(this, e);
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Salary"));
                }

                _salary = value;
            }
        }

        public Employee(int id, decimal salary)
        {
            Id = id;
            _salary = salary;
            // this.Name = String.Empty;
        }

        public void Promote(string newDesignation)
        {
            this.Designation = newDesignation;
            this.Salary += (Salary * 0.20M);
            Console.WriteLine($"Promoted the Employee {this.Id} with a 20% Raise in the Salary");
        }
    }
}
