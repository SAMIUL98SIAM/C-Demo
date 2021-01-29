using System;
using System.Collections.Generic;
using System.Text;

namespace BookDemo.IO
{
    abstract class BookParentIO
    {
        protected abstract void collectBookData();
        protected abstract void addQuantity(int bookQuantity);
        protected abstract void sellQuantity(int bookQuantity);

        public virtual void showDetails()
        {
            Console.WriteLine("Begin Operation");
        }
    }
}
