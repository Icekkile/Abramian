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

        static bool IsPower5 (int k)
        {
            int v = 5;
            while (v < k) { v *= v; }
            return v == k;
        }

        static bool IsPowerN(int k, int n)
        {
            int v = n;
            while (v < k) { v *= v; }
            return v == k;
        }

        static bool Even (int k) { return k % 2 == 0; }

        static bool IsSquare (int k)
        {
            return Math.Sqrt(k) % 1 == 0;
        }

        static bool IsPrime(int n) => false;

        static int DigitCount (int k)
        {
            string kCount = Convert.ToString(k);
            return kCount.Length;
        }

        static int DigitN (int k, int n)
        {
            string kCount = Convert.ToString(k);
            if (kCount.Length < n) return -1;
            string kTurned = "";
            for (int i = kCount.Length; i > 0; i--) { kTurned += kCount[i]; }
            return Convert.ToInt32 (kTurned[n]);
        }

        static void PowerA3 (int a, ref int b)
        {
            b = a * a * a;
        }

        static void PowerA234(int a, ref int[] res)
        {
            res[0] = a * a;
            res[1] = a * a * a;
            res[2] = a * a * a * a;

        }

        static void Mean(int x, int y, ref double AMean, ref double GMean)
        {
            AMean = (x + y) / 2;
            GMean = Math.Sqrt(x * y);

        }

        static void TrianglePS (double a, ref double P, ref double S)
        {
            P = a * 3;
            S = a * a * Math.Sqrt(3f / 4f);
        }

        static void RectPS (int x1, int x2, int y1, int y2, ref int P, ref int S)
        {
            int a = Math.Abs(x1 - x2);
            int b = Math.Abs(y1 - y2);
            P = (a + b) * 2;
            S = a * b;

        }

        static void DigitCountSum (int k, ref int c, ref int s)
        {
            string CStr = Convert.ToString(k);
            c = CStr.Length;
            char[] SplitedCStr = CStr.ToCharArray();
            foreach (char i in SplitedCStr) s += Convert.ToInt32(i);
        }

        static void InvertDigits (ref int k)
        {
            string CStr = Convert.ToString(k);
            string newStr = "";
            for (int i = CStr.Length - 1; i >= 0; i--) newStr += CStr[i];
            k = int.Parse(newStr);
        }

        static void AddRightDigit (ref int k, int d)
        {
            string res = "";
            res += k;
            res += d;
            k = int.Parse(res);
        }

        static void AddLeftDigit (ref int k, int d)
        {
            string res = "";
            res += d;
            res += k;
            k = int.Parse(res);
            
        }

        static void Swap (ref int x, ref int y)
        {
            int supp = x;
            x = y;
            y = supp;
        }

        static void MinMax (ref int x, ref int y)
        {
            int[] supp = { x, y };
            x = Math.Max(x, y);
            y = Math.Min(supp[0], supp[1]);
        }

        static void SortInc3 (ref int a, ref int b, ref int c)
        {
            MinMax(ref c, ref a);
            MinMax(ref b, ref a);
            MinMax(ref c, ref b);
        }

        static void SortDec3(ref int a, ref int b, ref int c)
        {
            MinMax(ref a, ref c);
            MinMax(ref a, ref b);
            MinMax(ref b, ref c);
        }

        static void ShiftRight3(ref int a, ref int b, ref int c)
        {
            int[] supp = { a, b, c };
            a = supp[2];
            b = supp[0];
            c = supp[1];
        }

        static void ShiftLeft3(ref int a, ref int b, ref int c)
        {
            int[] supp = { a, b, c };
            a = supp[1];
            b = supp[2];
            c = supp[0];
        }

        static void Ex1 (int[] arr)
        {
            int[] resArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) PowerA3(arr[i], ref resArr[i]);
        }

        static void Ex2 (int[] arr)
        {
            // ok?
            int[][] resArr = new int[5][];
            for (int i = 0; i < arr.Length; i++) PowerA234(arr[i], ref resArr[i]);
        }

        static void Ex3 (int a, int b)
        {
            double AMean = 0;
            double GMean = 0;
            Mean(a, b, ref AMean, ref GMean);
        }

        static void Ex4 (double a, double b)
        {
            double P1 = 0, P2 = 0, S1 = 0, S2 = 0;
            TrianglePS(a, ref P1, ref S1);
            TrianglePS(b, ref P2, ref S2);

        }

        static void Ex5 (int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            int P1 = 0, P2 = 0, S1 = 0, S2 = 0;
            RectPS(x1, x2, y1, y2, ref P1, ref S1);
            RectPS(x3, x4, y3, y4, ref P2, ref S2);
        }

        static void Ex6 (int k1, int k2)
        {
            int C1 = 0, C2 = 0, S1 = 0, S2 = 0;
            DigitCountSum(k1, ref C1, ref S1);
            DigitCountSum(k2, ref C2, ref S2);
        }

        static void Ex7 (ref int k1, ref int k2)
        {
            InvertDigits(ref k1);
            InvertDigits(ref k2);
        }

        static void Ex8(ref int k, int d1, int d2)
        {
            AddRightDigit(ref k, d1);
            p(k);
            AddRightDigit(ref k, d2);
            p(k);
        }

        static void Ex9(ref int k, int d1, int d2)
        {
            AddLeftDigit(ref k, d1);
            p(k);
            AddLeftDigit(ref k, d2);
            p(k);
        }

        static void Ex10 (ref int a, ref int b, ref int c, ref int d)
        {
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Swap(ref c, ref b);
            p(a);
            p(b);
            p(c);
            p(d);
        }

        static void Ex11 ()
        {
            //
        }

        static void Ex12(ref int a1, ref int b1, ref int c1, ref int a2, ref int b2, ref int c2)
        {
            SortInc3(ref a1, ref b1, ref c1);
            SortInc3(ref a2, ref b2, ref c2);
        }

        static void Ex13(ref int a1, ref int b1, ref int c1, ref int a2, ref int b2, ref int c2)
        {
            SortDec3(ref a1, ref b1, ref c1);
            SortDec3(ref a2, ref b2, ref c2);
        }

        static void Ex14(ref int a1, ref int b1, ref int c1, ref int a2, ref int b2, ref int c2)
        {
            ShiftRight3(ref a1, ref b1, ref c1);
            ShiftRight3(ref a2, ref b2, ref c2);
        }

        static void Ex15(ref int a1, ref int b1, ref int c1, ref int a2, ref int b2, ref int c2)
        {
            ShiftLeft3(ref a1, ref b1, ref c1);
            ShiftLeft3(ref a2, ref b2, ref c2);
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

        static void Ex26 (int[] arr)
        {
            int sv = 0;
            foreach (int i in arr) { sv += IsPower5(arr[i]) ? 1 : 0; }
        }

        static void Ex27 (int[] arr, int n)
        {
            int sv = 0;
            foreach (int i in arr) { sv += IsPowerN(arr[i], n) ? 1 : 0; }
        }

        static void Ex29 (int[] arr)
        {
            int[] sv = new int[arr.Length];
            foreach (int i in sv) { sv[i] = DigitCount(arr[i]); }
        }

        static void Ex30 (int[] arr)
        {
            int[] ColofNums = new int[arr.Length];
            foreach (int i in ColofNums) { ColofNums[i] = DigitN(arr[i], i)}
        }
    }
}
