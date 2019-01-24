using System;

namespace If
{
    class Program
    {
        static void p (int t) { Console.WriteLine(t); }
        static void p(string t) { Console.WriteLine(t); }
        static void p(double t) { Console.WriteLine(t); }
        static void Main(string[] args)
        {
            Ex21(0, 5);
        }

        static void Ex1 (int a)
        {
            if (a > 0) a++;
            p(a);
        }

        static void Ex2(int a)
        {
            if (a > 0) a++; else a -=2;
            p(a);
        }

        static void Ex3(int a)
        {
            if (a > 0) a++; else if (a < 0) a -= 2; else a = 10;
            p(a);
        }
        static void Ex4(int a, int b, int c)
        {
            int n = 0;
            if (a > 0) n++;
            if (b > 0) n++;
            if (c > 0) n++;
            p(n);
        }
        static void Ex5(int a, int b, int c)
        {
            int np = 0;
            int nm = 0;
            if (a > 0) np++; else if (a != 0) nm++;
            if (b > 0) np++; else if (b != 0) nm++;
            if (c > 0) np++; else if (c != 0) nm++;
            p($"positive: {np} negative: {nm}");
        }
        static void Ex6(int a, int b)
        {
            if (a > b) p(a); else if (b > a) p(b); else p("They are same");
        }
        static void Ex7()
        {
            //я не поняв завдання
        }
        static void Ex8(int a, int b)
        {
            int bi = 0; int lo = 0;
            if (a > b) { bi = a; lo = b; } else if (b > a) {bi = b; lo = a; } else p("They are same");
            p(bi);
            p(lo);
        }

        static void Ex9 (double a, double b)
        {
            double bi = 0;
            double lo = 0;
            if (a > b) { bi = a; lo = b; } else if (b > a) { bi = b; lo = a; } else p("They are same");
            a = lo;
            b = bi;
            p(a);
            p(b);

        }

        static void Ex10(int a, int b)
        {
            int na, nb;
            if (a != b) { na = a + b; nb = a + b; } else {na = 0; nb = 0; }
            p(na);
            p(nb);
        }

        static void Ex11(int a, int b)
        {
            int bi = 0;
            if (a > b) { bi = a; b = bi; } else if (b > a) { bi = b; a = bi; } else p("They are same");
            p(a);
            p(b);

        }

        static void Ex12(int a, int b, int c)
        {
            int l;
            if (a < b && a < c) l = a;
            if (b < a && b < c) l = b;
            if (c < a && c < b) l = c;
        }

        static void Ex13(int a, int b, int c)
        {
            int m;
            if ((a > b && a < c) || (a < b && a > c)) m = a;
            if ((b > a && b < c) || (b < a && b > c)) m = b;
            if ((c > b && c < a) || (c < b && c > a)) m = c;
        }

        static void Ex14(int a, int b, int c)
        {
            int l = 0;
            if (a < b && a < c) l = a;
            if (b < a && b < c) l = b;
            if (c < a && c < b) l = c;
            
            int bi = 0;
            if (a > b && a > c) bi = a;
            if (b > a && b > c) bi = b;
            if (c > a && c > b) bi = c;

            p(l);
            p(bi);
        }

        static void Ex15(int a, int b, int c)
        {
            int bi = 0;
            if (a > b && a > c) bi = a;
            if (b > a && b > c) bi = b;
            if (c > a && c > b) bi = c;

            int m = 0;
            if ((a > b && a < c) || (a < b && a > c)) m = a;
            if ((b > a && b < c) || (b < a && b > c)) m = b;
            if ((c > b && c < a) || (c < b && c > a)) m = c;

            int sum = m + bi;
        }

        static void Ex16(int a, int b, int c)
        {
            if (a < b && b < c) { a *= 2; b *= 2; c *= 2; } else { a *= -1; b *= -1; c *= -1; }
            p(a);
            p(b);
            p(c);
        }

        static void Ex17(int a, int b, int c)
        {
            if ((a < b && b < c) || (a > b && b > c)) { a *= 2; b *= 2; c *= 2; } else { a *= -1; b *= -1; c *= -1; }
            p(a);
            p(b);
            p(c);
        }

        static void Ex18_19 ()
        {
            //порядковий номер?
        }
        static void Ex20(int a, int b, int c)
        {
            int ab, ac;
            ab = Math.Abs(a - b);
            ac = Math.Abs(a - c);
            if (ab < ac) p($"point: {b}, direction: {ab}"); else if (ab != ac) p($"point: {c}, direction: {ac}");
        }

        static void Ex21 (int a, int b)
        {
            if (a == 0 && b == 0) p(0); else if (a == 0 || a == 0) p(1); else if (b == 0 || b == 0) p(2); else p(3);
        }

        static void Ex22 (int a, int b)
        {
            //a - y
            //b - x
            if (a > 0 && b > 0) p(1);
            if (a < 0 && b > 0) p(2);
            if (a < 0 && b < 0) p(3);
            if (a > 0 && b < 0) p(4);
        }

        static void Ex23 (int x1,int y1, int x2, int y2, int x3, int y3)
        {
            int x4 = 0, y4 = 0;
            if (x1 == x2) x4 = x3;
            if (x1 == x3) x4 = x2;
            if (x3 == x2) x4 = x1;

            if (y1 == y2) y4 = y3;
            if (y1 == y3) y4 = y2;
            if (y3 == y2) y4 = y1;
            
            
            /*
            int nsx1 = 0, nsx2 = 0, lx = 0;
            if (x1 != x2) { nsx1 = x1; nsx2 = x2; lx = x3; }
            if (x1 != x3) { nsx1 = x1; nsx2 = x3; lx = x2; }
            if (x2 != x3) { nsx1 = x2; nsx2 = x3; lx = x1; }

            int nsy1 = 0, nsy2 = 0, ly = 0;
            if (y1 != y2) { nsy1 = y1; nsy2 = y2; ly = y3; }
            if (y1 != y3) { nsy1 = y1; nsy2 = y3; ly = y2; }
            if (y2 != y3) { nsy1 = y2; nsy2 = y3; ly = y1; }

            int Situation = 0;
            if (lx <= nsx1 && ly <= nsy1) Situation = 1;
            if (lx <= nsx1 && ly >= nsy1) Situation = 2;
            if (lx >= nsx1 && ly >= nsy1) Situation = 3;
            if (lx >= nsx1 && ly <= nsy1) Situation = 4;

            int bix = 0, lox = 0;
            if (nsx1 < nsx2) { lox = nsx1; bix = nsx2; } else { lox = nsx2; bix = nsx1; }

            int biy = 0, loy = 0;
            if (nsy1 < nsy2) { loy = nsy1; biy = nsy2; } else { loy = nsy2; biy = nsy1; }

            int nx = 0, ny = 0;
            if (Situation == 1) { nx = bix; ny = biy; }
            if (Situation == 2) { nx = bix; ny = loy; }
            if (Situation == 3) { nx = lox; ny = loy; }
            if (Situation == 4) { nx = lox; ny = biy; }
            */
        }

        static void Ex24 (double x)
        {
            double f;
            if (x > 0) f = 2 * Math.Sin(x);
            if (x <= 0) f = 6 - x;
        }

        static void Ex25 (double x)
        {
            double f;
            if (x < -2 || x > 2) f = 2 * x; else f = -3 * x;  
        }

        static void Ex26 (double x)
        {
            double f;
            if (x <= 0) f = x * -1;
            if (x > 0 && x < 2) f = x * x;
            if (x >= 2) f = 4;

        }

        static void Ex28(int Y)
        {
            bool Vys = false;
            if (Y % 4 == 0 && !(Y % 100 == 0 && Y % 400 != 0)) Vys = true; else Vys = false;
        }

        static void Ex29(int a)
        {
            string des = "";
            if (a == 0) { des += "null"; }
            if (a > 0 && a != 0) { des += "positive"; } else { des += "negative"; }
            if (a % 2 == 0 && a != 0) { des += " even"; } else des += " odd";
            p(des + " number");
        }

        static void Ex30 (int a)
        {
            string des = "";
            bool NOrder = true;
            if (a / 100.0f >= 1 && NOrder) { des += "three symbols "; NOrder = false; }
            if (a / 10.0f >= 1 && NOrder) { des += "two symbols "; NOrder = false; }
            if (a % 2 == 0 && a != 0) { des += "even "; } else des += "odd ";
            p(des += "number");
        }
    }
}
