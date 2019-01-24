using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer
{
    class Program
    {
        static void p(int Text) { Console.WriteLine(Text); }
        static void p(double Text) { Console.WriteLine(Text); }
        static void p(string Text) { Console.WriteLine(Text); }

        static void Main(string[] args)
        {

        }

        static void Ex1 (int l)
        {
            int Res = l / 100;
        }

        static void Ex2(int m)
        {
            int Res = m / 1000;
        }

        static void Ex3(int b)
        {
            int Res = b / 1024;
        }

        static void Ex4(int a, int b)
        {
            int Res = a / b;
        }

        static void Ex5(int a, int b)
        {
            int Res = a % b;
        }

        static void Ex6(int a)
        {
            int Res1 = a / 10;
            int res2 = a % 10;
            p(Res1);
            p(res2);
        }

        static void Ex7(int a)
        {
            int Res1 = a / 10;
            int res2 = a % 10;
            p(Res1 + res2);
            p(Res1 * res2);
        }

        static void Ex8(int a)
        {
            int Res1 = a / 10;
            int res2 = a % 10;
            int FResult = res2 * 10 + Res1;
        }

        static void Ex9(int a)
        {
            int Res = a / 100;
            p(Res);
        }

        static void Ex10(int a)
        {
            int Res1 = (a % 100) / 10;
            int res2 = (a % 100) % 10;
            p(res2);
            p(Res1);
        }

        static void Ex11(int a)
        {
            int Res1 = (a % 100) / 10;
            int res2 = (a % 100) % 10;
            int res3 = a / 100;
            p(res2 + Res1 + res3);
            p(res2 * Res1 * res3);
        }

        static void Ex12(int a)
        {
            int Res1 = (a % 100) / 10;
            int res2 = (a % 100) % 10;
            int res3 = a / 100;
            p(res2 * 100 + Res1 * 10 + res3);
        }

        static void Ex13(int a)
        {
            int Res1 = a % 100;
            int res3 = a / 100;
            p(Res1 * 10 + res3);
        }

        static void Ex14(int a)
        {
            int Res1 = a / 10;
            int Res2 = (a % 100) % 10;
            p(Res2 * 100 + Res1);
        }

        static void Ex15(int a)
        {
            int Res1 = (a % 100) % 10;
            int res2 = (a % 100) / 10;
            int res3 = a / 100;
            p(res2 * 100 + res3 * 10 + Res1);
        }

        static void Ex16(int a)
        {
            int Res1 = (a % 100) % 10;
            int res2 = (a % 100) / 10;
            int res3 = a / 100;
            p(res3 * 100 + Res1 * 10 + res2);
        }

        static void Ex17(int a)
        {
            int Res = (a / 100) % 10;
        }

        static void Ex18(int a)
        {
            int Res = (a / 1000) % 10;
        }

        static void Ex19(int n)
        {
            int Res = n / 60;
        }

        static void Ex20(int n)
        {
            int Res = n / (60 * 60);
        }

        static void Ex21(int n)
        {
            int Res = n % 60;
        }

        static void Ex22(int n)
        {
            int Res = n % (60 * 60);
        }

        static void Ex23(int n)
        {
            int Res = n % (60 * 60) / 60;
        }

        static void Ex24(int a)
        {
            int Res;
        }

        static void Ex25(int a)
        {
            int Res;
        }

        static void Ex26(int a)
        {
            int Res;
        }

        static void Ex27(int a)
        {
            int Res;
        }

        static void Ex28(int a)
        {
            int Res;
        }

        static void Ex29(int a)
        {
            int Res;
        }

        static void Ex30(int a)
        {
            int Res;
        }
    }
}
