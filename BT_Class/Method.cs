using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Class
{
    public class Method
    {
        public static void ReturnCurrsor(Point point)
        {
            Console.SetCursorPosition(point.X,point.Y);
        }
    }
}
