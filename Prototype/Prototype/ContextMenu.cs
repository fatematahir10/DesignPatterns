using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class ContextMenu
    {
        public IComponent duplicate(IComponent component)
        {
            return component.clone();
        }
    }
}
