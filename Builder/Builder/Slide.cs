using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Slide
    {
        string _text;
        public Slide(string text)
        {
            _text = text;
        }

        public string Text { get => _text; }
    }
}
