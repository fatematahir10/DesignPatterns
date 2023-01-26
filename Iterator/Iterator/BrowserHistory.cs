using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class BrowserHistory
    {
        List<string> _urls;

        public BrowserHistory()
        {
            _urls = new List<string>();
        }

        public void push(string url)
        {
            _urls.Add(url);
        }

        public string pop()
        {
            return _urls[_urls.Count - 1];
        }

        public IIterator<string> createIterator(){
            return new ListIterator<string>(_urls);
        }
    }
}
