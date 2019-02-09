using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Ex1 (int n)
        {
            int[] arr = new int[n];
            for(int i = 0, j = 1; i < arr.Length; i++, j += 2) { arr[i] = j; }
        }

        static void Ex2 (int n)
        {
            int[] arr = new int[n];
            for (int i = 0, j = 2; i < arr.Length; i++, j *= j) { arr[i] = j; }
        }

        static void Ex3(int n, int a, int d)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++, ) { arr[i] = a + d * i; }
        }

        static void Ex4(int n, int a, int d)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++, )
            {
                int D = 1;
                for (int j = 0; j < i; j++, D *= d) 
                arr[i] = a + D;
            }
        }

        static void Ex5(int n)
        {
            int[] arr = new int[n];
            arr[0] = 1; arr[1] = 1;
            for(int i = 2; i < n; i++) arr[i] = arr[i - 2] + arr[i - 1];

        }

        static void Ex6 (int a, int b, int n)
        {
            int[] arr = new int[n];
            arr[0] = a; arr[1] = b;
            for (int i = 2; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < i; j++) sum += arr[j];
                arr[i] = sum;
            }
        }

        static void Ex7(int[] arr, int n)
        {
            for (int i = n - 1; i >= 0; i--) Console.WriteLine(arr[i]);
        }

        static void Ex8 (int[] arr, int n)
        {
            int k = 0;
            foreach (int i in arr)
            {
                if(arr[i] % 2 != 0) { k++; Console.WriteLine(arr[i]); }
            }
        }

        static void Ex9(int[] arr, int n)
        {
            int k = 0;
            for (int i = n-1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0) { k++; Console.WriteLine(arr[i]); }
            }
        }

        static void Ex10(int[] arr, int n)
        {
            foreach (int i in arr)
            {
                if (arr[i] % 2 == 0) Console.WriteLine(arr[i]);
            }

            for (int i = arr.Length - 1; i <= 0; i--)
            {
                if (arr[i] % 2 != 0) Console.WriteLine(arr[i]);
            }
        }

        static void Ex11 (int[] arr, int k)
        {
            for (int i = k; i < arr.Length; i *= 2) { Console.WriteLine(arr[i]); }
        }

        static void Ex12(int[] arr)
        {
            for (int i = 0; i < arr.Length; i += 2) { Console.WriteLine(arr[i]); }
        }

        static void Ex13(int[] arr)
        {//only odd
            for (int i = arr.Length - 2; i >= 1; i -= 2) { Console.WriteLine(arr[i]); }
        }

        static void Ex14(int[] arr, int n)
        {
            for (int i = 0; i < n; i += 2) Console.WriteLine(arr[i]);
            for (int i = 1; i < n; i += 2) Console.WriteLine(arr[i]);
        }

        static void Ex15 (int[] arr, int n)
        {
            int nCorrect = n % 2 == 0 ? n - 2 : n - 1;
            for (int i = 1; i < n; i += 2) Console.WriteLine(arr[i]);
            for (int i = nCorrect; i <= 0; i += 2) Console.WriteLine(arr[i]);
        }

        static void Ex16(int[] arr, int n)
        {
            int nCorrect = n % 2 == 0 ? n - 2 : n - 1;
            int[] arrCorrect = new int[n * 2];
            for (int i = 0, j = 0; i < n; i++, j += 2) { arrCorrect[j] = arr[i]; }
            for (int i = nCorrect, j = 1; i >= 1; i--, j += 2) arrCorrect[j] = arr[i];
            foreach (int item in arrCorrect)
            {
                Console.WriteLine(arrCorrect[item]);
            }
            
        }

        // __________________________________________________________________________________________________________________
        
        static int Ex18 (int[] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] < arr[9]) return arr[i];
            }
            return 0;
        }

        static int Ex19(int[] arr)
        {
            for (int i = 9; i > 1; i--)
            {
                if (arr[0] < arr[i] && arr[i] < arr[9]) return arr[i];
            }
            return 0;
        }

        static int Ex20 (int[] arr, int k, int l)
        {
            int sum = 0;
            for (int i = k; i <= l; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int Ex21(int[] arr, int k, int l)
        {
            int sum = 0, res = 0;
            for (int i = k; i <= l; i++)
            {
                sum += arr[i];
            }
            res = sum / (Math.Abs(l - k) + 1);
            return res;

        }

        static float Ex22 (int[] arr, int k, int l)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                i = arr[0];
                if (k <= i && i <= l) continue;
                sum += i;
            }
            float res = sum / (k - 1 + arr.Length - l - 1);
            return res;
        }

        static int Ex24 (int[] arr)
        {
            int d = arr[1] - arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[0] + d * i != arr[i]) return 0;
            }
            return d;
        }

        /*static int Ex25(int[] arr)
        {
            int d = arr[1] - arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] + d * i != arr[i]) return 0;
            }
            return d;
        }*/

        //static void Ex26 ()
    }
