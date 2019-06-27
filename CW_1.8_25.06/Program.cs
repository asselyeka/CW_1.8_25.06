using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 8.	Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
a.	не X и не Y;
b.	X или (не X и Y);
c.	(не X и Y) или Y.

     */

namespace CW_1._8_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = false;
            bool y = false;
            do
            {
                do
                {
                    Console.Write("X="); Console.Write(x); Console.Write(";  Y="); Console.Write(y); Console.WriteLine(";");
                    Console.Write("а. не X и не Y      = "); Console.WriteLine(!x && !y);
                    Console.Write("b. X или (не Х и Y) = "); Console.WriteLine(x || (!x && y));
                    Console.Write("c. (не X и Y) или Y = "); Console.WriteLine((!x && y) || y);

                    y = !y;

                } while (y != false);

                x = !x;

            } while (x != false);
            
            Console.ReadKey();
        }
    }
}
