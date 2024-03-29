﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Class
{
    public class Coin
    {
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
        const string coinChar = "<3";

        private int coinSpeed;
        public int CoinSpeed
        {
            get { return coinSpeed; }
            set { coinSpeed = value; }
        }
                
        private bool isGotten;
        public bool IsGotten
        {
            get { return isGotten; }
            set { isGotten = value; }
        }

        //Hướng di chuyển của coin
        private int directionMove = 0; // 0: <- , 1: ^ , 2: -> , 3: v 

        //Hàm vẽ coin
        public void drawCoin(Point point)
        {
            if (currentPoint != null && !IsGotten)
                deleteCoin();

            currentPoint = new Point(point);

            Console.SetCursorPosition(currentPoint.X, currentPoint.Y);
            Console.Write(coinChar);
            Method.ReturnCurrsor(new Point(0, 0));
        }

        //hàm di chuyển auto của Coin
        public void moverment()
        {
            Random rand = new Random();
            bool isMove = rand.Next(1, 5) % 5 == 0 ? true : false;

            if (isMove)
            {
                directionMove = rand.Next(0, 4);//[0,3]
            }
            move();


        }
        public void move()
        {
            if (currentPoint == null)
                return;
            Point newPoint = new Point(currentPoint);
            bool isMove = true;
            switch (directionMove)
            {
                case 0:
                    if (--newPoint.X < minPoint.X + 2)
                    {
                        isMove = false;
                    }
                    else
                    {
                        newPoint.X--;                        
                    }
                    break;
                case 1:
                    if (++newPoint.X  > maxPoint.X - 1)
                    {
                        isMove = false;
                    }
                    else
                    {
                        newPoint.X++;                        
                    }
                    break;
                case 2:
                    if (--newPoint.Y < minPoint.Y + 2)
                    {
                        isMove = false;
                    }
                    else
                    {
                        newPoint.Y--;                        
                    }
                    break;
                case 3:
                    if (++newPoint.Y  > maxPoint.Y - 1)
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
                drawCoin(newPoint);
            }
        }

        //Hàm xóa coin (Khi Bird cũng tọa độ với coin thì xóa coin đó)
        public void deleteCoin()
        {
            Point tempPoint = new Point(currentPoint);

            Console.SetCursorPosition(tempPoint.X, tempPoint.Y);
            Console.Write(" ");
            Method.ReturnCurrsor(new Point(0, 0));

        }

        //Khởi tạo coin
        public Coin(Point minPoint, Point maxPoint)
        {
            this.MinPoint = minPoint;
            this.MaxPoint = maxPoint;
            IsGotten = true;
            coinSpeed = 200;            
        }
    }
}
