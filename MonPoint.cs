using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgEven2026
{
    public class MonPoint
    {
        private int x, y;

        public MonPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

    }
}
