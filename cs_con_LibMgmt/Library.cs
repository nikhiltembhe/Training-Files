using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;                              // to use LINQ and LAMBDA extensions.

namespace cs_con_LibMgmt
{
    internal class Library
        : System.Collections.IEnumerable
    {
        public string LibraryName { get; private set; }
        private List<Borrowable> _borrowables;

        public Library(string libraryName)
        {
            this.LibraryName = libraryName;
            _borrowables = null;                            // Late Instantiation Pattern
        }

        public void Add(LibraryItem item)
        {
            // Null-Check to address the Late Instantiation Pattern
            if(_borrowables == null)
            {
                _borrowables = new List<Borrowable>();
            }
            _borrowables.Add(new Borrowable(item));
        }


        #region System.Collections.IEnumerable members

        public IEnumerator GetEnumerator()
        {
            // Null-Check to address the Late Instantiation Pattern
            if (_borrowables != null)
            {
                foreach (Borrowable borrowable in _borrowables)
                {
                    yield return borrowable;
                }
            }
            else
            {
                yield break;
            }
        }

        #endregion

        public LibraryItem this[int id]
        {
            get
            {
                LibraryItem libraryItem = null;

                foreach(var item in _borrowables)
                {
                    if(item.ItemID == id)
                    {
                        libraryItem = item.LibraryItem;
                        break;
                    }
                }

                return libraryItem;
            }
        }

        public void DisplayLibraryItems()
        {
            // Null-Check to address the Late Instantiation Pattern
            if (_borrowables == null)
            {
                Console.WriteLine("No items in the library!");
            }
            else
            {
                Console.WriteLine($"------- {this.LibraryName.ToUpper()} -------");
                foreach (var item in _borrowables)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("===============");
                }
            }
        }

        public void Borrow(int itemId, string borrowerName)
        {
            // Null-Check to address the Late Instantiation Pattern
            if (_borrowables == null)
            {
                _borrowables = new List<Borrowable>();
            }

            var item = _borrowables.SingleOrDefault(i => i.ItemID == itemId);
            if(item != null)
            {
                item.BorrowItem(borrowerName);
                Console.WriteLine($"{item.ItemID} has been BORROWED successfully by {borrowerName}");
            }
            else
            {
                Console.WriteLine($"Item with ID = {itemId} was not found in the Library!");
            }
        }

        public void Return(int itemId, string borrowerName)
        {
            // Null-Check to address the Late Instantiation Pattern
            if (_borrowables == null)
            {
                _borrowables = new List<Borrowable>();
            }

            var item = _borrowables.SingleOrDefault(i => i.ItemID == itemId);
            if (item != null)
            {
                item.ReturnItem(borrowerName);
                Console.WriteLine($"{item.ItemID} has been RETURNED successfully by {borrowerName}");
            }
            else
            {
                Console.WriteLine($"Item with ID = {itemId} was not found in the Library!");
            }
        }

    }
}
