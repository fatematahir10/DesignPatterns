using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.SetState("State1");
            originator.SetState("State2");
            CareTaker caretaker = new CareTaker();
            caretaker.Memento = originator.SaveState();
            originator.SetState("State3");
            originator.RestoreState(caretaker.Memento);
            Console.ReadKey();
        }
    }
}
