using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Valve : IComponent
    {
        int _flow;

        public int Flow { get => _flow;}
        public Valve(int flow)
        {
            _flow = flow;
        }

        public IComponent clone()
        {
            var newValve = new Valve(this._flow);
            return newValve;
        }

        public void render()
        {
            Console.WriteLine("Rendering a valve");
        }

        public void printValues()
        {
            Console.WriteLine(_flow.ToString());
        }
    }
}
