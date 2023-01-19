using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _icons;

        public PointIconFactory()
        {
            _icons = new Dictionary<PointType, PointIcon>();
        }

        public PointIcon getPointIcon(PointType type)
        {
            if (!_icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, new int[10] { 10,0,12,32,4,53,2,3,4,54});
                this._icons.Add(type, icon);
            }

            return _icons.GetValueOrDefault(type);
        }
    }
}
