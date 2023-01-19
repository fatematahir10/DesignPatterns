using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State Design Pattern: Alter an object behavior when its state changes");
            var canvas = new Canvas();
            canvas.Tool = new SelectionTool();
            canvas.mouseDown();
            canvas.mouseUp();
        }
    }
}
