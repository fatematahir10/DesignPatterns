using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterator is a behavioral design pattern that allows sequential traversal through a complex data structure without exposing its internal details.");

            BrowserHistory browserHistory = new BrowserHistory();
            browserHistory.push("bentley");
            browserHistory.push("google");

            var urlIterator = browserHistory.createIterator();
            while (urlIterator.hasNext())
            {
                Console.WriteLine(urlIterator.current());
                urlIterator.next();
            }
        }
    }
}
