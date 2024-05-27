using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmt
{
    internal class Book : LibraryItem
    {
        public string BookTitle { get; private set; }

        public string[] Authors { get; private set; }

        /// <summary>
        ///     Book in the Library
        /// </summary>
        /// <param name="title">Title of the Book</param>
        /// <param name="numCopies">Number of Copies (default 1)</param>
        /// <param name="authors">(optional) Comma separated names of author(s)</param>
        public Book(string title, int numCopies = 1, params string[] authors)
        {
            this.BookTitle = title;
            base.NumberOfCopies = numCopies;

            this.Authors = (authors.Length > 0)
                           ? authors
                           : new string[] { "Anonymous" };
        }

        public override string ToString()
        {
            return $"Library Item ID: {base.LibraryItemId}\n"
                   + $"Book Title: {this.BookTitle}\n"
                   + $"Authors: {string.Join(", ", this.Authors)}\n"
                   + $"Number of Copies: {base.NumberOfCopies}";
        }
    }
}
