using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeHCN
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10,10);
            Point minPoint = new Point(5,10);
            Point maxPoint = new Point(60,20);
            Map map = new Map(minPoint,maxPoint);
            map.VeMap();

            Console.ReadLine();
        }
    }
}
