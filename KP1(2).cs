using System;
namespace Lesson_1
{
    class Pro
    {
        static int shuzu(params int[] arr)
        {
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                temp += arr[i];
            }
            double cpe = (double)temp / arr.Length;
            
            int index = 0;
            for(int m = 0; m < arr.Length; m++)
            {
                if (arr[m] > cpe)
                {
                    index++;
                }
            }
            int[] arr2 = new int[index];
            int index2 = 0;
            for(int n = 0; n < arr.Length; n++)
            {
                if (arr[n] > cpe)
                {
                    arr2[index2] = arr[n];
                    index2++;
                    
                }
               
            }
            return index;
            //for(int b = 0; b < arr2.Length; b++)
            //{
            //    Console.WriteLine(arr2[b]);
            //}

        }
        static void Main()
        {
            Console.WriteLine(shuzu(1, 2, 3, 4, 5, 6, 7, 8, 9));
            
        }
    }
}
