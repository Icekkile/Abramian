using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsArrays
{
    class Program
    {
        static void p(int T) { Console.WriteLine(T); }
        static void p(string T) { Console.WriteLine(T); }
        static void p(double T) { Console.WriteLine(T); }
        static void p(float T) { Console.WriteLine(T); }

        static void Main(string[] args)
        {
            double f = 1 / 3.0f;
            p(3 * f - 1);
            Console.Read();
        }

        /*static void Dalay (int time)
        {
            int t = time;
            while (t > 0)
            {
                t -= 1;
            }
        }
        */
        static void WhileEx ()
        {
            int hp = 100;
            Random ran = new Random();
            while (hp > 0)
            {
                hp -= ran.Next(1, 11);
                //Dalay(150000000);
                p(hp);
            }
            Console.Read();
        }

        static void ForEx()
        {
            for (int i = 0; i < 10; i++)
            {
                p(i);
            } 
        } 
    }
}
