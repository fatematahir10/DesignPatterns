using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Movie
    {
        public void addFrame(string text)
        {
            Console.WriteLine("Adding Frame:" + text);
        }
    }
}
