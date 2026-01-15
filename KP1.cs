using System;
namespace Lesson_1
{
    class Pro
    {
        static void Shuzu(params int[] arr)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i=0;i<arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    a++;
                }
                else if (arr[i] > 0)
                {
                    b++;
                }
                else if (arr[i] < 0)
                {
                    c++;
                }
            }
            Console.WriteLine("нульвые {0}", a);
            Console.WriteLine("положительные {0}", b);
            Console.WriteLine("отрицательные {0}", c);
            int sum = 0;
            for(int m = 0; m < arr.Length; m++)
            {
                sum = sum + arr[m];
            }
            double cpe = (double)sum / arr.Length;
            int temp = 0;
            for(int n = 0; n < arr.Length; n++)
            {
                if (arr[n] > cpe)
                {
                    temp++;
                }
            }
            int index = arr[0];
            for(int e=0;e<arr.Length;e++)
            {
                if (index < arr[e])
                {
                    index = arr[e];
                }
            }
            int index2 = arr[0];
            for (int f = 0; f < arr.Length; f++)
            {
                if (index2 < arr[f])
                {
                    index2 = arr[f];
                }
            }
            int x = index - index2;

        }
        static int Shuzu2(params int[] arr)
        {
            //int[] arr2 = new int[arr.Length];


            //for (int a = 0; a < arr.Length; a++)
            //{
            //    arr2[a] = arr[a];


            //}
            Console.WriteLine("пишите ваше x");

            string about = Console.ReadLine();
            int numabout = int.Parse(about);
            Console.WriteLine("пишите ваше y");

            string abouty = Console.ReadLine();
            int numabouty = int.Parse(abouty);
            //int count = 0;
            //for (int b = 0; b < arr.Length; b++)
            //{
            //    if (arr2[b] != numabout)
            //    {
            //        count++;
            //    }
            //}
            int arr3index2 = 0;
            int arr3index = 0;
            int[] arr3 = new int[arr.Length];
            for (int c = 0; c < arr.Length; c++)
            {
                if (arr[c] != numabout)
                {
                    arr3[arr3index] = arr[c];
                    arr3index++;
                }
                else if(arr[c] == numabout)
                {
                    arr3[arr3index] = numabouty;
                    arr3index++;
                    arr3index2++;
                }
            }
            int[] arr4 = new int[arr3index2];
            for(int i = 0; i < arr3index2; i++)
            {
                arr4[i] = numabouty;
                Console.WriteLine(arr4[i]);
            }
            return arr3index2;

        }
        
        
        static void Main()
        {
            //Shuzu(1, 2, 3, 4, 0, 0, 0);
            Console.WriteLine();
            Shuzu2(1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5);
        }
    }
}