using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FlyWeight Design Pattern: A fine-grained instance used for efficient sharing (Reduces amount of memory object uses)");

            PointService pointService = new PointService(new PointIconFactory());
            pointService.getPoints().ForEach(point => {
                point.draw();
            });
        }
    }
}
