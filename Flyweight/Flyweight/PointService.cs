using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class PointService
    {
        private PointIconFactory _pointIconFactory;

        public PointService(PointIconFactory pointIconFactory)
        {
            _pointIconFactory = pointIconFactory;
        }

        public List<Point> getPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, _pointIconFactory.getPointIcon(PointType.CAFE));
            points.Add(point);
            return points;
        }
    }
}
