//#define p Console.WriteLine

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Proc
{
    class Program
    {
        static void p(int t) { Console.WriteLine(t); }
        static void p(double t) { Console.WriteLine(t); }
        static void p(string t) { Console.WriteLine(t); }
        static void Main(string[] args)
        {
            
        }

        static int Sign(double x)
        {
            int res = 0;
            res = x == 0 ? 0 : (x < 0 ? -1 : 1);
            return res;
        }

        static double CircleS (int r) { return 3.14f * r * r; }

        static double RingS (int r1, int r2) { return CircleS(r1) - CircleS(r2); }

        static double TriangleP (double a, double h)
        {
            double b = 0, S = 0;
            b = Math.Sqrt((a / 2) * (a / 2) + h * h);
            S = b + b + a;
            return S;
        }

        static int SumRange (int a, int b)
        {
            int Sum = 0;
            if (a > b) return 0;
            for (int i = a; i < b; i++) {Sum += i;}
            return Sum;
        }

        static int Calc (int a, int b, int Op)
        {
            int res = 0;
            switch (Op)
            {
                case 1:
                    res = a - b;
                    break;
                case 2:
                    res = a * b;
                    break;
                case 3:
                    res = a / b;
                    break;
                default:
                    res = a + b;
                    break;
            }
            return res;
        }

        static int Quarter (int x, int y)
        {
            int res = 0;
            if (x == 0 || y == 0) res = 0;
            if (x > 0 && y > 0) res = 1;
            if (x > 0 && y < 0) res = 2;
            if (x < 0 && y < 0) res = 3;
            if (x < 0 && y > 0) res = 4;
            return res;
        }

        static bool Even (int k) { return k % 2 == 0 ? true : false; }

        static bool IsSquare (int k)
        {
            return Math.Sqrt(k) % 1 == 0;
        }

        static void Ex16(int A, int B)
        {
            int res = Sign(A) + Sign(B);
        }

        static void Ex17 (int A, int B, int C) {/* я не вчив квад. рівняння*/ }

        static void Ex18 (int A, int B, int C)
        {
            double S1 = 0, S2 = 0, S3 = 0;
            S1 = CircleS(A);
            S2 = CircleS(B);
            S3 = CircleS(C);
        }

        static void Ex19 (int ar1, int ar2, int br1, int br2, int cr1, int cr2)
        {
            double S1 = 0, S2 = 0, S3 = 0;
            S1 = RingS(ar1, ar2);
            S2 = RingS(br1, br2);
            S3 = RingS(cr1, cr2);
        }

        static void Ex20 (double a1, double a2, double a3, double h1, double h2, double h3)
        {
            double S1 = 0, S2 = 0, S3 = 0;
            S1 = TriangleP(a1, h1);
            S2 = TriangleP(a2, h2);
            S3 = TriangleP(a3, h3);
        }

        static void Ex21 (int a, int b, int c)
        {
            int ab, bc;
            ab = SumRange(a, b);
            bc = SumRange(b, c);
        }

        static void Ex22 (int a, int b, int n1, int n2, int n3)
        {
            int res1 = Calc(a, b, n1);
            int res2 = Calc(a, b, n2);
            int res3 = Calc(a, b, n3);
        }

        static void Ex23 (int x1, int x2, int x3, int y1, int y2, int y3)
        {
            int res1 = Quarter(x1, y1);
            int res2 = Quarter(x2, y2);
            int res3 = Quarter(x3, y3);
        }

        static void Ex24 (int[] arr)
        {
            int v = 0;
            foreach (int i in arr)
            {
                v += Even(arr[i]) ? 1 : 0;
            }
        }

        static void Ex25 (int[] arr)
        {
            int sv = 0;
            foreach (int i in arr) { sv += IsSquare(arr[i]) ? 1 : 0; }

        }
    }
}
