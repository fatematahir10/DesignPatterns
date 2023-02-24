using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento
    {
        public string state { get; set; }
        public Memento(string state)
        {
            this.state = state;
        }
    }
}
