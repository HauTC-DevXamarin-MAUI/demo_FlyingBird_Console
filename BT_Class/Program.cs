using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 10);

            Point minPoint = new Point(0, 0);
            Point maxPoint = new Point(20, 20);
           
            Bird bird = new Bird(minPoint,maxPoint);


            bird.VeChim(point);

            
            while (true)
            {
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    bird.Moverment(key.Key);
                }
                
            }

            Console.ReadLine();
        }
        
    }
}
