using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Flyweight
{
    class PointIcon
    {
        private readonly PointType _pointType;
        private readonly int[] _icon;

        public PointIcon(PointType type, int[] icon)
        {
            _pointType = type;
            _icon = icon;
        }

        public PointType PointType => _pointType;

        public int[] Icon => _icon;
    }
}
