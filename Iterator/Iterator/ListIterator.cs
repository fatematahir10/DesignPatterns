using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class ListIterator<T> : IIterator<T>
    {
        List<T> _list;
        int _position;

        public ListIterator(List<T> list)
        {
            _list = list;
            _position = 0;
        }

        public T current()
        {
            return _list[_position];
        }

        public bool hasNext()
        {
            return _position < _list.Count;
        }

        public void next()
        {
            if (!hasNext())
                return;

            _position++;
        }
    }
}
