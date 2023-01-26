using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IIterator<T>
    {
        bool hasNext();
        T current();
        void next();

    }
}
