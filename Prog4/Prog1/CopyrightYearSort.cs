// Program 4
// CIS 200-01
// Due: 4/18/2018
// By: Z9467

// File: Program.cs
// Program using Program 1B to sort the title and copyright year with IComparable and Comparers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class CopyrightYearSort : Comparer<LibraryItem>
    {
        //Precondition: CopyrightYearSort : Comparer<LibraryItem>
        //Postcondition: Compares items by their copyright year and sorts them in descending order when put in sort method
        public override int Compare(LibraryItem x, LibraryItem y)
        {
            if (x == null && y == null)
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            return y.CopyrightYear.CompareTo(x.CopyrightYear);
        }
    }
}
