using System;
using System.Data;

namespace Lesson_1
{
    class Pro
    {
        static void zhaoshu()
        {
            int[] arr = { 6, -5, 4, -8, 89, 1, 3, 0 };

            int b = 0;
            int c = 0;
            int d = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                if (arr[a] > 0)
                {
                    b++;
                }
                if (arr[a] == 0)
                {
                    c++;
                }
                if (arr[a] < 0)
                {
                    d++;
                }

            }
            Console.WriteLine("数组中正数的个数是{0}", b);
            Console.WriteLine("数组中0的个数是{0}", c);
            Console.WriteLine("数组中负数的个数是{0}", d);
        }
        static void zhaohehepingjunzhi()
        {
            int[] arr = { 6, -5, 4, -8, 89, 1, 3, 0 };
            int b = 0;
            int c = 0;
            for(int a = 0; a < arr.Length; a++)
            {
               
                    if (arr[a] % 2 == 0)
                    {
                        b = b + arr[a];
                        c++;
                    }
               
                
                
            }
            double d = (double)b / c;
            Console.WriteLine("数组偶数求和为{0}", b);
            Console.WriteLine("数组偶数平均值为{0}",d);
        }
        static void zhaodayupingjuznhi()
        {
            int[] arr = { 6, -5, 4, -8, 89, 1, 3, 0 };
            int b = 0;
            int c = 0;
            for (int a = 0; a < arr.Length; a++)
            {

                if (arr[a] % 2 == 0)
                {
                    b = b + arr[a];
                    c++;
                }



            }
            double d = (double)b / c;
            int f = 0;
            for (int e = 0; e < arr.Length; e++)
            {
                if (arr[e] > d)
                {
                    f++;
                }

            }
            Console.WriteLine(f);
        }
        static void zhaozuidazuixiao()
        {
            int[] arr = { 6, -5, 4, -8, 89, 1, 3, 0 };
            for (int m = 0; m < arr.Length; m++)
            {

                for (int n = 0; n < arr.Length - 1 - m; n++)
                {
                    if (arr[n] > arr[n + 1])
                    {
                        int temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;

                    }
                }
            }
            int a = arr[0];
            int b = arr[arr.Length-1];
            int c = arr[arr.Length - 1] - arr[0];
            Console.WriteLine("最小值为{0}",a);
            Console.WriteLine("最大值为{0}",b);
            Console.WriteLine("差值为{0}", c);
        }







        static void Main()
        {
            zhaoshu();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            zhaohehepingjunzhi();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            zhaodayupingjuznhi();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            zhaozuidazuixiao();
        }
    }
}