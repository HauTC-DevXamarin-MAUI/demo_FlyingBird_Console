using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BT_Class
{
    public class GameController
    {
        Point diemPoint=new Point(20,2);

        int diem = 0;

        public void Game()
        {
            Point point = new Point(10, 15);

            Point minPoint = new Point(5, 3);
            Point maxPoint = new Point(100, 27);

           
            Random rand = new Random();
            Point coinPoint = new Point(rand.Next(minPoint.X+1, maxPoint.X-1), rand.Next(minPoint.Y+2, maxPoint.Y-2));

            

            Map map = new Map(minPoint, maxPoint);
            map.VeMap();

            Bird bird = new Bird(minPoint, maxPoint);
            bird.VeChim(point);

            Coin coin = new Coin(minPoint, maxPoint);
            Diem();
            int timer=1;
            coin.IsGotten = true;
            while (true)
            {
                Thread.Sleep(1);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    bird.Moverment(key.Key);
                }
                if (isTrigger(bird,coin) && !coin.IsGotten )
                {
                    coin.IsGotten = true;
                    coinPoint = new Point(rand.Next(minPoint.X + 1, maxPoint.X - 1), rand.Next(minPoint.Y + 2, maxPoint.Y - 2));
                    diem++;
                    Diem();                    
                    Console.Write("\a");
                }
                if (timer % 200 == 0 && coin.IsGotten)
                {
                    coin.VeCoin(coinPoint);
                    coin.IsGotten = false;
                }

                timer ++;
                if (timer >= 1000000)
                {
                    timer = 1;
                }

                if (timer % coin.CoinSpeed == 0 && coin.IsGotten)
                {
                    
                    coin.Moverment();
                }
            }
        }

        private void Diem()
        {
            Console.SetCursorPosition(diemPoint.X,diemPoint.Y);
            Console.Write("Diem: {0,4}",diem);
            Method.ReturnCurrsor(new Point(0, 0));
        }

        private bool isTrigger(Bird bird,Coin coin)
        {
            if (bird != null && coin != null && coin.CurrentPoint != null)
            {
                Point coinPoint = coin.CurrentPoint;
                Point birdPoint = bird.CurrentPoint;

                if (coinPoint.X >= birdPoint.X && 
                    coinPoint.X < birdPoint.X + bird.GetBirdWeidth() && 
                    coinPoint.Y >= birdPoint.Y && 
                    coinPoint.Y < birdPoint.Y + bird.GetBirdWeidth())
                {
                    return true;
                }
            }

            return false;
        }

    }
}
