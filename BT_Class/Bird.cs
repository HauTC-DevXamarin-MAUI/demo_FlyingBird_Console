using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Class
{
    public class Bird
    {
        const int birdWedth = 3;
        const int birdHeight = 3;

        private Point currentPoint;

        public Point CurrentPoint
        {
            get { return currentPoint; }
            set { currentPoint = value; }
        }

        private Point minPoint, maxPoint;
        public Point MaxPoint
        {
            get { return maxPoint; }
            set { maxPoint = value; }
        }
        public Point MinPoint
        {
            get { return minPoint; }
            set { minPoint = value; }
        }

        public void VeChim(Point point)
        {
            Console.Clear();
            currentPoint = new Point(point);

            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("===");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("===");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("==="); 
        }

        public void Moverment(ConsoleKey key)
        {
            Point newPoint = new Point(currentPoint);
            bool isMove=true ;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (--newPoint.X < minPoint.X)
                    {
                        isMove = false;
                    }
                    else
                    {
                        newPoint.X--;
                    }                    
                    break;
                case ConsoleKey.RightArrow:
                     if (++newPoint.X  + birdWedth > maxPoint.X)
                    {
                        isMove = false;
                    }
                    else
                    {
                        newPoint.X++;
                    }                    
                    break;
                case ConsoleKey.UpArrow:
                     if (--newPoint.Y < minPoint.Y)
                    {
                        isMove = false;
                    }
                    else
                    {
                        newPoint.Y--;
                    }                    
                    break;
                case ConsoleKey.DownArrow:
                     if (++ newPoint.Y + birdHeight> maxPoint.Y)
                    {
                        isMove = false;
                    }
                    else
                    {
                        newPoint.Y++;
                    }                    
                    break;
                default:
                    isMove = false;
                    break;
                
            }
            if (isMove)
            {
                VeChim(newPoint);
            }
           
            
        }

        #region Constructor
        public Bird(Point minPoint, Point maxPoint)
        {
            this.MinPoint = minPoint;
            this.MaxPoint = maxPoint;
        }
        #endregion

    }
}
