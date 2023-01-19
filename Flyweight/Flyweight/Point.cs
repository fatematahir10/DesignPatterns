using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Point
    {
        int _x;
        int _y;
        PointIcon _pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
            {
            _x = x;
            _y = y;
            _pointIcon = pointIcon;
            }

        public void draw()
        {
            Console.Write("type: " + _pointIcon.PointType + " at (" + _x + "," + _y + "), icon:");
            foreach(var item in _pointIcon.Icon)
                Console.Write(item + " ");
            Console.Write("\n");
        }
    }
}
