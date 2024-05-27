using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_conFW_Destructor_IDisposable
{
    // GUIDELINES TO IMPLEMENT THE IDisposable Interface
    // 1. Define a Dispose() method
    // 2. Move all code from the Destructor into the Dispose() method
    // 3. Define a flag to identify if the object has been disposed
    // 4. Initialize the flag in the Constructor
    // 5. Change the flag status in the Dispose method
    // 6. Check the flag status in EVERY METHOD (including the Dispose)
    // 7. Convert all non-private datafields into Properties (to provide encapsulation features)
    // 8. Check the flag status in EVERY PROPERTY's GET and SET accessor.
    // 9. Enforce that the Dispose() method is called for non-disposed objects.
    // FOR BETTER RESOURCE MANAGEMENT
    // 10. SuppressFinalization for the current object in the Dispose method by calling GC.SuppressFinalize()
    //     inside the Dispose() method.
    internal class Employee 
        : System.IDisposable
    {
        // Data Field
        private int _Id;
        private string _Name;

        private static int counter;

        // Property
        public int Id
        {
            get
            {
                this.CheckIfDisposed();

                return _Id;
            }
        }

        public string Name
        {
            get
            {
                this.CheckIfDisposed();

                return _Name;
            }
            set
            {
                this.CheckIfDisposed();

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                _Name = value;
            }
        }

        // Type Constructor
        static Employee()
        {
            Employee.counter = 0;
        }

        // Instance Constructor

        public Employee(string name)
        {
            this._isDisposed = false;                   // newly instantiated object is "NOT DISPOSED"
            this._Id = ++Employee.counter;
            this._Name = name;

            Console.WriteLine();
            Console.WriteLine("--- Issue an Appointment Letter");
            Console.WriteLine("--- Assign to a Team");
            Console.WriteLine("--- Assign the Manager");
            Console.WriteLine("--- Issue the Company Laptop, and ID Card");
            Console.WriteLine("--- Give a Training");
            Console.WriteLine($"Employee {this._Id} Instantiated Successfully!");
        }

        public void Work()
        {

            this.CheckIfDisposed();

            Console.WriteLine($"Employee {this.Name.ToUpper()} [ {this._Id}] is working today!");
        }

        #region System.IDisposable members

        private bool _isDisposed;

        private void CheckIfDisposed()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(
                    $"Employee {this._Id}",                                     // objectName
                    "This employee is no longer available in the system");      // message
            }
        }

        // NOTE: Similar to the signature of the Destructor
        public void Dispose()
        {
            this.CheckIfDisposed();

            Console.WriteLine("--- Recieved all company material");
            Console.WriteLine("--- Do full and final settlement");
            Console.WriteLine("--- Transfer all roles and responsibilites to the Manager/Replacement");

            this._isDisposed = true;                   // this object is "DISPOSED"
            Console.WriteLine($"Employee {this._Id} has been DISPOSED successfully!");


            // Inform the CLR to de-register the Destructor from the call-stack when destroying the object
            System.GC.SuppressFinalize(this);
        }

        #endregion

        ~Employee()
        {
            //Console.WriteLine();
            //Console.WriteLine("--- Recieved all company material");
            //Console.WriteLine("--- Do full and final settlement");
            //Console.WriteLine("--- Transfer all roles and responsibilites to the Manager/Replacement");
            //Console.WriteLine($"Employee {this._Id} has been destroyed successfully!");

            // Enforce that the Dispose() method is called for non-disposed objects.
            if(!this._isDisposed)
            {
                this.Dispose();
            }

            Console.WriteLine();
            Console.WriteLine($"Employee {this._Id} has been FINALIZED successfully!");
        }
    }
}
