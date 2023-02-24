using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Originator
    {
        public string state { get; set; }

        public void SetState(string state)
        {
            Console.WriteLine("Setting state to " + state);
            this.state = state;
        }

        public Memento SaveState()
        {
            Console.WriteLine("Saving to Memento.");
            return new Memento(state);
        }

        public void RestoreState(Memento memento)
        {
            this.state = memento.state;
            Console.WriteLine("State after restoring from Memento: " + state);
        }
    }
}
