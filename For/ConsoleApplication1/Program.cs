using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void p (int Num) { Console.WriteLine(Num); }

        static void Main(string[] args)
        {
            ex40(2, 4);
        }

        

        void ex1F(int N, int K)
        {
            for (int i = 0; i <= N; i++)
            {
                p(K);
            }
        }

        void ex2 (int A, int B)
        {
            int IndexFor = 0;
            for (int i = A++; i < B; i++)
            {
                p(i);
                IndexFor++;
            }
            p(IndexFor);
        }

        void ex3(int A, int B)
        {
            int IndexFor = 0;
            for (int i = B--; i > A; i--)
            {
                p(i);
                IndexFor++;
            }
            p(IndexFor);
        }

        void ex4F(int N)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * N);
            }
        }

        static void ex5F(int N)
        {
            for (float i = 0.1f; i <= 1.0; i += 0.1f)
            {
                Console.WriteLine(i * N);
            }
            Console.Read();
        }

        static void ex6F(int N)
        {
            for (float i = 1.0f; i <= 2.0f; i += 0.2f)
            {
                Console.WriteLine(i * N);
            }
            Console.Read();
        }

        void ex7F(float a, float b)
        {
            float n = 0;
            for (float i = a++; i < b; i++)
            {
                n += i;
            }
            Console.WriteLine(n);
        }

        void ex8_19 (int a, int b)
        {
            int mn = 1;
            for (int i = a; i <= b; i++)
            {
                mn *= i;
            }
        }

        void ex9(int a, int b)
        {
            int mn = 1;
            for (int i = a; i <= b; i++)
            {
                mn += (i * i);
            }
        }

        static void ex10(int n)
        {
            float mn = 1;
            for (int i = 2; i <= n; i++)
            {
                mn += (1.0f / i);
            }
        }

        static int ex11(int N)
        {
            int n = N;
            int m = 0;
            for (int i = N; i <= 2 * N; i++)
            {
                m += (i) * (i);
                p(m);
            }
            return n;
        }

        void ex12(int n)
        {
            float mn = 1;
            for (int i = 1; i <= n; i++)
            {
                mn *= 1 + (i / 10);
            }
        }

        void ex13(int n)
        {
            float mn = 1.1f;
            for (int i = 1; i <= n; i+=2)
            {
                mn -= 1 + (i++ / 10);
                mn += 1 + (i + 2) / 10;
            }
        }

        void ex15 (int A, int N)
        {
            int mn = 1;
            for (int i = 0; i <= N; i++)
            {
                mn *= A;
                p(mn);
            }
        }

        void ex36(int N, int K)
        {
            int mn = 0;
            int n = 1;
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    n *= i;
                }
                mn += n;
                n = 1;
            }
        }
        

        static void ex37 (int N)
        {
            int mn = 0;
            int n = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    n *= j; 
                }
                mn += n;
            }
            p(mn);
        }

        static void ex38(int N)
        {
            int mn = 0;
            int n = 1;
            for (int i = 0; i <= N; i++)
            {
                for (int j = N; j >= 1; j--)
                {
                    n *= i;
                }
                mn += n;
                n = 1;
            }
        }

        static void ex39 (int A, int B)
        {
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    p(i);
                }
            }
            Console.Read();
        }

        static void ex40(int A, int B)
        {
            int mn = A - 1;
            for (int i = 0; i <= ((B - A) + 1); i++)
            {
                
                for (int j = 0; j < i; j++)
                {
                    p(mn);
                }
                mn++;
            }
            Console.Read();
        }

        static void example ()
        {

        } 
    }
}























