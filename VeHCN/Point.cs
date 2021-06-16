using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeHCN
{
    class Point
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        #region Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        //overloading
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
        }
        #endregion
        
    }
}
