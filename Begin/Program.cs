using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin
{
    class Program
    {
        static void p(int Text) { Console.WriteLine(Text); }
        static void p(double Text) { Console.WriteLine(Text); }
        static void p(string Text) { Console.WriteLine(Text); }

        static void Main(string[] args)
        {
            
        }
        
        static void Ex1 (int a)
        {
            int Res = 4 * a;
            p(Res);
        }

        static void Ex2(int a)
        {
            int Res = a * a;
            p(Res);
        }

        static void Ex3(int a, int b)
        {
            int Res1 = 2 * (a + b);
            int Res2 = a * b;
            p(Res1);
            p(Res2);
        }

        static void Ex4(int d)
        {
            float Res = 3.14f * d;
            p(Res);
        }

        static void Ex5(int a)
        {
            int Res1 = a *a *a;
            int Res2 = 6 * a * a; 
            p(Res1);
            p(Res2);
        }

        static void Ex6(int a, int b, int c)
        {
            int Res1 = a * b * c;
            int Res2 = 2 * (a*b + a*c + b*c);
            p(Res1);
            p(Res2);
        }

        static void Ex7(int r)
        {
            float Res1 = 2 * 3.14f * r;
            float Res2 = 3.14f * r * r;
            p(Res1);
            p(Res2);
        }

        static void Ex8(float a, float b)
        {
            float Res = (a + b) / 2;
            p(Res);
        }

        static void Ex9 (double a, double b)
        {
            double Res = Math.Sqrt(a * b); 
            p(Res);
        }

        static void Ex10(double a, double b)
        {
            double aSq = a * a;
            double bSq = b * b;
            double sum = bSq + aSq;
            double raz = Math.Abs(aSq - bSq);
            double pro = aSq * bSq;
            double chas = aSq / bSq;
            p(sum + " " + raz + " " + pro + " " + chas);
        }

        static void Ex11(double a, double b)
        {
            double am = a * a;
            double bm = b * b;
            double sum = bm + am;
            double raz = Math.Abs(am - bm);
            double pro = am * bm;
            double chas = am / bm;
            p(sum + " " + raz + " " + pro + " " + chas);
        }

        static void Ex12(double a, double b)
        {
            double c = Math.Sqrt(a * a + b * b);
            double Res = a + b + c;
            p(Res);
        }

        static void Ex13(double r1, double r2)
        {
            double S1, S2, S3;
            S1 = 3.14f * r1 * r1;
            S2 = 3.14f * r2 * r2;
            S3 = S1 - S2;
            p(S1 + "," + S2 + "," + S3)
        }
        
        static void Ex14 (double L)
        {
            double r, S;
            r = L / (3.14f * 2);
            S = 3.14f * r * r;
            p(r + "," + S)
        }

        static void Ex15 (double S)
        {
            double L, D, r;
            r = Math.Sqrt(S / 3.14f);
            D = r + r;
            L = 3.14f * D;
        }

        static void Ex16 (double x1, double x2)
        {
            double Res = Math.Abs(x1 - x2);
        }

        //all Int you can change to Double
        static void Ex17 (int A, int B, int C)
        {
            int AC = Math.Abs(A - C);
            int BC = Math.Abs(B - C);
            int AC_BC = AC + BC;//like AC/DC
        }

        static void Ex18(int A, int B, int C)
        {
            int AC = Math.Abs(A - C);
            int BC = Math.Abs(B - C);
            int AC_BC = AC * BC;
        }

        static void Ex19(int x1, int x2, int y1, int y2)
        {
            int Height = Math.Abs(y1 - y2);
            int Length = Math.Abs(x1 - x2);
            int P = 2 * (Height + Length);
            int S = Height * Length;
        }

        static double Ex20(int x1, int x2, int y1, int y2)
        {
            int Height = y1 - y2;
            int Length = x1 - x2;
            double Res = Math.Sqrt((Height * Height) + (Length * Length));
            return Res;
        }

        static void Ex21(int x1, int x2, int y1, int y2, int x3, int y3)
        {
            double a, b, c, P, p, S;
            a = Ex20(x1, x2, y1, y2);
            b = Ex20(x2, x3, y2, y3);
            c = Ex20(x3, x1, y3, y1);
            P = a + b + c;
            p = P / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static void Ex22 (int A, int B)
        {
            int newA = B;
            int newB = A;
            p(newA + " " + newB);
        }

        static void Ex23(int A, int B, int C)
        {
            int nA, nB, nC;
            nB = A;
            nC = B;
            nA = C;
            p(nA + " " + nB + " " + nC);
        }

        static void Ex24(int A, int B, int C)
        {
            int nA, nB, nC;
            nB = C;
            nC = A;
            nA = B;
            p(nA + " " + nB + " " + nC);
        }

        static void Ex25 (int x)
        {
            int y = 3 * x * x * x * x * x * x - 6 * x * x - 7;
        }

        static void Ex26(int x)
        {
            int fun = x - 3;
            int num1 = 1;
            int num2 = 1;
            for (int i = 0; i < 6; i++) { num1 *= fun; }
            for (int i = 0; i < 2; i++) { num2 *= fun; }
            int y = 4 * num1 - 7 * num2 + 2;
        }

        static void Ex27(int a)
        {
            int n = a * a;
            p(n);
            n *= n;
            p(n);
            n *= n;
            p(n);
        }

        static void Ex28 (int a)
        {
            int n = a * a;
            p(n);
            int m = n * a;
            p(m);
            n *= m;
            m = n;
            p(n);
            n *= n;
            p(n);
            n *= m;
            p(n);
        }

        static void Ex29 (int a)
        {
            /*360/2p = a/res
              res = a * 2p / 360
            */
            double res = a * 2 * 3.14f / 360;
        }

        static void Ex30(int a)
        {
            /*2p/360 = a/res
              res = a * 360 / 2p
            */
            double res = a * 360 / (2 * 3.14f);
        }

        static void Ex31 (double TF)
        {
            double TC = (TF - 32) * 5 / 9;
        }

        static void Ex32(double TC)
        {
            double TF = TC * 9 / 5 + 32;
        }

        static void Ex33(int x, int a, int y)
        {
            double Ckg = a / x;
            double CY = Ckg * y;      
        }

        static void Ex34 (int x, int y, int a, int b)
        {
            double CC = a / x;
            double CI = b / y;
            double T = CC / CI;
        }

        static void Ex35 (int v, int u, int t1, int t2)
        {
            int S, s1, s2;
            s1 = v * t1;
            s2 = (v - u) * t2;
            S = s1 + s2;
        }

        static void Ex36 (int v1, int v2, int s1, int t)
        {
            int V, S, s2;
            V = v1 + v2;
            s2 = V * t;
            S = s1 + s2;
        }

        static void Ex37(int v1, int v2, int s1, int t)
        {
            int V, s2, S;
            V = v1 + v2;
            s2 = V * t;
            S = Math.Abs(s1 - s2);
        }
    }
}















