using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void p(int t) { Console.WriteLine(t); }
        static void p(string t) { Console.WriteLine(t); }
        static void p(double t) { Console.WriteLine(t); }
        static void p(float t) { Console.WriteLine(t); }

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++) arr[i] = (r.Next() - 5);
            Ex9(10, arr);


        }

        static void Ex1(double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            p(sum);
        }

        static void Ex2(int [] nums)
        {
            int pro = 1;
            for (int i = 0; i < nums.Length; i++) pro *= nums[i];

        }

        static void Ex3 (int [] nums)
        {
            double Sa = 0;
            double sum = 0;
            for (int i = 0; i < nums.Length; i++) sum += nums[i];
            Sa = sum / nums.Length;
            p(Sa);
        }

        static void Ex4 (int n, int[] nums)
        {
            int sum = 0, pro = 1;
            for (int i = 0; i < n; i++)
            { sum += nums[i];
              pro *= nums[i]; }
            
        }
        
        static void Ex9 (int n, int[] nArr)
        {
            int k = 0;
            for (int i = 0; i < nArr.Length; i++) {
                if (nArr[i] > 0)
                {
                    k++;
                    p(nArr[i]);
                }

            }
        }
    }
}














