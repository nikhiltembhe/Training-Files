using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Destructor_IDisposable
{
    internal class Employee : System.IDisposable
    {
        public int Id { get; private set; }

        private string _Name;
        public string Name
        {
            get
            {
                // Check if the object is already disposed, before executing the logic of the method
                if (isDisposing)
                {
                    throw new Exception($"Employee with ID = {this.Id} is disposed.  So, cannot access NAME!");
                }

                return _Name;
            }
            private set
            {
                // Check if the object is already disposed, before executing the logic of the method
                if (isDisposing)
                {
                    throw new Exception($"Employee with ID = {this.Id} is disposed.  So, cannot change NAME!");
                }
            
                _Name = value;
            }
        }

        // Data Field
        private decimal _Salary;

        // Property
        public decimal Salary
        {
            get
            {
                // Check if the object is already disposed, before executing the logic of the GET Accessor
                if (isDisposing)
                {
                    throw new Exception($"Employee with ID = {this.Id} is disposed.  So, cannot access Salary!");
                }
                
                return _Salary;
            }
            set
            {
                // Check if the object is already disposed, before executing the logic of the SET Accessor
                if (isDisposing)
                {
                    throw new Exception($"Employee with ID = {this.Id} is disposed.  So, cannot change Salary!");
                }

                _Salary = value;
            }
        }

        // Instance Constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("-- Issue Employee ID Card");
            Console.WriteLine("-- Conduct an Induction Training Program");
            Console.WriteLine("-- Assign a Workstation");
            Console.WriteLine($"Employee Object with ID {this.Id} is instantiated");
            Console.WriteLine();

            isDisposing = false;
        }

        // Instance Destructor/Finalizer
        ~Employee()
        {
            // Enforce that the Dispose() method is called implicitly (if not already invoked)
            if(!isDisposing)
            {
                this.Dispose();
            }

            Console.WriteLine($"Employee Object with ID {this.Id} is destroyed");
        }

        // Method
        public void Work()
        {
            // Check if the object is already disposed, before executing the logic of the method
            if (isDisposing)
            {
                throw new Exception($"Employee with ID = {this.Id} is disposed.  So, cannot work!");
            }

            Console.WriteLine($"Employee ID: {this.Id} is working today!");
            Console.WriteLine();
        }

        #region System.IDisposable members

        private bool isDisposing { get; set; }

        public void Dispose()
        {
            // Check if the object is already disposed, before executing the logic of the method
            if (isDisposing)
            {
                throw new Exception($"Disposing an object with ID: {this.Id} already disposed!");
            }

            Console.WriteLine("-- Surrender all assigned Assets");
            Console.WriteLine("-- Recover any dues from the employee");
            Console.WriteLine("-- Final Salary is calculated and deposited into the bank");
            Console.WriteLine("-- Issue the Work Experience Letter");
            Console.WriteLine($"Employee Object with ID {this.Id} is DISPOSED");
            Console.WriteLine();

            isDisposing = true;

            // Remove the call to the Destructor from the Call Stack
            // (don't wait for the destructor to execute - GC can clear the memory) 
            System.GC.SuppressFinalize(this);
        }

        #endregion
    }
}
