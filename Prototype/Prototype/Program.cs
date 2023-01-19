using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Design Pattern: Create new objects by copying an existing object");
            var valve = new Valve(10);
            valve.render();
            var contextMenu = new ContextMenu();
            var newValve = contextMenu.duplicate(valve);
            valve.printValues();
            newValve.printValues();
        }
    }
}
