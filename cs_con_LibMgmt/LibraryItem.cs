using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmt
{
    abstract class LibraryItem
    {
        static private int idCounter;

        public int LibraryItemId { get; private set; }

        public int NumberOfCopies { get; set; }

        static LibraryItem()
        {
            LibraryItem.idCounter = 0;
        }

        public LibraryItem()
        {
            this.LibraryItemId = ++LibraryItem.idCounter;
        }
    }
}
