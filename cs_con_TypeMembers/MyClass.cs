using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_TypeMembers
{
    /// <summary>
    ///     STEPS of Encapsulation:
    ///     1.  Authentication
    ///     2.  Authorization
    ///     3.  Validation
    ///     4.  Activity / Process
    ///     5.  Audit Logging
    /// </summary>

    internal class MyClass
    {
        // DATA FIELD / Attribute / Qualities ("Noun")
        public int Id;

        // METHOD / Behaviour ("Verb")
        public int GetId()
        {
            Console.WriteLine("GetId() called for object: {0}", this.Id);

            // Encapsulation: 1. 2. 3. 4. 5.
            return this.Id;
        }
        public void SetId(int newId)
        {
            // 1. Authentication
            // 2. Authorization

            // 3. Validation
            if(newId <= 0)
            {
                Console.WriteLine("Invalid Id.  Cannot be lesser than or equal to 0");
                return;
            }

            // 4. Process
            this.Id = newId;

            // 5. Audit Logging
            Console.WriteLine("Id was changed!");
        }


        private string Name;
        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string newName)
        {
            this.Name = newName;
        }


        // PROPERTY
        private decimal _Price;
        public decimal Price
        {
            get
            {
                // ENCAPSULATION: 1. 2. 3. 4. 5.
                Console.WriteLine("encapsulated logic of GET PRICE executed");
                return _Price;
            }
            set
            {
                // ENCAPSULATION: 1. 2. 3. 4. 5.
                Console.WriteLine("encapsulated logic of SET PRICE executed");
                _Price = value;
            }
        }
    }
}
