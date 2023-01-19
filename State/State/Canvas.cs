using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Canvas
    {
        private Tool _tool;

        internal Tool Tool { get => _tool; set => _tool = value; }

        public void mouseDown()
        {
            _tool.mouseDown();
        }
        public void mouseUp()
        {
            _tool.mouseUp();
        }
    }
}
