using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean
{
    class Program
    {
        static void p(string Text) { Console.WriteLine(Text); }

        static void Main(string[] args)
        {

        }

        static void ex1(int A)
        {
            if (A > 0) p("it`s +");
            else p("it`s - or 0");
        }

        static void ex2(int A)
        {
            if (A < 0) p("it`s -");
            else p("it`s + or 0");
        }

        static void ex3(int A)
        {
            if (A % 2 != 1) p("it`s %2");
            else p("it`s !%2");
        }

        static void ex4(int A, int B)
        {
            if (A > 2 && B <= 3) p("A > 2 and B <= 3");
            else p("NOPE");
        }

        static void ex5(int A, int B)
        {
            if (A >= 0 && B < -2) p("A >= 0 && B < -2");
            else p("NOPE");
        }

        static void ex6_7(int A, int B, int C)
        {
            if (A < B && B < C) p("A < B < C");
            else p("NOPE");
        }

        static void ex8(int A, int B)
        {
            if (A % 2 == 1 && B % 2 == 1) p("they`re not %2");
            else p("they`re !%2");
        }

        static void ex9(int A, int B)
        {
            if (A % 2 == 1 || B % 2 == 1) p("one of them isn`t %2");
            else p("they`re !%2");
        }

        static void ex10(int A, int B)
        {
            if (A % 2 == 1 && B % 2 == 1) return;
            else if (A % 2 == 1 || B % 2 == 1) p("one of them isn`t %2");
            else p("they`re !%2");
        }

        static void ex11(int A, int B)
        {
            if ((A % 2 == 1 && B % 2 == 1) || (A % 2 != 1 && B % 2 != 1)) p("one of them isn`t %2");
            else p("they`re !%2");
        }

        static void ex12(int A, int B, int C)
        {
            if (A > 0 && B > 0 && C > 0) p("Yes");
            else p("NOPE");
        }

        static void ex13(int A, int B, int C)
        {
            if (A > 0 || B > 0 || C > 0) p("Yes");
            else p("NOPE");
        }

        static void ex14(int A, int B, int C)
        {

        }

        static void ex15(int A, int B, int C)
        {

        }

        static void ex16 (int A)
        {
            if (A < 100 && A % 2 != 1) p("Yes");
            else p("NOPE");
        }

        static void ex17(int A)
        {
            if (A < 1000 || A % 2 == 1) p("Yes");
            else p("NOPE");
        }

        static void ex18 (int A, int B, int C)
        {
            if (A == B || B == C || C == A) p("Yes");
            else p("NOPE");
        }

        static void ex19 ()
        {

        }

        static void ex20 (int A)
        {
            if (!(A >= 100 && A < 1000)) return;
            int s1 = A / 100;
            int s2 = (A % 100) / 10;
            int s3 = (A % 100) % 10;
            if (s1 != s2 && s2 != s3 && s3 != s1) p("Yes");
            else p("Nope");
        }

        static void ex21 (int A)
        {
            int s1 = A / 100;
            int s2 = (A % 100) / 10;
            int s3 = (A % 100) % 10;
            if (s1 < s2 < s3) p("Yes");
            else p("Nope");
        }

        static void ex22(int A)
        {
            int s1 = A / 100;
            int s2 = (A % 100) / 10;
            int s3 = (A % 100) % 10;
            if (s1 < s2 < s3) p("Yes from lowest to the largest");
            else if (s1 > s2 > s3) p("Yes from the largest to lowest");
            else p("Nope");
        }

        static void ex23(int A)
        {
            int s0 = A / 1000;
            int s1 = (A % 1000) / 100;
            int s2 = ((A % 1000) % 100) / 10;
            int s3 = ((A % 1000) % 100) % 10;
            if ((s3 * 1000) + (s2 * 100) + (s1 * 10) + s0 == A) p("Yes");
            else p("Nope");
        }

        // if length
        static void ex30 (int a, int b, int c)
        {
            if (a == b && b == c) p("Yes");
            else p("Nope");
        }
        // if length
        static void ex31 (int a, int b, int c)
        {
            if (a == b || b == c || a == c) p("Yes");
            else p("Nope");
        }
        // if length
        static void ex32(int a, int b, int c)
        {
            if (a * a + b * b == c * c) p("Yeeeeep");
            else p("Nope");
        }
        //if degreeses
        static void ex33 (int a, int b, int c)
        {
            if (a + b + c <= 180) p("Yes");
            else p("Nope");
        }

        static void ex34 (int x, int y)
        {
            if ((x % 2 != 1 && y % 2 != 1) || (x % 2 == 1 && y % 2 == 1)) p("black");
            else p("white");
        }

        static void ex35(int x, int y, int x2, int y2)
        {
            bool a, b;
            if ((x % 2 != 1 && y % 2 != 1) || (x % 2 == 1 && y % 2 == 1)) { p("black"); a = true; }
            if ((x2 % 2 != 1 && y2 % 2 != 1) || (x2 % 2 == 1 && y2 % 2 == 1)) { p("black"); a = true; }
            if (a == b) p("Yes");
        }

        static void ex36 (int x, int y, int x2, int y2)
        {
            if (x == x2 || y == y2) p("Yes");
            else p("Nope");
        }

        static void ex37(int x, int y, int x2, int y2)
        {
            int Ymagn, Xmagn;

            Ymagn = Math.Abs(y - y2);
            Xmagn = Math.Abs(x - x2);

            if (Ymagn <= 1 && Xmagn <= 1) p("Yes");
            else p("Nope");
        }

        static void ex38 (int x, int y, int x2, int y2)
        {
            if (x == y && x2 == y2) p("Yes");
            else p("Nope");
        }

        static void ex39(int x, int y, int x2, int y2)
        {
            if ((x == x2 || y == y2) || (x == y && x2 == y2)) p("Yes");
        }
    }
}
