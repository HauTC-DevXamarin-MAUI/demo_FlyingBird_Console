using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Class
{
    class Map
    {
        private Point minPoint, maxPoint;
        internal Point MaxPoint
        {
            get { return maxPoint; }
            set { maxPoint = value; }
        }
        internal Point MinPoint
        {
            get { return minPoint; }
            set { minPoint = value; }
        }
        #region Constructor
        public Map(Point minPoint, Point maxPoint)
        {
            this.MinPoint = minPoint;
            this.MaxPoint = maxPoint;
        }

        #endregion

        public void VeMap()
        {
            for (int i = MinPoint.X; i <= MaxPoint.X; i++)
            {
                Console.SetCursorPosition(i, MinPoint.Y);
                Console.Write("+");
            }

            for (int i = MinPoint.Y + 1; i < MaxPoint.Y; i++)
            {
                for (int j = MinPoint.X; j <= MaxPoint.X; j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (j == MinPoint.X || j == MaxPoint.X)
                    {
                        Console.Write("|");
                    }

                }
            }

            for (int i = MinPoint.X; i <= MaxPoint.X; i++)
            {
                Console.SetCursorPosition(i, MaxPoint.Y);
                Console.Write("+");
            }
        }
    }
}
