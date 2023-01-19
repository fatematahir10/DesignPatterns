using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    interface IComponent
    {
        void render();
        IComponent clone();
        void printValues();
    }
}
