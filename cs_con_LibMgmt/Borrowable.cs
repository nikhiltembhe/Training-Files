using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmt
{
    /// <summary>
    ///     The Decorator Pattern
    /// </summary>
    internal class Borrowable
    {
        private LibraryItem _libraryItem;

        private System.Collections.ArrayList _borrowers;


        public int ItemID
        {
            get
            {
                return _libraryItem.LibraryItemId;
            }
        }

        public LibraryItem LibraryItem
        {
            get
            {
                return _libraryItem;
            }
        }

        public Borrowable(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
            _borrowers = new ArrayList();               // Early Instantiation Pattern
        }

        public void BorrowItem(string borrowerName)
        {
            _borrowers.Add(borrowerName);
            _libraryItem.NumberOfCopies--;
        }

        public void ReturnItem(string borrwerName)
        {
            _borrowers.Remove(borrwerName);
            _libraryItem.NumberOfCopies++;
        }


        public override string ToString()
        {
            string output = _libraryItem.ToString();
            if(_borrowers.Count != 0)
            {
                output += "\n\tList of Borrowers:";
                foreach(string borrowerName in _borrowers)
                {
                    output += $"\t{borrowerName}\n";
                }
            }
            return output;
        }
    }
}
