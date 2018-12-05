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
            if (A < 100 || A % 2 != 1) p("Yes");
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

        static void ex20 (int A)
        {
            if (!(A >= 100 && A < 1000)) return;
            int s1 = A / 100;
            int s2 = (A % 100) / 10;
            int s3 = (A % 100) % 10;
            if (s1 != s2 && s2 != s3 && s3 != s1) p("Yes");
            else p("Nope");
        }
    }
}
