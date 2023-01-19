using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class SelectionTool: Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("selection tool mouse down");
        }
        public void mouseUp()
        {
            Console.WriteLine("selection tool mouse up");
        }
    }
}
