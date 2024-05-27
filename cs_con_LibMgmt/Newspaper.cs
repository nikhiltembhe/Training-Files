using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmt
{
    internal class Newspaper : LibraryItem
    {
        public readonly string NewspaperTitle;
        public DateTime PublishedOn { get; private set; }

        public Newspaper(string newspaperTitle, DateTime publishedOn)
        {
            NewspaperTitle = newspaperTitle;
            PublishedOn = publishedOn;
            base.NumberOfCopies = 1;
        }

        public override string ToString()
        {
            return $"Library Item ID: {base.LibraryItemId}\n"
                  + $"Newspaper Title: {this.NewspaperTitle} [ {this.PublishedOn.ToString("dd-MMM-yyyy")} ]\n"
                  + $"Number of Copies: {base.NumberOfCopies}";
        }
    }
}
