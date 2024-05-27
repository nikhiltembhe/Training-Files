using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Indexer
{
    internal class MyData
    {
        // Aggregated Collection
        private string[] _names;

        public MyData()
        {
            _names = new string[] { 
                "First Employee",           // [0]
                "Second Employee",          // [1]
                "Third Employee",           // [2]
                "Fourth Employee"           // [3]
            };

            // _names[3] = _names[3].ToUpper();
        }

        // Property 
        public string FirstName
        {
            get
            {
                return _names[0];
            }
            set
            {
                _names[0] = value;
            }
        }

        // Method to GET
        public string GetName(int id)
        {
            return _names[id];
        }

        // Method to SET
        public void SetName(int id, string newname)
        {
            _names[id] = newname;
        }


        // Indexer
        public string this[int id]
        {
            get
            {
                return _names[id];
            }
            set
            {
                _names[id] = value;
            }
        }

        public void DisplayNames()
        {
            foreach(string name in _names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

    }
}
